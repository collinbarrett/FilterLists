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

        //TODO: call via scheduled job
        public async Task CaptureSnapshotsAsync(int batchSize)
        {
            var lists = await GetNextListsToCapture(batchSize);
            var snapshots = GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetNextListsToCapture(int batchSize)
        {
            var neverCapturedLists = await GetNeverCapturedLists(batchSize);
            if (neverCapturedLists.Count == batchSize)
                return neverCapturedLists;
            var leastRecentlyCapturedLists = await GetLeastRecentlyCapturedLists(batchSize - neverCapturedLists.Count);
            return neverCapturedLists.Concat(leastRecentlyCapturedLists);
        }

        private async Task<List<FilterListViewUrlDto>> GetNeverCapturedLists(int batchSize)
        {
            return await dbContext.FilterLists
                                  .Where(x => x.Snapshots.Count == 0)
                                  .Take(batchSize)
                                  .ProjectTo<FilterListViewUrlDto>()
                                  .ToListAsync();
        }

        private async Task<List<FilterListViewUrlDto>> GetLeastRecentlyCapturedLists(int batchSize)
        {
            return await dbContext.Snapshots
                                  .GroupBy(x => x.FilterList)
                                  .Select(x => x.OrderByDescending(y => y.CreatedDateUtc).First())
                                  .OrderBy(x => x.CreatedDateUtc)
                                  .Select(x => x.FilterList)
                                  .Take(batchSize)
                                  .ProjectTo<FilterListViewUrlDto>()
                                  .ToListAsync();
        }

        private IEnumerable<SnapshotDomainEntity> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists)
        {
            return lists.Select(list => new SnapshotDomainEntity(dbContext, list));
        }

        private static async Task SaveSnapshots(IEnumerable<SnapshotDomainEntity> snapshots)
        {
            foreach (var snapshot in snapshots)
                await snapshot.SaveSnapshot();
        }
    }
}