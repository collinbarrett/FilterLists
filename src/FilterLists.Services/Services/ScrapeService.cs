using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Data.Entities;
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
            var lists = await GetNextFilterListDtosToScrape(batchSize);
            var snapshots = await GetSnapshots(lists);
            await AddOrUpdateRules(snapshots);
        }

        private async Task<IEnumerable<FilterListDto>> GetNextFilterListDtosToScrape(int batchSize)
        {
            return await filterListsDbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(batchSize)
                .ProjectTo<FilterListDto>().ToListAsync();
        }

        private static async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListDto> lists)
        {
            return await Task.WhenAll(lists.Select(async list =>
                new Snapshot {Content = await GetContent(list.ViewUrl), FilterListId = list.Id}));
        }

        private static async Task<string> GetContent(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                using (var httpResponseMessage = await httpClient.GetAsync(url))
                {
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (Exception)
            {
                //TODO: log exception
                return null;
            }

            //TODO: log httpResponseMessage.StatusCode
            return null;
        }

        private async Task AddOrUpdateRules(IEnumerable<Snapshot> snapshots)
        {
            await Task.WhenAll(snapshots.Select(async snapshot => await AddOrUpdateRules(snapshot)));
        }

        //TODO: finish and validate
        private async Task AddOrUpdateRules(Snapshot snapshot)
        {
            // add new Rules
            var snapshotRulesRaw =
                snapshot.Content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            var preExistingSnapshotRules = filterListsDbContext.Rules.Where(x => snapshotRulesRaw.Contains(x.Raw));
            var newSnapshotRulesRaw = snapshotRulesRaw.Except(preExistingSnapshotRules.Select(x => x.Raw));
            var newSnapshotRules =
                newSnapshotRulesRaw.Select(newSnapshotRuleRaw => new Rule {Raw = newSnapshotRuleRaw});
            filterListsDbContext.Rules.AddRange(newSnapshotRules);

            // remove deleted FilterListRules
            var preExistingFilterListRules =
                filterListsDbContext.FilterListRules.Where(x => x.FilterListId == snapshot.FilterListId);
            var deletedFilterListRules =
                preExistingFilterListRules.Where(x => !preExistingSnapshotRules.Select(y => y.Id).Contains(x.RuleId));
            filterListsDbContext.FilterListRules.RemoveRange(deletedFilterListRules);

            // add new FilterListRules


            // update UpdatedDateUtc
            if (newSnapshotRulesRaw.Any() || deletedFilterListRules.Any())
            {
                var list = filterListsDbContext.FilterLists.FindAsync(snapshot.FilterListId).Result;
                list.UpdatedDateUtc = DateTime.UtcNow;
                filterListsDbContext.FilterLists.Update(list);
            }

            //TODO: update FilterList.ScrapedDateUtc

            await filterListsDbContext.SaveChangesAsync();
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
    }
}