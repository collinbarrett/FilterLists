using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Snapshot.Models;
using MoreLinq;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 50;
        private readonly FilterListsDbContext dbContext;
        private readonly FilterListViewUrlDto list;
        private readonly Data.Entities.Snapshot snapEntity;

        public Snapshot(FilterListsDbContext dbContext, FilterListViewUrlDto list)
        {
            this.dbContext = dbContext;
            this.list = list;
            snapEntity = new Data.Entities.Snapshot
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
            catch (Exception)
            {
                //TODO: log
            }
        }

        private async Task Add()
        {
            dbContext.Snapshots.Add(snapEntity);
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
                snapEntity.HttpStatusCode = ((int)((HttpWebResponse)we.Response).StatusCode).ToString();
                return null;
            }
        }

        private async Task<string> GetContent()
        {
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync(list.ViewUrl))
                {
                    snapEntity.HttpStatusCode = ((int)httpResponseMessage.StatusCode).ToString();
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }

            return null;
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

        private IEnumerable<SnapshotBatch> CreateBatches(IEnumerable<string> rawRules) =>
            rawRules.Batch(BatchSize).Select(b => new SnapshotBatch(dbContext, b, snapEntity));

        private static async Task SaveBatches(IEnumerable<SnapshotBatch> snapshotBatches)
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
                sr.AddedBySnapshot != snapEntity &&
                sr.RemovedBySnapshot == null);

        private void UpdateRemovedSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var newSnapshotRules = dbContext.SnapshotRules.Where(sr => sr.AddedBySnapshot == snapEntity);
            var removedSnapshotRules = existingSnapshotRules.Where(sr => !newSnapshotRules.Any(n => n.Rule == sr.Rule));
            removedSnapshotRules.ForEach(sr => sr.RemovedBySnapshot = snapEntity);
        }

        private void RemoveDuplicateSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var duplicateSnapshotRules = dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot == snapEntity &&
                existingSnapshotRules.Any(e => e.Rule == sr.Rule));
            dbContext.SnapshotRules.RemoveRange(duplicateSnapshotRules);
        }

        private async Task SetSuccessful()
        {
            snapEntity.WasSuccessful = true;
            await dbContext.SaveChangesAsync();
        }
    }
}