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
            var latestUpdatedSnapshots = await GetLatestUpdatedSnapshots();
            return summaries.Join(latestUpdatedSnapshots, summary => summary.Id, snap => snap.FilterListId,
                (summary, snap) => new ListSummaryDto
                {
                    Id = summary.Id,
                    AddedDate = summary.AddedDate,
                    Languages = summary.Languages,
                    Name = summary.Name,
                    UpdatedDate = snap.CreatedDateUtc,
                    ViewUrl = summary.ViewUrl
                });
        }

        private async Task<List<ListSummaryDto>> GetSummaryDtos()
        {
            return await DbContext.FilterLists.AsNoTracking()
                                  .OrderBy(list => list.Name)
                                  .ProjectTo<ListSummaryDto>()
                                  .ToListAsync();
        }

        private async Task<List<Data.Entities.Snapshot>> GetLatestUpdatedSnapshots()
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
            details.UpdatedDate = await GetUpdatedDate(details);
            return details;
        }

        private async Task<int> GetActiveRuleCount(ListDetailsDto details)
        {
            return await DbContext.Snapshots.AsNoTracking()
                                  .Where(s => s.FilterListId == details.Id && s.IsCompleted)
                                  .SelectMany(sr => sr.AddedSnapshotRules)
                                  .CountAsync() -
                   await DbContext.Snapshots.AsNoTracking()
                                  .Where(s => s.FilterListId == details.Id && s.IsCompleted)
                                  .SelectMany(sr => sr.RemovedSnapshotRules)
                                  .CountAsync();
        }

        private async Task<DateTime> GetUpdatedDate(ListDetailsDto details)
        {
            return await DbContext.Snapshots.AsNoTracking()
                                  .Where(s => s.FilterListId == details.Id && s.IsCompleted &&
                                              (s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0))
                                  .Select(s => s.CreatedDateUtc)
                                  .OrderByDescending(s => s.Date)
                                  .FirstAsync();
        }
    }
}