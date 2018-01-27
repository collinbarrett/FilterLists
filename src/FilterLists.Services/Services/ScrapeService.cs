using System;
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

        public async Task Scrape()
        {
            var lists = filterListsDbContext.FilterLists;
            foreach (var list in lists) await AddSnapshot(list);
            await filterListsDbContext.SaveChangesAsync();
        }

        private async Task AddSnapshot(FilterList list)
        {
            var snapshot = await GetContent(list.ViewUrl);
            try
            {
                if (snapshot == null) return;
            }
            catch (AggregateException)
            {
                return;
            }
            catch (HttpRequestException)
            {
                return;
            }

            filterListsDbContext.Snapshots.Add(new Snapshot
            {
                Content = snapshot,
                FilterListId = list.Id
            });
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
    }
}