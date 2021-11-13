using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

public interface ICommandContext
{
    DbSet<Change> Changes { get; }
    DbSet<FilterList> FilterLists { get; }
    DbSet<License> Licenses { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
