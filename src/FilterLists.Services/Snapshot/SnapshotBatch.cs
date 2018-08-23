using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotBatch
    {
        private readonly FilterListsDbContext dbContext;
        private readonly IEnumerable<string> lines;
        private readonly Data.Entities.Snapshot snapEntity;
        private IQueryable<Rule> existingRules;

        public SnapshotBatch(FilterListsDbContext dbContext, IEnumerable<string> lines,
            Data.Entities.Snapshot snapEntity)
        {
            this.dbContext = dbContext;
            this.lines = lines;
            this.snapEntity = snapEntity;
        }

        public async Task SaveAsync()
        {
            GetExistingRules();
            AddAddedSnapshotRulesForExistingRules();
            AddAddedSnapshotRulesForNewRules();
            await dbContext.SaveChangesAsync();
        }

        private void GetExistingRules() =>
            existingRules = dbContext.Rules.Join(lines, rule => rule.Raw, line => line, (rule, line) => rule);

        private void AddAddedSnapshotRulesForExistingRules()
        {
            var existingSnapshotRules = dbContext.SnapshotRules
                                                 .Where(sr =>
                                                     existingRules.Contains(sr.Rule) &&
                                                     sr.AddedBySnapshot.FilterListId == snapEntity.FilterListId &&
                                                     sr.RemovedBySnapshot == null);
            var newSnapshotRules = existingRules.Where(r => !existingSnapshotRules.Select(sr => sr.Rule).Contains(r))
                                                .Select(r => new SnapshotRule {Rule = r});
            snapEntity.AddedSnapshotRules.AddRange(newSnapshotRules);
        }

        private void AddAddedSnapshotRulesForNewRules()
        {
            var rules = lines.Except(existingRules.Select(r => r.Raw)).Select(l => new Rule {Raw = l});
            var snapshotRules = rules.Select(r => new SnapshotRule {Rule = r});
            snapEntity.AddedSnapshotRules.AddRange(snapshotRules);
        }
    }
}