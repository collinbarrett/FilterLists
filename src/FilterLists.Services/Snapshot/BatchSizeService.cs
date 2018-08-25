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
        private const int DefaultBatchSize = 500;
        private const float PercentMultiplier = 0.05F;

        public BatchSizeService(FilterListsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<uint> GetBatchSize()
        {
            var recentSnapPerfs = await GetRecentSnapPerfs();
            return recentSnapPerfs.Count == 2
                ? (recentSnapPerfs[0].RulesPerMs >= recentSnapPerfs[1].RulesPerMs
                    ? (uint)Math.Round(recentSnapPerfs[0].BatchSize * (1 + PercentMultiplier))
                    : (uint)Math.Round(recentSnapPerfs[0].BatchSize * (1 - PercentMultiplier)))
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
            public uint BatchSize { get; set; }
            public int RulesCount { private get; set; }
            public DateTime CreatedDateUtc { private get; set; }
            public DateTime ModifiedDateUtc { private get; set; }
            public int RulesPerMs => (ModifiedDateUtc - CreatedDateUtc).Milliseconds / RulesCount;
        }
    }
}