using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotDe
    {
        private const string UserAgentString =
            @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36";

        private const int BatchSize = 1000;
        private readonly FilterListsDbContext dbContext;
        private readonly FilterListViewUrlDto list;
        private Data.Entities.Snapshot snapshot;

        public SnapshotDe(FilterListsDbContext dbContext, FilterListViewUrlDto list)
        {
            this.dbContext = dbContext;
            this.list = list;
        }

        public async Task SaveSnapshotAsync()
        {
            var content = await CaptureSnapshot();
            if (content != null)
            {
                await SaveSnapshotInBatches(content);
                await DedupSnapshotRules();
            }

            await SetCompleted();
        }

        private async Task<string> CaptureSnapshot()
        {
            await AddSnapshot();
            var content = await TryGetContent();
            await dbContext.SaveChangesAsync();
            return content;
        }

        private async Task AddSnapshot()
        {
            snapshot = new Data.Entities.Snapshot {FilterListId = list.Id};
            await dbContext.Snapshots.AddAsync(snapshot);
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
                return null;
            }
            catch (Exception)
            {
                //TODO: log exception (#148)
                snapshot.HttpStatusCode = null;
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

            return null;
        }

        private async Task SaveSnapshotInBatches(string content)
        {
            var rawRules = GetRawRules(content);
            var snapshotBatches = GetSnapshotBatches(rawRules);
            await SaveSnapshotBatches(snapshotBatches);
        }

        private static IEnumerable<string> GetRawRules(string content)
        {
            var rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < rawRules.Length; i++)
                rawRules[i] = rawRules[i].LintRawRule();
            return new HashSet<string>(rawRules.Where(rr => rr != null));
        }

        private IEnumerable<SnapshotBatchDe> GetSnapshotBatches(IEnumerable<string> rawRules) =>
            rawRules.GetBatches(BatchSize)
                    .Select(rawRuleBatch => new SnapshotBatchDe(dbContext, snapshot, rawRuleBatch));

        private static async Task SaveSnapshotBatches(IEnumerable<SnapshotBatchDe> snapshotBatches)
        {
            foreach (var snapshotBatch in snapshotBatches)
                await snapshotBatch.SaveSnapshotBatchAsync();
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
                sr.AddedBySnapshot.FilterListId == list.Id && sr.AddedBySnapshot != snapshot &&
                sr.RemovedBySnapshot == null);

        private void UpdateRemovedSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var newSnapshotRules = dbContext.SnapshotRules.Where(sr => sr.AddedBySnapshot == snapshot);
            var removedSnapshotRules =
                existingSnapshotRules.Where(sr => !newSnapshotRules.Any(nsr => nsr.Rule == sr.Rule));
            removedSnapshotRules.ToList().ForEach(sr => sr.RemovedBySnapshot = snapshot);
        }

        private void RemoveDuplicateSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var duplicateSnapshotRules = dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot == snapshot &&
                existingSnapshotRules.Any(esr => esr.Rule == sr.Rule));
            dbContext.SnapshotRules.RemoveRange(duplicateSnapshotRules);
        }

        private async Task SetCompleted()
        {
            snapshot.IsCompleted = true;
            await dbContext.SaveChangesAsync();
        }
    }
}