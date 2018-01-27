using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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

        public async Task Scrape(int numberLists)
        {
            var lists = filterListsDbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(numberLists)
                .Select(x => new FilterListDto {Id = x.Id, ViewUrl = x.ViewUrl});
            var snapshots = await GetSnapshots(lists);
            await AddOrUpdateRules(snapshots);
            //TODO: update FilterList.ScrapedDateUtc
        }

        private static async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListDto> lists)
        {
            var snapshots = new List<Snapshot>();
            foreach (var list in lists)
                snapshots.Add(new Snapshot {Content = await GetContent(list.ViewUrl), FilterListId = list.Id});
            return snapshots;
        }

        //TODO: move to string (URL) extension method
        private static async Task<string> GetContent(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var httpResponseMessage = await httpClient.GetAsync(url))
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                            return await httpResponseMessage.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception)
            {
                //TODO: log exception for analysis
                return null;
            }

            //TODO: log httpResponseMessage.StatusCode for analysis
            return null;
        }

        private async Task AddOrUpdateRules(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots)
                await AddOrUpdateRules(snapshot);
        }

        private async Task AddOrUpdateRules(Snapshot snapshot)
        {
            var cachedRules = filterListsDbContext.FilterListRules
                .Where(x => x.FilterListId == snapshot.FilterListId)
                .Select(x => x.Rule);

            IEnumerable<string> currentRulesRaw =
                snapshot.Content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);

            var existingCurrentRules = filterListsDbContext.Rules.Where(x => currentRulesRaw.Contains(x.Raw));

            var deletedRules = cachedRules.Except(existingCurrentRules).ToList();

            filterListsDbContext.FilterListRules.RemoveRange(filterListsDbContext.FilterListRules
                .Where(x => deletedRules.Select(y => y.Id).Contains(x.RuleId))
                .Where(x => x.FilterListId == snapshot.FilterListId));

            //TODO: update FilterList.UpdatedDateUtc

            foreach (var line in currentRulesRaw)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var rule = new Rule {Raw = line};
                if (!await filterListsDbContext.Rules.AnyAsync(x => x.Raw == rule.Raw))
                    filterListsDbContext.Rules.Add(rule);
                var filterListRule = new FilterListRule {FilterListId = snapshot.FilterListId, Rule = rule};
                if (!await filterListsDbContext.FilterListRules.AnyAsync(x =>
                    x.RuleId == rule.Id && x.FilterListId == snapshot.FilterListId))
                    filterListsDbContext.FilterListRules.Add(filterListRule);
                filterListsDbContext.FilterListRules.Add(filterListRule);
            }

            try
            {
                await filterListsDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                //TODO: log exception
            }
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