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
        //TODO: https://github.com/collinbarrett/FilterLists/issues/200
        //TODO: https://github.com/collinbarrett/FilterLists/issues/201
        private static readonly IList<uint> IgnoreLists =
            new ReadOnlyCollection<uint>(new List<uint> {48, 149, 173, 185, 186, 187, 188, 189, 352});

        private readonly DateTime yesterday = DateTime.UtcNow.AddDays(-1);

        public SnapshotService(FilterListsDbContext dbContext, IConfigurationProvider configurationProvider,
            EmailService emailService)
            : base(dbContext, configurationProvider, emailService)
        {
        }

        public async Task CaptureAsync(int batchSize)
        {
            //TODO: remove after closed: https://github.com/collinbarrett/FilterLists/issues/344
            await RollbackIncompletedSnapshots();

            var lists = await GetListsToCapture(batchSize);
            var snapshots = CreateSnapshots(lists);
            await SaveSnapshots(snapshots);
        }

        private async Task RollbackIncompletedSnapshots()
        {
            var incompleteSnapshots = DbContext.Snapshots.Where(ss => ss.IsCompleted == false);
            DbContext.Snapshots.RemoveRange(incompleteSnapshots);
            await DbContext.SaveChangesAsync();
        }

        private async Task<List<FilterListViewUrlDto>> GetListsToCapture(int batchSize) =>
            await DbContext
                  .FilterLists
                  .Where(l => !IgnoreLists.Contains(l.Id) &&
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
                await snapshot.SaveSnapshotAsync();
        }
    }
}