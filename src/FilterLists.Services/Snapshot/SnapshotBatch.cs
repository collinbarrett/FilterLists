using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;

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

        public async Task SaveAsync()
        {
            var rules = GetOrCreateRules();
            CreateSnapRules(rules);
            await dbContext.SaveChangesAsync();
        }

        private IQueryable<Rule> GetOrCreateRules()
        {
            var existingRules = dbContext.Rules.Join(lines, rule => rule.Raw, line => line, (rule, line) => rule);
            var newRules = lines.Except(existingRules.Select(r => r.Raw)).Select(l => new Rule {Raw = l}).ToList();
            dbContext.Rules.AddRange(newRules);
            return existingRules.Concat(newRules);
        }

        private void CreateSnapRules(IQueryable<Rule> rules)
        {
            var snapRules = rules.Select(r => new SnapshotRule {Rule = r}).ToList();
            snapEntity.SnapshotRules = snapRules;
        }
    }
}