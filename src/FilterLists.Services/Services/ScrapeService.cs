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
            var list = filterListsDbContext.FilterLists.First();
            var snapshot = GetContent(list.ViewUrl);
            filterListsDbContext.Snapshots.Add(new Snapshot
            {
                Content = snapshot.Result,
                FilterListId = list.Id
            });
            filterListsDbContext.SaveChangesAsync();
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