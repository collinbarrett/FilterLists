using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

internal interface ICommandContext
{
    DbSet<FilterList> FilterLists { get; }
    DbSet<License> Licenses { get; }
}
