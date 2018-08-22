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
        private readonly EmailService emailService;
        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig,
            EmailService emailService)
            : base(dbContext, mapConfig) => this.emailService = emailService;

        public async Task CaptureAsync(int batchSize)
        {
            var lists = await GetListsToCapture(batchSize);
            var uaString = await UserAgentService.GetMostPopularString();
            var snapshots = CreateSnapshots(lists, uaString);
            await SaveSnapshots(snapshots);
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

        private IEnumerable<Snapshot> CreateSnapshots(IEnumerable<FilterListViewUrlDto> lists, string uaString) =>
            lists.Select(l => new Snapshot(DbContext, emailService, l, uaString));

        private static async Task SaveSnapshots(IEnumerable<Snapshot> snapshots)
        {
            foreach (var snapshot in snapshots)
                await snapshot.TrySaveAsync();
        }
    }
}