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
        private readonly IEnumerable<string> rawRules;
        private readonly Data.Entities.Snapshot snapEntity;
        private IQueryable<Rule> rules;

        public SnapshotBatch(FilterListsDbContext dbContext, IEnumerable<string> rawRules,
            Data.Entities.Snapshot snapEntity)
        {
            this.dbContext = dbContext;
            this.snapEntity = snapEntity;
            this.rawRules = rawRules;
        }

        public async Task SaveAsync()
        {
            AddRules();
            AddSnapshotRules();
            await dbContext.SaveChangesAsync();
        }

        private void AddRules()
        {
            var existingRules = GetExistingRules();
            var newRules = CreateNewRules(existingRules);
            rules = existingRules.Concat(newRules);
            dbContext.Rules.AddRange(newRules);
        }

        private IQueryable<Rule> GetExistingRules() => dbContext.Rules.Where(r => rawRules.Contains(r.Raw));

        private List<Rule> CreateNewRules(IQueryable<Rule> existingRules) =>
            rawRules.Except(existingRules.Select(r => r.Raw)).Select(r => new Rule {Raw = r}).ToList();

        private void AddSnapshotRules() =>
            snapEntity.AddedSnapshotRules.AddRange(rules.Select(r => new SnapshotRule {Rule = r}));
    }
}