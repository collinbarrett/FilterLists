using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

public interface IQueryContext
{
    IQueryable<FilterList> FilterLists { get; }
    IQueryable<Language> Languages { get; }
    IQueryable<License> Licenses { get; }
    IQueryable<Maintainer> Maintainers { get; }
    IQueryable<Software> Software { get; }
    IQueryable<Syntax> Syntaxes { get; }
    IQueryable<Tag> Tags { get; }
}