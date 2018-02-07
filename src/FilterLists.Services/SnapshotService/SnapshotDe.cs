using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotDe
    {
        private const int BatchSize = 1000;
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
                await SaveSnapshotInBatches(content);
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
            catch (HttpRequestException)
            {
                snapshot.HttpStatusCode = null;
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
                rawRules[i] = rawRules[i].LintStringForMySql();
            return new HashSet<string>(rawRules.Where(x => x != null));
        }

        private IEnumerable<SnapshotBatchDe> GetSnapshotBatches(IEnumerable<string> rawRules)
        {
            return rawRules.Batch(BatchSize)
                           .Select(rawRuleBatch => new SnapshotBatchDe(dbContext, snapshot, rawRuleBatch));
        }

        private static async Task SaveSnapshotBatches(IEnumerable<SnapshotBatchDe> snapshotBatches)
        {
            foreach (var snapshotBatch in snapshotBatches)
                await snapshotBatch.SaveSnapshotBatchAsync();
        }
    }
}