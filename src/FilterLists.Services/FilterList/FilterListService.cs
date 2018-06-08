using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class FilterListService : Service
    {
        public FilterListService(FilterListsDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync()
        {
            var summaries = await GetSummaryDtos();
            var latestSnapshots = await GetLatestSnapshots();
            return summaries.GroupJoin(latestSnapshots, summary => summary.Id, snap => snap.FilterListId,
                (summary, snap) =>
                {
                    var snaps = snap as Data.Entities.Snapshot[] ?? snap.ToArray();
                    return new ListSummaryDto
                    {
                        Id = summary.Id,
                        AddedDate = summary.AddedDate,
                        CrawledDate = snaps.Any() ? snaps.Single().CreatedDateUtc : (DateTime?) null,
                        Languages = summary.Languages,
                        Name = summary.Name,
                        ViewUrl = summary.ViewUrl
                    };
                });
        }

        private async Task<List<ListSummaryDto>> GetSummaryDtos()
        {
            return await DbContext.FilterLists.AsNoTracking()
                                  .OrderBy(list => list.Name)
                                  .ProjectTo<ListSummaryDto>()
                                  .ToListAsync();
        }

        private async Task<List<Data.Entities.Snapshot>> GetLatestSnapshots()
        {
            return await DbContext.Snapshots.AsNoTracking()
                                  .Where(snap =>
                                      snap.IsCompleted &&
                                      (snap.AddedSnapshotRules.Count > 0 || snap.RemovedSnapshotRules.Count > 0))
                                  .GroupBy(snap => snap.FilterListId,
                                      (key, x) => x.OrderByDescending(y => y.CreatedDateUtc).First())
                                  .ToListAsync();
        }

        public async Task<ListDetailsDto> GetDetailsAsync(int id)
        {
            var details = await DbContext.FilterLists.AsNoTracking()
                                         .ProjectTo<ListDetailsDto>()
                                         .FirstAsync(x => x.Id == id)
                                         .FilterParentListFromMaintainerAdditionalLists();
            details.RuleCount = await GetActiveRuleCount(details);
            details.CrawledDate = await GetCrawledDate(details);
            return details;
        }

        private async Task<int> GetActiveRuleCount(ListDetailsDto details)
        {
            var listSnapshots = DbContext.Snapshots.AsNoTracking()
                                         .Where(s => s.FilterListId == details.Id && s.IsCompleted);
            return await listSnapshots.SelectMany(sr => sr.AddedSnapshotRules).CountAsync() -
                   await listSnapshots.SelectMany(sr => sr.RemovedSnapshotRules).CountAsync();
        }

        private async Task<DateTime?> GetCrawledDate(ListDetailsDto details)
        {
            var snapshotDates = DbContext.Snapshots.AsNoTracking()
                                         .Where(s => s.FilterListId == details.Id && s.IsCompleted &&
                                                     (s.AddedSnapshotRules.Count > 0 ||
                                                      s.RemovedSnapshotRules.Count > 0))
                                         .Select(s => s.CreatedDateUtc)
                                         .OrderByDescending(s => s.Date);
            return snapshotDates.Any() ? (DateTime?) await snapshotDates.FirstAsync() : null;
        }
    }
}