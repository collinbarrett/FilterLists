using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;
using FilterLists.Services.GitHub;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MoreLinq;
using SharpCompress.Archives.SevenZip;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 25000;
        public readonly Data.Entities.FilterList List;
        protected readonly Data.Entities.Snapshot SnapEntity;
        private readonly FilterListsDbContext dbContext;
        private readonly GitHubService gitHubService;
        private readonly Logger logger;
        private readonly string uaString;
        protected string ListUrl;
        private bool isUpdatedDateFromGitHub;
        private HashSet<string> lines;

        public Snapshot()
        {
        }

        [UsedImplicitly]
        public Snapshot(FilterListsDbContext dbContext, Data.Entities.FilterList list, GitHubService gitHubService,
            Logger logger, string uaString)
        {
            this.dbContext = dbContext;
            List = list;
            ListUrl = list.ViewUrl;
            this.gitHubService = gitHubService;
            this.logger = logger;
            SnapEntity = new Data.Entities.Snapshot {FilterListId = list.Id, SnapshotRules = new List<SnapshotRule>()};
            this.uaString = uaString;
        }

        public bool WebExcepted { get; private set; }

        public virtual async Task TrySaveAsync() => await TrySaveAsyncBase();

        protected async Task TrySaveAsyncBase()
        {
            await AddSnapEntity();
            if (!ListUrl.IsValidHttpOrHttpsUrl())
                return;
            await UpdateDatesFromGitHub();
            try
            {
                await SaveAsync();
            }
            catch (Exception e)
            {
                logger.Log(e);
            }
        }

        private async Task AddSnapEntity()
        {
            dbContext.Snapshots.Add(SnapEntity);
            await dbContext.SaveChangesAsync();
        }

        private async Task UpdateDatesFromGitHub()
        {
            var dates = await gitHubService.GetCommitDatesAsync(ListUrl);
            if (dates is null)
                return;
            UpdatePublishedDateFromGitHub(dates.First);
            UpdateUpdatedDateFromGitHub(dates.Last);
            await dbContext.SaveChangesAsync();
        }

        private void UpdatePublishedDateFromGitHub(DateTime? date)
        {
            if (date is DateTime firstDate && (List.PublishedDate is null || firstDate < List.PublishedDate))
                List.PublishedDate = firstDate;
        }

        private void UpdateUpdatedDateFromGitHub(DateTime? date)
        {
            if (date is DateTime lastDate && (List.UpdatedDate is null || lastDate > List.UpdatedDate))
            {
                List.UpdatedDate = lastDate;
                isUpdatedDateFromGitHub = true;
            }
        }

        private async Task SaveAsync()
        {
            await TryGetLines();
            if (lines != null)
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
                logger.Log(hre);
            }
            catch (WebException we)
            {
                WebExcepted = true;
                SnapEntity.HttpStatusCode = (int)((HttpWebResponse)we.Response).StatusCode;
                await dbContext.SaveChangesAsync();
                logger.Log(we);
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
                await GetLinesFromSource(response);
            }
        }

        private async Task GetLinesFromSource(HttpResponseMessage response)
        {
            lines = new HashSet<string>();
            using (var stream = await response.Content.ReadAsStreamAsync())
            using (var memoryStream = new MemoryStream())
            {
                await stream.CopyToAsync(memoryStream);
                memoryStream.Position = 0;
                SetChecksum(memoryStream);
                await SetWasUpdated();
                if (SnapEntity.WasUpdated)
                {
                    UpdateUpdatedDate();
                    memoryStream.Position = 0;
                    if (ListUrl.EndsWith(".7z"))
                        await GetLinesFrom7Zip(memoryStream);
                    else
                        await GetLinesFromStream(memoryStream);
                }

                await dbContext.SaveChangesAsync();
            }
        }

        private void SetChecksum(Stream stream)
        {
            using (var md5 = MD5.Create())
            {
                SnapEntity.Md5Checksum = md5.ComputeHash(stream);
            }
        }

        private async Task SetWasUpdated() =>
            SnapEntity.WasUpdated = !SnapEntity.Md5Checksum.SequenceEqual(await GetPreviousChecksum());

        private async Task<byte[]> GetPreviousChecksum() =>
            await dbContext.Snapshots
                           .Where(s => s.WasSuccessful && s.FilterListId == List.Id)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .Select(s => s.Md5Checksum)
                           .FirstOrDefaultAsync() ?? Array.Empty<byte>();

        private void UpdateUpdatedDate()
        {
            if (isUpdatedDateFromGitHub)
                return;
            List.UpdatedDate = DateTime.Now;
        }

        private async Task GetLinesFrom7Zip(Stream stream)
        {
            using (var archive = SevenZipArchive.Open(stream))
            {
                var archiveEntries = archive.Entries.Where(entry => !entry.IsDirectory);
                foreach (var entry in archiveEntries)
                    using (var entryStream = entry.OpenEntryStream())
                    {
                        await GetLinesFromStream(entryStream);
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
    }
}