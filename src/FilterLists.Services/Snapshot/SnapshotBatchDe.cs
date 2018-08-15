using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotBatchDe
    {
        private readonly FilterListsDbContext dbContext;
        private readonly IEnumerable<string> rawRules;
        private readonly Data.Entities.Snapshot snapshot;
        private IQueryable<Rule> rules;

        public SnapshotBatchDe(FilterListsDbContext dbContext, Data.Entities.Snapshot snapshot,
            IEnumerable<string> rawRules)
        {
            this.dbContext = dbContext;
            this.snapshot = snapshot;
            this.rawRules = rawRules;
        }

        public async Task SaveSnapshotBatchAsync()
        {
            await AddRules();
            AddSnapshotRules();
            await dbContext.SaveChangesAsync();
        }

        private async Task AddRules()
        {
            var existingRules = dbContext.Rules.Where(r => rawRules.Contains(r.Raw));
            var newRawRules = rawRules.Except(existingRules.Select(r => r.Raw));
            var newRules = newRawRules.Select(r => new Rule {Raw = r}).ToList();
            rules = existingRules.Concat(newRules);
            await dbContext.Rules.AddRangeAsync(newRules);
        }

        private void AddSnapshotRules()
        {
            if (snapshot.AddedSnapshotRules == null)
                snapshot.AddedSnapshotRules = new List<SnapshotRule>();
            snapshot.AddedSnapshotRules.AddRange(rules.Select(r => new SnapshotRule {Rule = r}));
        }
    }
}