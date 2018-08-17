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

        private const int BatchSize = 100;
        private readonly FilterListsDbContext dbContext;
        private readonly EmailService emailService;
        private readonly FilterListViewUrlDto list;
        private readonly Data.Entities.Snapshot snapshot;
        private string httpStatusCodeBak;

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

        public async Task TrySaveAsync()
        {
            await Add();
            try
            {
                await SaveAsync();
            }
            catch (Exception e)
            {
                await SaveHttpStatusCodeBak();
                await SendExceptionEmail(e);
            }
        }

        private async Task Add()
        {
            await dbContext.Snapshots.AddAsync(snapshot);
            await dbContext.SaveChangesAsync();
        }

        private async Task SaveAsync()
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                var content = await TryGetContent();
                if (content != null)
                {
                    await SaveInBatches(content);
                    await DedupSnapshotRules();
                    await SetSuccessful();
                }

                transaction.Commit();
            }
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
        }

        private async Task<string> GetContent()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgentString);
                using (var httpResponseMessage = await httpClient.GetAsync(list.ViewUrl))
                {
                    snapshot.HttpStatusCode = httpStatusCodeBak = ((int)httpResponseMessage.StatusCode).ToString();
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }

            await SendWebExceptionEmail();
            return null;
        }

        private async Task SaveHttpStatusCodeBak()
        {
            if (!snapshot.WasSuccessful)
            {
                snapshot.HttpStatusCode = httpStatusCodeBak;
                await dbContext.SaveChangesAsync();
            }
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
            message.AppendLine("Exception:");
            message.AppendLine(e.Message);
            message.AppendLine(e.StackTrace);
            message.AppendLine(e.InnerException?.Message);
            message.AppendLine(e.InnerException?.StackTrace);
            await emailService.SendEmailAsync("Snapshot Exception", message.ToString());
        }

        private async Task SaveInBatches(string content)
        {
            var rawRules = ParseRawRules(content);
            var snapshotBatches = CreateBatches(rawRules);
            await SaveBatches(snapshotBatches);
        }

        private static IEnumerable<string> ParseRawRules(string content)
        {
            var rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < rawRules.Length; i++)
                rawRules[i] = rawRules[i].LintRawRule();
            return rawRules.Where(r => r != null);
        }

        private IEnumerable<SnapshotDeBatch> CreateBatches(IEnumerable<string> rawRules) =>
            rawRules.Batch(BatchSize).Select(b => new SnapshotDeBatch(dbContext, snapshot, b));

        private static async Task SaveBatches(IEnumerable<SnapshotDeBatch> snapshotBatches)
        {
            foreach (var batch in snapshotBatches)
                await batch.SaveAsync();
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
            removedSnapshotRules.ForEach(sr => sr.RemovedBySnapshot = snapshot);
        }

        private void RemoveDuplicateSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var duplicateSnapshotRules = dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot == snapshot &&
                existingSnapshotRules.Any(e => e.Rule == sr.Rule));
            dbContext.SnapshotRules.RemoveRange(duplicateSnapshotRules);
        }

        private async Task SetSuccessful()
        {
            snapshot.WasSuccessful = true;
            await dbContext.SaveChangesAsync();
        }
    }
}