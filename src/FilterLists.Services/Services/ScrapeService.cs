using System;
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

        public void Scrape()
        {
            var lists = filterListsDbContext.FilterLists.Take(5);
            foreach (var list in lists) AddSnapshot(list);
            filterListsDbContext.SaveChangesAsync();
        }

        private void AddSnapshot(FilterList list)
        {
            var snapshot = GetContent(list.ViewUrl);
            try
            {
                if (snapshot.Result == null) return;
            }
            catch (AggregateException)
            {
                return;
            }

            filterListsDbContext.Snapshots.Add(new Snapshot
            {
                Content = snapshot.Result,
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