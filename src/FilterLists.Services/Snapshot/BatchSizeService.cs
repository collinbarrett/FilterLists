using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Snapshot
{
    public class BatchSizeService : Service
    {
        private const int DefaultBatchSize = 1000;
        private const float PercentMultiplier = 0.05F;

        public BatchSizeService(FilterListsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> GetBatchSize()
        {
            return DefaultBatchSize;
            var recentSnapPerfs = await GetRecentSnapPerfs();
            return recentSnapPerfs.Count == 2
                ? recentSnapPerfs[0].RulesCount > recentSnapPerfs[0].BatchSize
                    ? (recentSnapPerfs[0].RulesPerMs >= recentSnapPerfs[1].RulesPerMs
                        ? (int)Math.Round(recentSnapPerfs[0].BatchSize * (1 + PercentMultiplier))
                        : (int)Math.Round(recentSnapPerfs[0].BatchSize * (1 - PercentMultiplier)))
                    : recentSnapPerfs[0].BatchSize
                : DefaultBatchSize;
        }

        private async Task<List<SnapshotPerformance>> GetRecentSnapPerfs() =>
            await DbContext.Snapshots
                           .Where(s => s.WasSuccessful && s.BatchSize.HasValue)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .Take(2)
                           .Select(s => new SnapshotPerformance
                           {
                               BatchSize = s.BatchSize.Value,
                               CreatedDateUtc = s.CreatedDateUtc.Value,
                               ModifiedDateUtc = s.ModifiedDateUtc.Value,
                               RulesCount = s.SnapshotRules.Count
                           })
                           .ToListAsync();

        private class SnapshotPerformance
        {
            public int BatchSize { get; set; }
            public int RulesCount { get; set; }
            public DateTime CreatedDateUtc { private get; set; }
            public DateTime ModifiedDateUtc { private get; set; }
            public int RulesPerMs => (ModifiedDateUtc - CreatedDateUtc).Milliseconds / RulesCount;
        }
    }
}