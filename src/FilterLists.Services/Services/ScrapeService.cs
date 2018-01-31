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
        private readonly FilterListsDbContext dbContext;

        public ScrapeService(FilterListsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //TODO: call via scheduled job
        public async Task ScrapeAsync(int batchSize)
        {
            var lists = await GetNextFilterListsToScrape(batchSize);
            var snapshots = await GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetNextFilterListsToScrape(int batchSize)
        {
            return await dbContext.FilterLists.OrderBy(x => x.ScrapedDateUtc).Take(batchSize)
                .ProjectTo<FilterListViewUrlDto>().ToListAsync();
        }

        private static async Task<IEnumerable<Snapshot>> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists)
        {
            return await Task.WhenAll(lists
                .Select(async list =>
                    new Snapshot {Content = await TryGetContent(list.ViewUrl), FilterListId = list.Id})
                .Where(x => x.Result.RawRules != null));
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

        private async Task SaveSnapshots(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots) await AddOrUpdateRules(snapshot);
        }

        private async Task AddOrUpdateRules(Snapshot snapshot)
        {
            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            // add new Rules
            var preExistingSnapshotRules = dbContext.Rules.Where(x => snapshot.RawRules.Contains(x.Raw));
            var newSnapshotRawRules = snapshot.RawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            var newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRuleRaw => new Rule {Raw = newSnapshotRuleRaw})
                .ToList();
            dbContext.Rules.AddRange(newSnapshotRules);

            // remove deleted FilterListRules
            var preExistingFilterListRules =
                dbContext.FilterListRules.Where(x => x.FilterListId == snapshot.FilterListId);
            var deletedFilterListRules =
                preExistingFilterListRules.Where(x => !preExistingSnapshotRules.Select(y => y.Id).Contains(x.RuleId));
            dbContext.FilterListRules.RemoveRange(deletedFilterListRules);

            // add FilterListRules for pre-existing Rules
            var preExistingSnapshotFilterListRules = preExistingSnapshotRules
                .Select(newSnapshotRule =>
                    new FilterListRule {FilterListId = snapshot.FilterListId, Rule = newSnapshotRule}).ToList()
                .Except(preExistingFilterListRules).ToList();
            dbContext.FilterListRules.AddRange(preExistingSnapshotFilterListRules);

            // add new FilterListRules
            var newFilterListRules = newSnapshotRules.Select(newSnapshotRule =>
                new FilterListRule {FilterListId = snapshot.FilterListId, Rule = newSnapshotRule}).ToList();
            dbContext.FilterListRules.AddRange(newFilterListRules);

            // update UpdatedDateUtc
            var list = dbContext.FilterLists.Find(snapshot.FilterListId);
            if (preExistingSnapshotFilterListRules.Any() || newFilterListRules.Any() || deletedFilterListRules.Any())
                list.UpdatedDateUtc = DateTime.UtcNow;

            // update ScrapedDateUtc
            list.ScrapedDateUtc = DateTime.UtcNow;
            dbContext.FilterLists.Update(list);

            await dbContext.SaveChangesAsync();
        }

        private class FilterListViewUrlDto
        {
            public int Id { get; set; }
            public string ViewUrl { get; set; }
        }

        private class Snapshot
        {
            public string Content
            {
                set
                {
                    if (value == null) return;
                    var rawRules = value.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries);
                    for (var i = 0; i < rawRules.Length; i++)
                        rawRules[i] = LintStringForMySql(rawRules[i]);
                    RawRules = rawRules;
                }
            }

            public int FilterListId { get; set; }

            public string[] RawRules { get; private set; }

            private static string LintStringForMySql(string rule)
            {
                rule = TrimSingleBackslashFromEnd(rule);
                return rule;
            }

            private static string TrimSingleBackslashFromEnd(string rule)
            {
                return rule.EndsWith(@"\") && !rule.EndsWith(@"\\") ? rule.Remove(rule.Length - 1) : rule;
            }
        }
    }
}