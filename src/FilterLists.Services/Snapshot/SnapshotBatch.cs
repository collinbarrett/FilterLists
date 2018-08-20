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

        public async Task SaveAsync()
        {
            var existingRules = GetExistingRules();
            var newRules = CreateNewRules(existingRules);
            dbContext.Rules.AddRange(newRules);
            var rules = existingRules.Concat(newRules);
            AddSnapshotRules(rules);
            await dbContext.SaveChangesAsync();
        }

        private IQueryable<Rule> GetExistingRules() =>
            dbContext.Rules.Where(r => lines.Contains(r.Raw));

        private List<Rule> CreateNewRules(IQueryable<Rule> existingRules) =>
            lines.Except(existingRules.Select(r => r.Raw)).Select(r => new Rule {Raw = r}).ToList();

        private void AddSnapshotRules(IQueryable<Rule> rules) =>
            snapEntity.AddedSnapshotRules.AddRange(rules.Select(r => new SnapshotRule {Rule = r}));
    }
}