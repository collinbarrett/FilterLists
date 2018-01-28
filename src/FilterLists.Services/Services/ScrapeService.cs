using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;

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
                using (var httpResponseMessage = await httpClient.GetAsync(url))
                {
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
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

        //TODO: finish and validate
        private async Task AddOrUpdateRules(Snapshot snapshot)
        {
            var cachedRules = filterListsDbContext.FilterListRules
                .Where(x => x.FilterListId == snapshot.FilterListId)
                .Select(x => x.Rule);

            var currentRulesRaw =
                snapshot.Content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);

            var existingCurrentRules = filterListsDbContext.Rules.Where(x => currentRulesRaw.Contains(x.Raw));

            var newCurrentRulesRaw = currentRulesRaw.Except(existingCurrentRules.Select(x => x.Raw));

            var newCurrentRules = newCurrentRulesRaw.Select(newCurrentRuleRaw => new Rule {Raw = newCurrentRuleRaw});

            var deletedRules = cachedRules.Except(existingCurrentRules).ToList();

            filterListsDbContext.FilterListRules.RemoveRange(filterListsDbContext.FilterListRules
                .Where(x => deletedRules.Select(y => y.Id).Contains(x.RuleId))
                .Where(x => x.FilterListId == snapshot.FilterListId));

            //TODO: consider never removing FilterListsRules but rather marking a flag as deprecated to expose when rule was removed

            if (newCurrentRules.Any() || deletedRules.Any())
            {
                var list = filterListsDbContext.FilterLists.FindAsync(snapshot.FilterListId).Result;
                list.UpdatedDateUtc = DateTime.UtcNow;
                filterListsDbContext.FilterLists.Update(list);
            }

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