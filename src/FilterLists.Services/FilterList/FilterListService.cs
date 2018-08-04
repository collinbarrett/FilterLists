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
                    snap = snap as Data.Entities.Snapshot[] ?? snap.ToArray();
                    var updatedDate = snap.Any() ? snap.Single().CreatedDateUtc : (DateTime?) null;
                    return new ListSummaryDto
                    {
                        Id = summary.Id,
                        AddedDate = summary.AddedDate,
                        Languages = summary.Languages,
                        Name = summary.Name,
                        UpdatedDate = updatedDate,
                        ViewUrl = summary.ViewUrl
                    };
                });
        }

        private async Task<List<ListSummaryDto>> GetSummaryDtos() =>
            await DbContext.FilterLists.OrderBy(l => l.Name).ProjectTo<ListSummaryDto>().ToListAsync();

        private async Task<List<Data.Entities.Snapshot>> GetLatestSnapshots()
        {
            return await DbContext.Snapshots.AsNoTracking()
                                  .Where(s => s.IsCompleted && s.HttpStatusCode == "200" &&
                                              (s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0))
                                  .GroupBy(s => s.FilterListId,
                                      (key, x) => x.OrderByDescending(y => y.CreatedDateUtc).First())
                                  .ToListAsync();
        }

        public async Task<ListDetailsDto> GetDetailsAsync(uint id)
        {
            var details = await DbContext.FilterLists.ProjectTo<ListDetailsDto>()
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
            return snapshotDates.Any() ? (DateTime?) await snapshotDates.FirstAsync() : null;
        }
    }
}