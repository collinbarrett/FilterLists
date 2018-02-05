using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotDe
    {
        private const int BatchSize = 100;
        private readonly FilterListsDbContext dbContext;
        private readonly FilterListViewUrlDto list;
        private Snapshot snapshot;

        public SnapshotDe(FilterListsDbContext dbContext, FilterListViewUrlDto list)
        {
            this.dbContext = dbContext;
            this.list = list;
        }

        public async Task SaveSnapshotAsync()
        {
            await AddSnapshot();
            var content = await TryGetContent();
            await dbContext.SaveChangesAsync();
            if (content != null)
                SaveSnapshotInBatches(content);
        }

        private async Task AddSnapshot()
        {
            snapshot = new Snapshot {FilterListId = list.Id};
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
                snapshot.HttpStatusCode = (int)((HttpWebResponse)we.Response).StatusCode;
                return null;
            }
        }

        private async Task<string> GetContent()
        {
            using (var httpClient = new HttpClient())
            using (var httpResponseMessage = await httpClient.GetAsync(list.ViewUrl))
            {
                snapshot.HttpStatusCode = (int)httpResponseMessage.StatusCode;
                if (httpResponseMessage.IsSuccessStatusCode)
                    return await httpResponseMessage.Content.ReadAsStringAsync();
            }

            return null;
        }

        private void SaveSnapshotInBatches(string content)
        {
            var rawRules = GetRawRules(content);
            var snapshotBatches = GetSnapshotBatches(rawRules);
            SaveSnapshotBatches(snapshotBatches);
        }

        private static List<string> GetRawRules(string content)
        {
            var rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (var i = 0; i < rawRules.Count; i++)
                rawRules[i] = rawRules[i].LintStringForMySql();
            return rawRules.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        }

        private IEnumerable<SnapshotBatchDe> GetSnapshotBatches(List<string> rawRules)
        {
            var rawRuleBatches = GetRawRuleBatches(rawRules);
            return rawRuleBatches.Select(rawRuleBatch => new SnapshotBatchDe(dbContext, snapshot, rawRuleBatch));
        }

        public static IEnumerable<IEnumerable<string>> GetRawRuleBatches(List<string> rawRules)
        {
            for (var i = 0; i < rawRules.Count; i += BatchSize)
                yield return rawRules.GetRange(i, Math.Min(BatchSize, rawRules.Count - i));
        }

        private static void SaveSnapshotBatches(IEnumerable<SnapshotBatchDe> snapshotBatches)
        {
            foreach (var snapshotBatch in snapshotBatches)
                snapshotBatch.SaveSnapshotBatch();
        }
    }
}