using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Snapshot.Models;
using FilterLists.Services.Wayback;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotService : Service
    {
        private string uaString;

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task CaptureAsync(int batchSize)
        {
            await CleanupFailedSnapshots();
            uaString = await UserAgentService.GetMostPopularString();
            var lists = await GetListsToCapture(batchSize);
            var snaps = await CreateAndSaveSnaps<Snapshot>(lists);
            var listsToRetry = snaps.Where(s => s.RetryMirror).Select(s => s.List);
            await CreateAndSaveSnaps<SnapshotWayback>(listsToRetry);
        }

        private async Task CleanupFailedSnapshots()
        {
            DbContext.RemoveRange(DbContext.SnapshotRules.Where(sr => !sr.Snapshot.WasSuccessful));
            await DbContext.SaveChangesAsync();
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
            await DbContext
                  .FilterLists
                  .Where(l => l.Snapshots
                               .OrderByDescending(s => s.CreatedDateUtc)
                               .Select(s => s.CreatedDateUtc)
                               .FirstOrDefault() <= DateTime.Now.AddDays(-7) &&
                              !(l.ViewUrl.StartsWith(WaybackService.WaybackMachineUrlPrefix) &&
                                l.Snapshots.Any(s => s.WasSuccessful)))
                  .OrderBy(l => l.Snapshots.Any())
                  .ThenBy(l => l.Snapshots
                                .Select(s => s.CreatedDateUtc)
                                .OrderByDescending(d => d)
                                .FirstOrDefault())
                  .Take(batchSize)
                  .ProjectTo<FilterListViewUrlDto>(MapConfig)
                  .ToListAsync();

        private async Task<List<TSnap>> CreateAndSaveSnaps<TSnap>(IEnumerable<FilterListViewUrlDto> lists)
            where TSnap : Snapshot, new()
        {
            var snaps = CreateSnaps<TSnap>(lists).ToList();
            await SaveSnaps(snaps);
            return snaps;
        }

        private IEnumerable<TSnap> CreateSnaps<TSnap>(IEnumerable<FilterListViewUrlDto> lists)
            where TSnap : Snapshot, new() =>
            lists.Select(l =>
                Activator.CreateInstance(typeof(TSnap), DbContext, l, uaString) as TSnap);

        private static async Task SaveSnaps(IEnumerable<Snapshot> snaps)
        {
            foreach (var snap in snaps)
                await snap.TrySaveAsync();
        }
    }
}