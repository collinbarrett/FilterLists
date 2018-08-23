using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Snapshot.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotService : Service
    {
        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task CaptureAsync(int batchSize)
        {
            var lists = await GetListsToCapture(batchSize);
            var uaString = await UserAgentService.GetMostPopularString();
            var snaps = CreateSnaps(lists, uaString);
            await SaveSnaps(snaps);
        }

        private async Task<IEnumerable<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
            await DbContext
                  .FilterLists
                  .Where(l => !l.CantSnapshot &&
                              (!l.Snapshots.Any() ||
                               l.Snapshots
                                .Select(s => s.CreatedDateUtc)
                                .OrderByDescending(d => d)
                                .First() < yesterday))
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

        private IEnumerable<Snapshot> CreateSnaps(IEnumerable<FilterListViewUrlDto> lists, string uaString) =>
            lists.Select(l => new Snapshot(DbContext, l, uaString));

        private static async Task SaveSnaps(IEnumerable<Snapshot> snaps)
        {
            foreach (var snap in snaps)
                await snap.TrySaveAsync();
        }
    }
}