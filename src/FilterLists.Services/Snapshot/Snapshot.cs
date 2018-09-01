using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;
using JetBrains.Annotations;
using Microsoft.ApplicationInsights;
using Microsoft.EntityFrameworkCore;
using MoreLinq;
using SharpCompress.Archives.SevenZip;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 1000;
        public readonly FilterListViewUrlDto List;
        protected readonly Data.Entities.Snapshot SnapEntity;
        private readonly FilterListsDbContext dbContext;
        private readonly TelemetryClient telemetryClient;
        private readonly string uaString;
        protected string ListUrl;
        private HashSet<string> lines;

        public Snapshot()
        {
        }

        [UsedImplicitly]
        public Snapshot(FilterListsDbContext dbContext, FilterListViewUrlDto list, string uaString)
        {
            this.dbContext = dbContext;
            List = list;
            ListUrl = list.ViewUrl;
            SnapEntity = new Data.Entities.Snapshot {FilterListId = list.Id, SnapshotRules = new List<SnapshotRule>()};
            this.uaString = uaString;
            telemetryClient = new TelemetryClient();
        }

        public bool WebExcepted { get; private set; }

        public virtual async Task TrySaveAsync() => await TrySaveAsyncBase();

        protected async Task TrySaveAsyncBase()
        {
            await AddSnapEntity();
            if (!ListUrl.IsValidHttpOrHttpsUrl())
                return;
            try
            {
                await SaveAsync();
            }
            catch (Exception e)
            {
                TrackException(e);
            }
        }

        private async Task AddSnapEntity()
        {
            dbContext.Snapshots.Add(SnapEntity);
            await dbContext.SaveChangesAsync();
        }

        private async Task SaveAsync()
        {
            await TryGetLines();
            if (lines != null && lines.Count > 0)
            {
                await SaveInBatches();
                await SetSuccessful();
            }
        }

        private async Task TryGetLines()
        {
            try
            {
                await GetLines();
            }
            catch (HttpRequestException hre)
            {
                WebExcepted = true;
                await dbContext.SaveChangesAsync();
                TrackException(hre);
            }
            catch (WebException we)
            {
                WebExcepted = true;
                SnapEntity.HttpStatusCode = (int)((HttpWebResponse)we.Response).StatusCode;
                await dbContext.SaveChangesAsync();
                TrackException(we);
            }
        }

        private async Task GetLines()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(uaString);
                var response = await httpClient.GetAsync(ListUrl, HttpCompletionOption.ResponseHeadersRead);
                SnapEntity.HttpStatusCode = (int)response.StatusCode;
                response.EnsureSuccessStatusCode();
                lines = new HashSet<string>();
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        memoryStream.Position = 0;
                        SetChecksum(memoryStream);
                        if (await SaveIsNewChecksum())
                        {
                            memoryStream.Position = 0;
                            if (ListUrl.EndsWith(".7z"))
                                await GetLinesFrom7Zip(memoryStream);
                            else
                                await GetLinesFromStream(memoryStream);
                        }
                    }
                }
            }
        }

        private void SetChecksum(Stream stream)
        {
            using (var md5 = MD5.Create())
            {
                SnapEntity.Md5Checksum = md5.ComputeHash(stream);
            }
        }

        private async Task<bool> SaveIsNewChecksum()
        {
            SnapEntity.WasUpdated =
                !SnapEntity.Md5Checksum.SequenceEqual(await GetPreviousChecksum() ?? Array.Empty<byte>());
            await dbContext.SaveChangesAsync();
            return SnapEntity.WasUpdated;
        }

        private async Task<byte[]> GetPreviousChecksum() =>
            await dbContext.Snapshots
                           .Where(s => s.WasSuccessful && s.FilterListId == List.Id)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .Select(s => s.Md5Checksum)
                           .FirstOrDefaultAsync();

        private async Task GetLinesFrom7Zip(Stream stream)
        {
            using (var archive = SevenZipArchive.Open(stream))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    using (var entryMemoryStream = entry.OpenEntryStream())
                    {
                        await GetLinesFromStream(entryMemoryStream);
                    }
            }
        }

        private async Task GetLinesFromStream(Stream stream)
        {
            using (var streamReader = new StreamReader(stream))
            {
                string line;
                while ((line = await streamReader.ReadLineAsync()) != null)
                    lines.AddIfNotNullOrEmpty(line.Trim());
            }
        }

        private async Task SaveInBatches()
        {
            var snapBatches = CreateBatches();
            await SaveBatches(snapBatches);
        }

        private IEnumerable<Batch> CreateBatches() =>
            lines.Batch(BatchSize).Select(b => new Batch(dbContext, b, SnapEntity));

        private static async Task SaveBatches(IEnumerable<Batch> batches)
        {
            foreach (var batch in batches)
                await batch.SaveAsync();
        }

        private async Task SetSuccessful()
        {
            SnapEntity.WasSuccessful = true;
            await dbContext.SaveChangesAsync();
        }

        private void TrackException(Exception e)
        {
            telemetryClient.TrackException(e);
            telemetryClient.Flush();

            //https://docs.microsoft.com/en-us/azure/application-insights/app-insights-api-custom-events-metrics#flushing-data
            Thread.Sleep(5000);
        }
    }
}