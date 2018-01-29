using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Services
{
    public class ScrapeService
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public ScrapeService(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        //TODO: call via scheduled job
        public async Task ScrapeAsync(int batchSize)
        {
            var filterListDtos = await GetNextFilterListDtosToScrape(batchSize);
            var snapshots = await GetSnapshots(filterListDtos);
            //var temp = ParseRules(snapshots);
            //AddOrUpdateRules(temp);
        }

        private async Task<IEnumerable<FilterListDto>> GetNextFilterListDtosToScrape(int batchSize)
        {
            return await filterListsDbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(batchSize)
                .ProjectTo<FilterListDto>().ToListAsync();
        }

        private static async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListDto> filterListDtos)
        {
            return await Task.WhenAll(filterListDtos.Select(async filterListDto =>
                new Snapshot {Content = await TryGetContent(filterListDto.ViewUrl), FilterListId = filterListDto.Id}));
        }

        private static async Task<string> TryGetContent(string url)
        {
            try
            {
                await GetHttpResponseMessageContent(url);
            }
            catch (Exception)
            {
                //TODO: log exception
                return null;
            }

            return null;
        }

        private static async Task<string> GetHttpResponseMessageContent(string url)
        {
            using (var httpClient = new HttpClient())
            using (var httpResponseMessage = await httpClient.GetAsync(url))
            {
                if (httpResponseMessage.IsSuccessStatusCode)
                    return await httpResponseMessage.Content.ReadAsStringAsync();
            }

            //TODO: log httpResponseMessage.StatusCode
            return null;
        }

        private void ParseRules(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots)
                ParseRules(snapshot);
        }

        private void ParseRules(Snapshot snapshot)
        {
            var snapshotRulesRaw =
                snapshot.Content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            var snapshotRulesRawDto =
                new SnapshotRulesRaw {FilterListId = snapshot.FilterListId, RulesRaw = snapshotRulesRaw};
            //return snapshotRulesRawDto;
        }

        private void AddOrUpdateRules(SnapshotRulesRaw snapshotRulesRaw)
        {
            // add new Rules
            var preExistingSnapshotRules =
                filterListsDbContext.Rules.Where(x => snapshotRulesRaw.RulesRaw.Contains(x.Raw));
            var newSnapshotRulesRaw = snapshotRulesRaw.RulesRaw.Except(preExistingSnapshotRules.Select(x => x.Raw));
            var newSnapshotRules =
                newSnapshotRulesRaw.Select(newSnapshotRuleRaw => new Rule {Raw = newSnapshotRuleRaw});
            filterListsDbContext.Rules.AddRange(newSnapshotRules);

            // remove deleted FilterListRules
            var preExistingFilterListRules =
                filterListsDbContext.FilterListRules.Where(x => x.FilterListId == snapshotRulesRaw.FilterListId);
            var deletedFilterListRules =
                preExistingFilterListRules.Where(x => !preExistingSnapshotRules.Select(y => y.Id).Contains(x.RuleId));
            filterListsDbContext.FilterListRules.RemoveRange(deletedFilterListRules);

            // add new (or previously missing junction) FilterListRules
            var preExistingSnapshotFilterListRules = preExistingSnapshotRules.Select(newSnapshotRule =>
                new FilterListRule {FilterListId = snapshotRulesRaw.FilterListId, Rule = newSnapshotRule});
            filterListsDbContext.FilterListRules.AddRange(preExistingSnapshotFilterListRules);
            var newFilterListRules = newSnapshotRules.Select(newSnapshotRule =>
                new FilterListRule {FilterListId = snapshotRulesRaw.FilterListId, Rule = newSnapshotRule});
            filterListsDbContext.FilterListRules.AddRange(newFilterListRules);

            // update UpdatedDateUtc
            var list = filterListsDbContext.FilterLists.Find(snapshotRulesRaw.FilterListId);
            //if (preExistingSnapshotFilterListRules.Any() || newFilterListRules.Any() || deletedFilterListRules.Any()))
            list.UpdatedDateUtc = DateTime.UtcNow;

            // update ScrapedDateUtc
            list.ScrapedDateUtc = DateTime.UtcNow;
            filterListsDbContext.FilterLists.Update(list);

            filterListsDbContext.SaveChanges();
        }

        private class FilterListDto
        {
            public int Id { get; set; }
            public string ViewUrl { get; set; }
        }

        private class Snapshot
        {
            public string Content { get; set; }
            public int FilterListId { get; set; }
        }

        private class SnapshotRulesRaw
        {
            public int FilterListId { get; set; }
            public IEnumerable<string> RulesRaw { get; set; }
        }
    }
}