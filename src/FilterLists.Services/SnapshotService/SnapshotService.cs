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

        public async Task CaptureSnapshotsAsync(int batchSize)
        {
            var lists = await GetLeastRecentlyCapturedLists(batchSize);
            var snapshots = GetSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetLeastRecentlyCapturedLists(int batchSize)
        {
            return await dbContext.FilterLists
                                  .OrderBy(x => x.Snapshots.Any())
                                  .ThenBy(x => x.Snapshots
                                                .Select(y => y.CreatedDateUtc)
                                                .OrderByDescending(y => y)
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