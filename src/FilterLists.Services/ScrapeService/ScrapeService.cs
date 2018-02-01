using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.ScrapeService
{
    public class ScrapeService
    {
        private readonly FilterListsDbContext dbContext;

        public ScrapeService(FilterListsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //TODO: call via scheduled job
        public async Task ScrapeAsync(int batchSize)
        {
            var lists = await GetNextListsToScrape(batchSize);
            var snapshots = await GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task<List<FilterListViewUrlDto>> GetNextListsToScrape(int batchSize)
        {
            return await dbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(batchSize)
                .ProjectTo<FilterListViewUrlDto>().ToListAsync();
        }

        private async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists)
        {
            return await Task.WhenAll(lists
                .Select(async list => new Snapshot(dbContext, await TryGetContent(list.ViewUrl), list.Id))
                .Where(x => x.Result.HasRules));
        }

        private static async Task<string> TryGetContent(string url)
        {
            try
            {
                return await GetHttpResponseMessageContent(url);
            }
            catch (Exception)
            {
                //TODO: log exception
                return null;
            }
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

        private static async Task SaveSnapshots(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots) await snapshot.AddOrUpdateRules();
        }
    }
}