using FilterLists.Api.Infrastructure.Entities;

namespace FilterLists.Api.Infrastructure.Context;

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