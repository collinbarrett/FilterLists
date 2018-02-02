using System;
using System.Collections.Generic;
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

        private List<string> rawRules;

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
            rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (var i = 0; i < rawRules.Count; i++)
                rawRules[i] = rawRules[i].LintStringForMySql();
            rawRules = rawRules.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        }

        //TODO: split large lists into batches
        public async Task AddOrUpdateRules()
        {
            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            // add new Rules
            var preExistingSnapshotRules = dbContext.Rules.Where(x => rawRules.Contains(x.Raw));
            var newSnapshotRawRules = rawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            var newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRawRule => new Rule {Raw = newSnapshotRawRule}).ToList();
            await dbContext.Rules.AddRangeAsync(newSnapshotRules);

            // remove deleted FilterListRules
            var preExistingFilterListRules = dbContext.FilterListRules.Where(x => x.FilterListId == filterListId);
            var deletedFilterListRules = preExistingFilterListRules.Where(x => !preExistingSnapshotRules.Select(y => y.Id).Contains(x.RuleId));
            dbContext.FilterListRules.RemoveRange(deletedFilterListRules);

            // add FilterListRules for pre-existing Rules
            var preExistingSnapshotFilterListRules = preExistingSnapshotRules.Select(newSnapshotRule =>
                    new FilterListRule {FilterListId = filterListId, Rule = newSnapshotRule}).ToList()
                .Except(preExistingFilterListRules).ToList();
            await dbContext.FilterListRules.AddRangeAsync(preExistingSnapshotFilterListRules);

            // add new FilterListRules
            var newFilterListRules = newSnapshotRules.Select(newSnapshotRule =>
                new FilterListRule {FilterListId = filterListId, Rule = newSnapshotRule}).ToList();
            await dbContext.FilterListRules.AddRangeAsync(newFilterListRules);

            // update scrapes

            await dbContext.SaveChangesAsync();
        }
    }
}