using System;
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

        public async Task Scrape()
        {
            //TEMP: remove Take(1) when algorithm complete
            var lists = await filterListsDbContext.FilterLists.Take(1).ToListAsync();
            foreach (var list in lists) await ScrapeList(list);
        }

        private async Task ScrapeList(FilterList list)
        {
            var snapshot = await GetContent(list.ViewUrl);
            try
            {
                if (snapshot == null) return;
            }
            catch (Exception)
            {
                //TODO: log exception
                return;
            }

            await AddRules(list, snapshot);
        }

        private static async Task<string> GetContent(string url)
        {
            using (var httpClient = new HttpClient())
            {
                using (var httpResponseMessage = await httpClient.GetAsync(url))
                {
                    if (httpResponseMessage.IsSuccessStatusCode)
                        return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }

            return null;
        }

        private async Task AddRules(FilterList list, string snapshot)
        {
            var lines = snapshot.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var rule = new Rule {Raw = line};
                if (!await filterListsDbContext.Rules.AnyAsync(x => x.Raw == rule.Raw))
                    filterListsDbContext.Rules.Add(rule);
                var filterListRule = new FilterListRule {FilterList = list, Rule = rule};
                if (!await filterListsDbContext.FilterListRules.AnyAsync(x =>
                    x.RuleId == rule.Id && x.FilterListId == list.Id))
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
    }
}