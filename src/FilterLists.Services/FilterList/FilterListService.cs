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
            return await DbContext.FilterLists.AsNoTracking()
                                  .OrderBy(x => x.Name)
                                  .ProjectTo<ListSummaryDto>()
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
            return await DbContext.Snapshots.Where(s => s.FilterListId == details.Id && s.IsCompleted)
                                  .Include(s => s.AddedSnapshotRules)
                                  .SelectMany(sr => sr.AddedSnapshotRules)
                                  .CountAsync() -
                   await DbContext.Snapshots.Where(s => s.FilterListId == details.Id && s.IsCompleted)
                                  .Include(s => s.RemovedSnapshotRules)
                                  .SelectMany(sr => sr.RemovedSnapshotRules)
                                  .CountAsync();
        }

        private async Task<DateTime?> GetUpdatedDate(ListDetailsDto details)
        {
            return details.DiscontinuedDate != null
                ? (DateTime?) null
                : await DbContext.Snapshots.Where(s => s.FilterListId == details.Id && s.IsCompleted)
                                 .Include(s => s.AddedSnapshotRules)
                                 .Include(s => s.RemovedSnapshotRules)
                                 .Where(s => s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0)
                                 .Select(s => s.CreatedDateUtc)
                                 .OrderByDescending(s => s.Date)
                                 .FirstAsync();
        }
    }
}