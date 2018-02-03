using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotDomainEntity
    {
        private readonly FilterListsDbContext dbContext;
        private readonly FilterListViewUrlDto list;
        private IEnumerable<Rule> newSnapshotRules;
        private IEnumerable<Rule> preExistingSnapshotRules;
        private List<string> rawRules;
        private Snapshot snapshot;

        public SnapshotDomainEntity(FilterListsDbContext dbContext, FilterListViewUrlDto list)
        {
            this.dbContext = dbContext;
            this.list = list;
        }

        public async Task SaveSnapshot()
        {
            await AddSnapshot();
            var content = await TryGetContent();
            if (content != null)
            {
                ParseRawRules(content);
                await AddNewRules();
                AddSnapshotRules();
            }

            await dbContext.SaveChangesAsync();
        }

        private async Task AddSnapshot()
        {
            snapshot = new Snapshot {FilterList = await dbContext.FilterLists.FindAsync(list.Id)};
            dbContext.Snapshots.Add(snapshot);
        }

        private async Task<string> TryGetContent()
        {
            try
            {
                return await GetContent();
            }
            catch (WebException we)
            {
                snapshot.HttpStatusCode = (int)((HttpWebResponse)we.Response).StatusCode;
                return null;
            }
        }

        private async Task<string> GetContent()
        {
            using (var httpClient = new HttpClient())
            using (var httpResponseMessage = await httpClient.GetAsync(list.ViewUrl))
            {
                snapshot.HttpStatusCode = (int)httpResponseMessage.StatusCode;
                if (httpResponseMessage.IsSuccessStatusCode)
                    return await httpResponseMessage.Content.ReadAsStringAsync();
            }

            return null;
        }

        private void ParseRawRules(string content)
        {
            rawRules = content.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (var i = 0; i < rawRules.Count; i++)
                rawRules[i] = rawRules[i].LintStringForMySql();
            rawRules = rawRules.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        }

        private async Task AddNewRules()
        {
            preExistingSnapshotRules = dbContext.Rules.Where(rule => rawRules.Contains(rule.Raw));
            var newSnapshotRawRules = rawRules.Except(preExistingSnapshotRules.Select(x => x.Raw));
            newSnapshotRules = newSnapshotRawRules.Select(newSnapshotRawRule => new Rule {Raw = newSnapshotRawRule})
                                                  .ToList();
            await dbContext.Rules.AddRangeAsync(newSnapshotRules);
        }

        private void AddSnapshotRules()
        {
            snapshot.SnapshotRules = preExistingSnapshotRules
                                     .Concat(newSnapshotRules)
                                     .Select(rule => new SnapshotRule {Rule = rule, Snapshot = snapshot})
                                     .ToList();
        }
    }
}