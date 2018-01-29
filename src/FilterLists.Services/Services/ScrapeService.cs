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
            AddOrUpdateRules(snapshots);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetNextFilterListDtosToScrape(int batchSize)
        {
            return await filterListsDbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(batchSize)
                .ProjectTo<FilterListViewUrlDto>().ToListAsync();
        }

        private static async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists)
        {
            return await Task.WhenAll(lists.Select(async list =>
                new Snapshot {Content = await TryGetContent(list.ViewUrl), FilterListId = list.Id}));
        }

        private static async Task<string> TryGetContent(string url)
        {
            try
            {
                return await GetSuccessfulHttpResponseMessageContent(url);
            }
            catch (Exception)
            {
                //TODO: log exception
                return null;
            }
        }

        private static async Task<string> GetSuccessfulHttpResponseMessageContent(string url)
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

        private void AddOrUpdateRules(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots)
                AddOrUpdateRules(snapshot);
        }

        //TODO: finish and validate
        private void AddOrUpdateRules(Snapshot snapshot)
        {
            // add new Rules
            snapshot.ParseRawRules();
            var preExistingSnapshotRules = filterListsDbContext.Rules.Where(x => snapshot.RawRules.Contains(x.Raw));
            var newSnapshotRulesRaw = snapshot.RawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
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

            filterListsDbContext.SaveChangesAsync();
        }

        private class FilterListViewUrlDto
        {
            public int Id { get; set; }
            public string ViewUrl { get; set; }
        }

        private class Snapshot
        {
            public string Content { private get; set; }
            public int FilterListId { get; set; }
            public string[] RawRules { get; private set; }

            public void ParseRawRules()
            {
                RawRules = Content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}