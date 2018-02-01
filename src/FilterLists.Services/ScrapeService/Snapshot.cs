using System;
using System.Linq;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Services.ScrapeService
{
    public class Snapshot
    {
        private readonly FilterListsDbContext dbContext;

        private readonly int filterListId;

        private string[] rawRules;

        public Snapshot(FilterListsDbContext dbContext, int filterListId, string content)
        {
            this.dbContext = dbContext;
            this.filterListId = filterListId;
            ParseContent(content);
        }

        public bool HasRules => rawRules != null;

        private void ParseContent(string content)
        {
            if (content == null) return;
            rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < rawRules.Length; i++)
                rawRules[i] = rawRules[i].LintStringForMySql();
        }

        public async Task AddOrUpdateRules()
        {
            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            // add new Rules
            var preExistingSnapshotRules = dbContext.Rules.Where(x => rawRules.Contains(x.Raw));
            var newSnapshotRawRules = rawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            var newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRawRule => new Rule {Raw = newSnapshotRawRule}).ToList();

            // remove deleted FilterListRules
            var preExistingFilterListRules = dbContext.FilterListRules.Where(x => x.FilterListId == filterListId);
            var deletedFilterListRules = preExistingFilterListRules.Where(x => !preExistingSnapshotRules.Select(y => y.Id).Contains(x.RuleId));

            // add FilterListRules for pre-existing Rules
            var preExistingSnapshotFilterListRules = preExistingSnapshotRules.Select(newSnapshotRule =>
                    new FilterListRule {FilterListId = filterListId, Rule = newSnapshotRule}).ToList()
                .Except(preExistingFilterListRules).ToList();

            // add new FilterListRules
            var newFilterListRules = newSnapshotRules.Select(newSnapshotRule =>
                new FilterListRule {FilterListId = filterListId, Rule = newSnapshotRule}).ToList();

            // update UpdatedDateUtc
            var list = dbContext.FilterLists.Find(filterListId);
            if (preExistingSnapshotFilterListRules.Any() || newFilterListRules.Any() || deletedFilterListRules.Any())
                list.UpdatedDateUtc = DateTime.UtcNow;

            // update ScrapedDateUtc
            list.ScrapedDateUtc = DateTime.UtcNow;

            dbContext.Rules.AddRange(newSnapshotRules);
            dbContext.FilterListRules.RemoveRange(deletedFilterListRules);
            dbContext.FilterListRules.AddRange(preExistingSnapshotFilterListRules);
            dbContext.FilterListRules.AddRange(newFilterListRules);
            dbContext.FilterLists.Update(list);

            await dbContext.SaveChangesAsync();
        }
    }
}