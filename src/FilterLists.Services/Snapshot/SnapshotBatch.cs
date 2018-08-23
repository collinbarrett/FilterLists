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

        public SnapshotBatch(FilterListsDbContext dbContext, IEnumerable<string> lines,
            Data.Entities.Snapshot snapEntity)
        {
            this.dbContext = dbContext;
            this.lines = lines;
            this.snapEntity = snapEntity;
        }

        private IQueryable<Rule> ExistingRules =>
            dbContext.Rules.Join(lines, rule => rule.Raw, line => line, (rule, line) => rule);

        public async Task SaveAsync()
        {
            AddAddedSnapRulesForExistingRules();
            AddAddedSnapRulesForNewRules();
            await dbContext.SaveChangesAsync();
        }

        private void AddAddedSnapRulesForExistingRules()
        {
            var existingAddedSnapRules = GetExistingAddedSnapRules();
            var newAddedSnapRules = CreateNewAddedSnapRules(existingAddedSnapRules);
            snapEntity.AddedSnapshotRules.AddRange(newAddedSnapRules);
        }

        private IQueryable<SnapshotRule> GetExistingAddedSnapRules() =>
            dbContext.SnapshotRules
                     .Where(sr =>
                         ExistingRules.Contains(sr.Rule) &&
                         sr.AddedBySnapshot.FilterListId == snapEntity.FilterListId &&
                         sr.RemovedBySnapshot == null);

        private IEnumerable<SnapshotRule> CreateNewAddedSnapRules(IQueryable<SnapshotRule> existingAddedSnapRules) =>
            ExistingRules.Where(r => !existingAddedSnapRules.Select(sr => sr.Rule).Contains(r))
                         .Select(r => new SnapshotRule {Rule = r});

        private void AddAddedSnapRulesForNewRules()
        {
            var newRules = CreateNewRules();
            var newAddedSnapRules = CreateSnapRules(newRules);
            snapEntity.AddedSnapshotRules.AddRange(newAddedSnapRules);
        }

        private IEnumerable<Rule> CreateNewRules() =>
            lines.Except(ExistingRules.Select(r => r.Raw)).Select(l => new Rule {Raw = l});

        private static IEnumerable<SnapshotRule> CreateSnapRules(IEnumerable<Rule> rules) =>
            rules.Select(r => new SnapshotRule {Rule = r});
    }
}