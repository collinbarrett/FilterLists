using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;
using JetBrains.Annotations;
using Microsoft.ApplicationInsights;
using MoreLinq;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 1000;
        private readonly FilterListsDbContext dbContext;
        public readonly FilterListViewUrlDto List;
        protected readonly Data.Entities.Snapshot SnapEntity;
        private readonly TelemetryClient telemetryClient;
        private readonly string uaString;
        private HashSet<string> lines;
        protected string ListUrl;
        private bool wasWebException;

        public Snapshot()
        {
        }

        [UsedImplicitly]
        public Snapshot(FilterListsDbContext dbContext, FilterListViewUrlDto list,
            string uaString)
        {
            this.dbContext = dbContext;
            List = list;
            ListUrl = list.ViewUrl;
            SnapEntity = new Data.Entities.Snapshot {FilterListId = list.Id, SnapshotRules = new List<SnapshotRule>()};
            this.uaString = uaString;
            telemetryClient = new TelemetryClient();
        }

        public bool RetryMirror => !SnapEntity.WasSuccessful && wasWebException;

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
                wasWebException = true;
                await dbContext.SaveChangesAsync();
                TrackException(hre);
            }
            catch (WebException we)
            {
                wasWebException = true;
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
                using (var streamReader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await streamReader.ReadLineAsync()) != null)
                        lines.AddIfNotNullOrEmpty(line.Trim());
                }
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
            Thread.Sleep(5000);
        }
    }
}