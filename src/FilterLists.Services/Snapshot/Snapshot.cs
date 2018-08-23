using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
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
        private readonly EmailService emailService;
        private readonly FilterListViewUrlDto list;
        private readonly Data.Entities.Snapshot snapEntity;
        private readonly TelemetryClient telemetryClient;
        private readonly string userAgentString;
        private HashSet<string> lines;

        public Snapshot(FilterListsDbContext dbContext, EmailService emailService, FilterListViewUrlDto list,
            string userAgentString)
        {
            this.dbContext = dbContext;
            this.emailService = emailService;
            this.list = list;
            snapEntity = new Data.Entities.Snapshot
            {
                FilterListId = list.Id,
                AddedSnapshotRules = new List<SnapshotRule>()
            };
            this.userAgentString = userAgentString;
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
                await TrackException(e);
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
                await AddRemovedSnapRules();
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
                await TrackException(hre);
            }
            catch (WebException we)
            {
                snapEntity.HttpStatusCode = ((int)((HttpWebResponse)we.Response).StatusCode).ToString();
                await dbContext.SaveChangesAsync();
                await TrackException(we);
            }
        }

        private async Task GetLines()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgentString);
                var response = await httpClient.GetAsync(list.ViewUrl, HttpCompletionOption.ResponseHeadersRead);
                snapEntity.HttpStatusCode = ((int)response.StatusCode).ToString();
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
            var snapshotBatches = CreateBatches();
            await SaveBatches(snapshotBatches);
        }

        private IEnumerable<SnapshotBatch> CreateBatches() =>
            lines.Batch(BatchSize).Select(b => new SnapshotBatch(dbContext, b, snapEntity));

        private static async Task SaveBatches(IEnumerable<SnapshotBatch> batches)
        {
            foreach (var batch in batches)
                await batch.SaveAsync();
        }

        private async Task AddRemovedSnapRules()
        {
            dbContext.SnapshotRules
                     .Where(sr =>
                         sr.AddedBySnapshot.FilterListId == list.Id &&
                         sr.RemovedBySnapshot == null &&
                         !lines.Contains(sr.Rule.Raw))
                     .ForEach(sr => sr.RemovedBySnapshot = snapEntity);
            await dbContext.SaveChangesAsync();
        }

        private async Task SetSuccessful()
        {
            snapEntity.WasSuccessful = true;
            await dbContext.SaveChangesAsync();
        }

        private async Task TrackException(Exception e)
        {
            await SendExceptionEmail(e);
            TrackExceptionInApplicationInsights(e);
        }

        private async Task SendExceptionEmail(Exception e)
        {
            if (!IsDeploymentInterrupted(e))
            {
                var msg = new StringBuilder();
                msg.AppendLine("FilterListId: " + list.Id);
                msg.AppendLine("Exception:");
                msg.AppendLine(e.Message);
                msg.AppendLine(e.StackTrace);
                msg.AppendLine(e.InnerException?.Message);
                msg.AppendLine(e.InnerException?.StackTrace);
                await emailService.SendEmailAsync("Snapshot Exception", msg.ToString());
            }
        }

        private static bool IsDeploymentInterrupted(Exception e) =>
            e.Message.Contains("Failed to read the result set.");

        private void TrackExceptionInApplicationInsights(Exception e)
        {
            telemetryClient.TrackException(e);
            telemetryClient.Flush();
            Thread.Sleep(5000);
        }
    }
}