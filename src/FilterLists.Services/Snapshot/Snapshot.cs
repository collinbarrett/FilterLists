using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;
using FilterLists.Services.Snapshot.Models;
using MoreLinq;

namespace FilterLists.Services.Snapshot
{
    public class Snapshot
    {
        private const int BatchSize = 1000;
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

        //TODO: add better compliance with Try/Parse pattern (https://stackoverflow.com/q/37810660/2343739)
        public async Task TrySaveAsync()
        {
            await AddSnapEntity();
            try
            {
                await SaveAsync();
            }
            catch (Exception)
            {
                //allow other snapshots to continue
                //TODO: log
            }
        }

        private async Task AddSnapEntity()
        {
            dbContext.Snapshots.Add(snapEntity);
            await dbContext.SaveChangesAsync();
        }

        private async Task SaveAsync()
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                var lines = await TryGetLines();
                if (lines != null)
                {
                    SaveInBatches(lines);
                    await DedupSnapshotRules();
                    await SetSuccessful();
                }

                transaction.Commit();
            }
        }

        private async Task<IEnumerable<string>> TryGetLines()
        {
            try
            {
                return await GetLines();
            }
            catch (HttpRequestException)
            {
                return null;
            }
            catch (WebException we)
            {
                snapEntity.HttpStatusCode = ((int)((HttpWebResponse)we.Response).StatusCode).ToString();
                return null;
            }
        }

        private async Task<IEnumerable<string>> GetLines()
        {
            var lines = new HashSet<string>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(list.ViewUrl, HttpCompletionOption.ResponseHeadersRead);
                snapEntity.HttpStatusCode = ((int)response.StatusCode).ToString();
                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var streamReader = new StreamReader(stream))
                {
                    string line;
                    while ((line = await streamReader.ReadLineAsync()) != null)
                        lines.AddIfNotNullOrEmpty(line.LintLine());
                }
            }

            return lines;
        }

        private void SaveInBatches(IEnumerable<string> lines)
        {
            var snapshotBatches = CreateBatches(lines);
            SaveBatches(snapshotBatches);
        }

        private IEnumerable<SnapshotBatch> CreateBatches(IEnumerable<string> lines) =>
            lines.Batch(BatchSize).Select(b => new SnapshotBatch(dbContext, b, snapEntity));

        private static void SaveBatches(IEnumerable<SnapshotBatch> batches)
        {
            foreach (var batch in batches)
                batch.Save();
        }

        private async Task DedupSnapshotRules()
        {
            var existingSnapshotRules = GetExistingSnapshotRules();
            AddRemovedBySnapshots(existingSnapshotRules);
            RemoveDuplicateSnapshotRules(existingSnapshotRules);
            await dbContext.SaveChangesAsync();
        }

        private IQueryable<SnapshotRule> GetExistingSnapshotRules() =>
            dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot.FilterListId == list.Id &&
                sr.AddedBySnapshot != snapEntity &&
                sr.RemovedBySnapshot == null);

        private void AddRemovedBySnapshots(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var newSnapshotRules = dbContext.SnapshotRules.Where(sr => sr.AddedBySnapshot == snapEntity);
            var removedSnapshotRules = existingSnapshotRules.Where(sr => !newSnapshotRules.Any(n => n.Rule == sr.Rule));
            removedSnapshotRules.ForEach(sr => sr.RemovedBySnapshot = snapEntity);
        }

        private void RemoveDuplicateSnapshotRules(IQueryable<SnapshotRule> existingSnapshotRules)
        {
            var duplicateSnapshotRules = dbContext.SnapshotRules.Where(sr =>
                sr.AddedBySnapshot == snapEntity &&
                existingSnapshotRules.Any(e =>
                    e.Rule == sr.Rule && e.RemovedBySnapshot == null));
            dbContext.SnapshotRules.RemoveRange(duplicateSnapshotRules);
        }

        private async Task SetSuccessful()
        {
            snapEntity.WasSuccessful = true;
            await dbContext.SaveChangesAsync();
        }
    }
}