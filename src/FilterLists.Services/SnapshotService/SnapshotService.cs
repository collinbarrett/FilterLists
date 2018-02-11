using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.SnapshotService
{
    public class SnapshotService
    {
        private readonly FilterListsDbContext dbContext;

        public SnapshotService(FilterListsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CaptureAsync(int batchSize)
        {
            RollbackIncomplete();
            var lists = await GetLeastRecentlyCapturedLists(batchSize);
            var snapshots = GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private void RollbackIncomplete()
        {
            var incompleteSnapshots = dbContext.Snapshots.Where(x => x.IsCompleted == false);
            dbContext.Snapshots.RemoveRange(incompleteSnapshots);
            //TODO: don't assume that SnapshotDe.DedupSnapshotRules() didn't partially complete
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetLeastRecentlyCapturedLists(int batchSize)
        {
            return await dbContext.FilterLists.OrderBy(x => x.Snapshots.Any())
                                  .ThenBy(x =>
                                      x.Snapshots.Select(y => y.CreatedDateUtc)
                                       .OrderByDescending(y => y)
                                       .FirstOrDefault())
                                  .Where(x => !x.Snapshots.Any() ||
                                              x.Snapshots.Select(y => y.CreatedDateUtc)
                                               .OrderByDescending(y => y)
                                               .FirstOrDefault() <
                                              DateTime.UtcNow.AddDays(-1))
                                  .Take(batchSize)
                                  .AsNoTracking()
                                  .ProjectTo<FilterListViewUrlDto>()
                                  .ToListAsync();
        }

        private IEnumerable<SnapshotDe> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists)
        {
            return lists.Select(list => new SnapshotDe(dbContext, list));
        }

        private static async Task SaveSnapshots(IEnumerable<SnapshotDe> snapshots)
        {
            foreach (var snapshot in snapshots)
                await snapshot.SaveSnapshotAsync();
        }
    }
}