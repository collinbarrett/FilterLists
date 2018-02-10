using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotBatchDe
    {
        private readonly FilterListsDbContext dbContext;
        private readonly IEnumerable<string> rawRules;
        private readonly Snapshot snapshot;
        private IEnumerable<Rule> newSnapshotRules;
        private IEnumerable<Rule> preExistingSnapshotRules;

        public SnapshotBatchDe(FilterListsDbContext dbContext, Snapshot snapshot, IEnumerable<string> rawRules)
        {
            this.dbContext = dbContext;
            this.snapshot = snapshot;
            this.rawRules = rawRules;
        }

        //TODO: support de-duplicated SnapshotRule
        public async Task SaveSnapshotBatchAsync()
        {
            AddNewRules();
            AddSnapshotRules();
            await dbContext.SaveChangesAsync();
        }

        private void AddNewRules()
        {
            preExistingSnapshotRules = dbContext.Rules.Where(rule => rawRules.Contains(rule.Raw));
            var newSnapshotRawRules = rawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRawRule => new Rule {Raw = newSnapshotRawRule})
                                                  .ToList();
            dbContext.Rules.AddRange(newSnapshotRules);
        }

        private void AddSnapshotRules()
        {
            if (snapshot.AddedSnapshotRules == null)
                snapshot.AddedSnapshotRules = new List<SnapshotRule>();
            snapshot.AddedSnapshotRules.AddRange(preExistingSnapshotRules
                                            .Concat(newSnapshotRules)
                                            .Select(rule => new SnapshotRule {Rule = rule, AddedBySnapshot = snapshot})
                                            .ToList());
        }
    }
}