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

        //TODO: update algorithm to support non-standard list sizes and formats (#200, #201)
        private readonly List<int> ignoreLists = new List<int> {48, 173, 185, 186, 187, 188, 189};

        public SnapshotService(FilterListsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CaptureAsync(int batchSize)
        {
            RollbackIncompletedSnapshots();
            var lists = await GetListsToCapture(batchSize);
            var snapshots = GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private void RollbackIncompletedSnapshots()
        {
            var incompleteSnapshots = dbContext.Snapshots.Where(ss => ss.IsCompleted == false);
            dbContext.Snapshots.RemoveRange(incompleteSnapshots);
            //TODO: don't assume that SnapshotDe.DedupSnapshotRules() didn't partially complete
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetListsToCapture(int batchSize)
        {
            return await dbContext
                         .FilterLists
                         .Where(list =>
                             (!list.Snapshots.Any() ||
                              list.Snapshots
                                  .Select(ss => ss.CreatedDateUtc)
                                  .OrderByDescending(sscd => sscd)
                                  .FirstOrDefault() < DateTime.UtcNow.AddDays(-1)) &&
                             !ignoreLists.Contains(list.Id))
                         .OrderBy(list => list.Snapshots.Any())
                         .ThenBy(list =>
                             list.Snapshots
                                 .Select(ss => ss.CreatedDateUtc)
                                 .OrderByDescending(sscd => sscd)
                                 .FirstOrDefault())
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