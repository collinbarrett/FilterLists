using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Snapshot.Models;
using MoreLinq;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotDe
    {
        private const string UserAgentString =
            @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36";

        private const int BatchSize = 1000;
        private readonly FilterListsDbContext dbContext;
        private readonly EmailService emailService;
        private readonly FilterListViewUrlDto list;
        private readonly Data.Entities.Snapshot snapshot;

        public SnapshotDe(FilterListsDbContext dbContext, EmailService emailService, FilterListViewUrlDto list)
        {
            this.dbContext = dbContext;
            this.emailService = emailService;
            this.list = list;
            snapshot = new Data.Entities.Snapshot
            {
                FilterListId = list.Id,
                AddedSnapshotRules = new List<SnapshotRule>()
            };
        }

        public async Task SaveAsync()
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var content = await CaptureSnapshot();
                    if (content != null)
                    {
                        await SaveSnapshotInBatches(content);
                        await DedupSnapshotRules();
                    }

                    //TODO: remove after closed: https://github.com/collinbarrett/FilterLists/issues/344
                    await SetCompleted();

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    await SendExceptionEmail(e);
                }
            }
        }

        private async Task<string> CaptureSnapshot()
        {
            var content = await TryGetContent();
            await dbContext.Snapshots.AddAsync(snapshot);
            await dbContext.SaveChangesAsync();
            return content;
        }

        private async Task<string> TryGetContent()
        {
            try
            {
                return await GetContent();
            }
            catch (WebException we)
            {
                snapshot.HttpStatusCode = ((int)((HttpWebResponse)we.Response).StatusCode).ToString();
                await SendWebExceptionEmail();
                return null;
            }
            catch (Exception e)
            {
                snapshot.HttpStatusCode = null;
                await SendExceptionEmail(e);
                return null;
            }
        }

        private async Task<string> GetContent()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgentString);
                using (var httpResponseMessage = await httpClient.GetAsync(list.ViewUrl))
                {
                    snapshot.HttpStatusCode = ((int)httpResponseMessage.StatusCode).ToString();
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }

            await SendWebExceptionEmail();
            return null;
        }

        private async Task SendWebExceptionEmail()
        {
            var message = new StringBuilder();
            message.AppendLine("Snapshot WebException");
            message.AppendLine("FilterListId: " + snapshot.FilterListId);
            message.AppendLine("HTTP Status Code: " + snapshot.HttpStatusCode);
            await emailService.SendEmailAsync("Snapshot WebException", message.ToString());
        }

        private async Task SendExceptionEmail(Exception e)
        {
            var message = new StringBuilder();
            message.AppendLine("Snapshot Exception");
            message.AppendLine("FilterListId: " + snapshot.FilterListId);
            message.AppendLine("Exception: " + e.Message);
            await emailService.SendEmailAsync("Snapshot Exception", message.ToString());
        }

        private async Task SaveSnapshotInBatches(string content)
        {
            var rawRules = ParseRawRules(content);
            var snapshotBatches = CreateSnapshotBatches(rawRules);
            await SaveSnapshotBatches(snapshotBatches);
        }

        private static IEnumerable<string> ParseRawRules(string content)
        {
            var rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < rawRules.Length; i++)
                rawRules[i] = rawRules[i].LintRawRule();
            return rawRules.Where(r => r != null);
        }

        private IEnumerable<SnapshotDeBatch> CreateSnapshotBatches(IEnumerable<string> rawRules) =>
            rawRules.Batch(BatchSize).Select(b => new SnapshotDeBatch(dbContext, snapshot, b));

        private static async Task SaveSnapshotBatches(IEnumerable<SnapshotDeBatch> snapshotBatches)
        {
            foreach (var snapshotBatch in snapshotBatches)
                await snapshotBatch.SaveAsync();
        }

        private async Task DedupSnapshotRules()
        {
            var existingSnapshotRules = GetExistingSnapshotRules();
            UpdateRemovedSnapshotRules(existingSnapshotRules);
            RemoveDuplicateSnapshotRules(existingSnapshotRules);
            await dbContext.SaveChangesAsync();
        }

        private IQueryable<SnapshotRule> GetExistingSnapshotRules() =>
            dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot.FilterListId == list.Id &&
                sr.AddedBySnapshot != snapshot &&
                sr.RemovedBySnapshot == null);

        private void UpdateRemovedSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var newSnapshotRules = dbContext.SnapshotRules.Where(sr => sr.AddedBySnapshot == snapshot);
            var removedSnapshotRules = existingSnapshotRules.Where(sr => !newSnapshotRules.Any(n => n.Rule == sr.Rule));
            removedSnapshotRules.ToList().ForEach(sr => sr.RemovedBySnapshot = snapshot);
        }

        private void RemoveDuplicateSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var duplicateSnapshotRules = dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot == snapshot &&
                existingSnapshotRules.Any(e => e.Rule == sr.Rule));
            dbContext.SnapshotRules.RemoveRange(duplicateSnapshotRules);
        }

        private async Task SetCompleted()
        {
            snapshot.IsCompleted = true;
            await dbContext.SaveChangesAsync();
        }
    }
}