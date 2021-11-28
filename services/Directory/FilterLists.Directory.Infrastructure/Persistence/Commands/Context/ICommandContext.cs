using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Languages;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Domain.Aggregates.Maintainers;
using FilterLists.Directory.Domain.Aggregates.Software;
using FilterLists.Directory.Domain.Aggregates.Syntaxes;
using FilterLists.Directory.Domain.Aggregates.Tags;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

public interface ICommandContext
{
    DbSet<FilterList> FilterLists { get; }
    DbSet<Language> Languages { get; }
    DbSet<License> Licenses { get; }
    DbSet<Maintainer> Maintainers { get; }
    DbSet<Software> Software { get; }
    DbSet<Syntax> Syntaxes { get; }
    DbSet<Tag> Tags { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
