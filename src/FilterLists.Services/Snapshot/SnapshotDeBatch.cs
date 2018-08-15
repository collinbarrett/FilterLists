using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Services.Extensions;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotDeBatch
    {
        private readonly FilterListsDbContext dbContext;
        private readonly IEnumerable<string> rawRules;
        private readonly Data.Entities.Snapshot snapshot;
        private IQueryable<Rule> rules;

        public SnapshotDeBatch(FilterListsDbContext dbContext, Data.Entities.Snapshot snapshot,
            IEnumerable<string> rawRules)
        {
            this.dbContext = dbContext;
            this.snapshot = snapshot;
            this.rawRules = rawRules;
        }

        public async Task SaveAsync()
        {
            await AddRules();
            AddSnapshotRules();
            await dbContext.SaveChangesAsync();
        }

        private async Task AddRules()
        {
            var existingRules = GetExistingRules();
            var newRules = CreateNewRules(existingRules);
            rules = existingRules.Concat(newRules);
            await dbContext.Rules.AddRangeAsync(newRules);
        }

        private IQueryable<Rule> GetExistingRules() => dbContext.Rules.Where(r => rawRules.Contains(r.Raw));

        private List<Rule> CreateNewRules(IQueryable<Rule> existingRules) =>
            rawRules.Except(existingRules.Select(r => r.Raw)).Select(r => new Rule {Raw = r}).ToList();

        private void AddSnapshotRules() =>
            snapshot.AddedSnapshotRules.AddRange(rules.Select(r => new SnapshotRule {Rule = r}));
    }
}