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

        public SnapshotBatchDe(FilterListsDbContext dbContext, Data.Entities.Snapshot snapshot, IEnumerable<string> rawRules)
        {
            this.dbContext = dbContext;
            this.snapshot = snapshot;
            this.rawRules = rawRules;
        }

        public async Task SaveSnapshotBatchAsync()
        {
            AddRules();
            AddSnapshotRules();
            await dbContext.SaveChangesAsync();
        }

        private void AddRules()
        {
            var existingRules = dbContext.Rules.Where(rule => rawRules.Contains(rule.Raw));
            var newRawRules = rawRules.Except(existingRules.Select(r => r.Raw));
            var newRules = newRawRules.Select(newRawRule => new Rule {Raw = newRawRule}).ToList();
            dbContext.Rules.AddRange(newRules);
            rules = existingRules.Concat(newRules);
        }

        private void AddSnapshotRules()
        {
            var snapshotRules = new List<SnapshotRule>();
            foreach (var rule in rules)
                snapshotRules.Add(new SnapshotRule {Rule = rule});
            if (snapshot.AddedSnapshotRules == null)
                snapshot.AddedSnapshotRules = new List<SnapshotRule>();
            snapshot.AddedSnapshotRules.AddRange(snapshotRules);
        }
    }
}