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
        private readonly BatchSizeService batchSizeService;
        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);
        private string uaString;

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig,
            BatchSizeService batchSizeService)
            : base(dbContext, mapConfig) => this.batchSizeService = batchSizeService;

        public async Task CaptureAsync(int batchSize)
        {
            uaString = await UserAgentService.GetMostPopularString();
            var lists = await GetListsToCapture(batchSize);
            var snaps = await CreateAndSaveSnaps<Snapshot>(lists);
            var listsToRetry = snaps.Where(s => s.RetryMirror).Select(s => s.List);
            await CreateAndSaveSnaps<SnapshotWayback>(listsToRetry);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
            await DbContext
                  .FilterLists
                  .Where(l => !l.CantSnapshot &&
                              (!l.Snapshots.Any() ||
                               l.Snapshots
                                .Select(s => s.CreatedDateUtc)
                                .OrderByDescending(d => d)
                                .First() < yesterday &&
                               !l.ViewUrl
                                 .StartsWith(WaybackService.WaybackMachineUrlPrefix)))
                  .OrderBy(l => l.Snapshots.Any())
                  .ThenBy(l => l.Snapshots
                                .OrderByDescending(s => s.CreatedDateUtc)
                                .FirstOrDefault()
                                .WasSuccessful)
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
                Activator.CreateInstance(typeof(TSnap), batchSizeService, DbContext, l, uaString) as TSnap);

        private static async Task SaveSnaps(IEnumerable<Snapshot> snaps)
        {
            foreach (var snap in snaps)
                await snap.TrySaveAsync();
        }
    }
}