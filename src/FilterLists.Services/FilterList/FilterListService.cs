using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class FilterListService : Service
    {
        public FilterListService(FilterListsDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync() =>
            await DbContext.FilterLists.ProjectTo<ListSummaryDto>(Mapper.ConfigurationProvider).ToListAsync();

        public async Task<ListDetailsDto> GetDetailsAsync(uint id)
        {
            var details = await DbContext.FilterLists.ProjectTo<ListDetailsDto>(Mapper.ConfigurationProvider)
                                         .FirstAsync(x => x.Id == id)
                                         .FilterParentListFromMaintainerAdditionalLists();
            details.RuleCount = await GetActiveRuleCount(details);
            details.UpdatedDate = await GetUpdatedDate(details);
            return details;
        }

        private async Task<int> GetActiveRuleCount(ListDetailsDto details)
        {
            var listSnapshots = DbContext.Snapshots.AsNoTracking()
                                         .Where(s => s.FilterListId == details.Id && s.IsCompleted);
            return await listSnapshots.SelectMany(sr => sr.AddedSnapshotRules).CountAsync() -
                   await listSnapshots.SelectMany(sr => sr.RemovedSnapshotRules).CountAsync();
        }

        private async Task<DateTime?> GetUpdatedDate(ListDetailsDto details)
        {
            var snapshotDates = DbContext.Snapshots.AsNoTracking()
                                         .Where(s => s.FilterListId == details.Id && s.IsCompleted &&
                                                     s.HttpStatusCode == "200" &&
                                                     (s.AddedSnapshotRules.Count > 0 ||
                                                      s.RemovedSnapshotRules.Count > 0))
                                         .Select(s => s.CreatedDateUtc)
                                         .OrderByDescending(s => s.Date);
            return snapshotDates.Any() ? (DateTime?)await snapshotDates.FirstAsync() : null;
        }
    }
}