using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Snapshot.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Snapshot
{
    [UsedImplicitly]
    public class SnapshotService : Service
    {
        //TODO: update algorithm to support non-standard list sizes and formats (#200, #201)
        private static readonly IList<uint> IgnoreLists =
            new ReadOnlyCollection<uint>(new List<uint> {48, 149, 173, 185, 186, 187, 188, 189, 352});

        public SnapshotService(FilterListsDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
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
            var incompleteSnapshots = DbContext.Snapshots.Where(ss => ss.IsCompleted == false);
            DbContext.Snapshots.RemoveRange(incompleteSnapshots);
            //TODO: don't assume that SnapshotDe.DedupSnapshotRules() didn't partially complete
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
            await DbContext
                  .FilterLists
                  .Where(list =>
                      (!list.Snapshots.Any() ||
                       list.Snapshots.Select(ss => ss.CreatedDateUtc).OrderByDescending(sscd => sscd).FirstOrDefault() <
                       DateTime.UtcNow.AddDays(-1)) && !IgnoreLists.Contains(list.Id))
                  .OrderBy(list => list.Snapshots.Any())
                  .ThenBy(list =>
                      list.Snapshots.Select(ss => ss.CreatedDateUtc).OrderByDescending(sscd => sscd).FirstOrDefault())
                  .Take(batchSize)
                  .ProjectTo<FilterListViewUrlDto>(Mapper.ConfigurationProvider)
                  .ToListAsync();

        private IEnumerable<SnapshotDe> GetSnapshots(IEnumerable<FilterListViewUrlDto> lists) =>
            lists.Select(list => new SnapshotDe(DbContext, list));

        private static async Task SaveSnapshots(IEnumerable<SnapshotDe> snapshots)
        {
            foreach (var snapshot in snapshots)
                await snapshot.SaveSnapshotAsync();
        }
    }
}