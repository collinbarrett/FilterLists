using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;
using Microsoft.ApplicationInsights;
using MoreLinq;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 500;
        private readonly FilterListsDbContext dbContext;
        private readonly FilterListViewUrlDto list;
        private readonly Data.Entities.Snapshot snapEntity;
        private readonly TelemetryClient telemetryClient;
        private readonly string uaString;
        private HashSet<string> lines;

        public Snapshot(FilterListsDbContext dbContext, FilterListViewUrlDto list, string uaString)
        {
            this.dbContext = dbContext;
            this.list = list;
            this.uaString = uaString;
            snapEntity = new Data.Entities.Snapshot
            {
                FilterListId = list.Id
            };
            telemetryClient = new TelemetryClient();
        }

        public async Task TrySaveAsync()
        {
            await AddSnapEntity();
            if (!list.ViewUrl.IsValidHttpOrHttpsUrl())
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
            dbContext.Snapshots.Add(snapEntity);
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
                await dbContext.SaveChangesAsync();
                TrackException(hre);
            }
            catch (WebException we)
            {
                snapEntity.HttpStatusCode = (uint)((HttpWebResponse)we.Response).StatusCode;
                await dbContext.SaveChangesAsync();
                TrackException(we);
            }
        }

        private async Task GetLines()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(uaString);
                var response = await httpClient.GetAsync(list.ViewUrl, HttpCompletionOption.ResponseHeadersRead);
                snapEntity.HttpStatusCode = (uint)response.StatusCode;
                response.EnsureSuccessStatusCode();
                lines = new HashSet<string>();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await streamReader.ReadLineAsync()) != null)
                        lines.AddIfNotNullOrEmpty(line.LintLine());
                }
            }
        }

        private async Task SaveInBatches()
        {
            var snapBatches = CreateBatches();
            await SaveBatches(snapBatches);
        }

        private IEnumerable<SnapshotBatch> CreateBatches() =>
            lines.Batch(BatchSize).Select(b => new SnapshotBatch(dbContext, b, snapEntity));

        private static async Task SaveBatches(IEnumerable<SnapshotBatch> batches)
        {
            foreach (var batch in batches)
                await batch.SaveAsync();
        }

        private async Task SetSuccessful()
        {
            snapEntity.WasSuccessful = true;
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