using System;
using System.Collections.Generic;
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
        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider,
            EmailService emailService)
            : base(dbContext, configurationProvider, emailService)
        {
        }

        public async Task CaptureAsync(int batchSize)
        {
            var lists = await GetListsToCapture(batchSize);
            var snapshots = CreateSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task<List<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
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
                                .Select(s => s.CreatedDateUtc)
                                .OrderByDescending(d => d)
                                .FirstOrDefault())
                  .Take(batchSize)
                  .ProjectTo<FilterListViewUrlDto>(ConfigurationProvider)
                  .ToListAsync();

        private IEnumerable<SnapshotDe> CreateSnapshots(IEnumerable<FilterListViewUrlDto> lists) =>
            lists.Select(l => new SnapshotDe(DbContext, EmailService, l));

        private static async Task SaveSnapshots(IEnumerable<SnapshotDe> snapshots)
        {
            foreach (var snapshot in snapshots)
                await snapshot.SaveAsync();
        }
    }
}