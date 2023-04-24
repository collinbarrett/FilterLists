using FilterLists.Api.Persistence;
using FilterLists.Api.Persistence.Entities;
using HotChocolate.Types;

namespace FilterLists.Api.Api;

[QueryType]
internal static class Query
{
    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<FilterList> GetFilterLists(FilterListsDbContext dbContext)
    {
        return dbContext.FilterLists;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Language> GetLanguages(FilterListsDbContext dbContext)
    {
        return dbContext.Languages;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<License> GetLicenses(FilterListsDbContext dbContext)
    {
        return dbContext.Licenses;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Maintainer> GetMaintainers(FilterListsDbContext dbContext)
    {
        return dbContext.Maintainers;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Software> GetSoftware(FilterListsDbContext dbContext)
    {
        return dbContext.Software;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Syntax> GetSyntaxes(FilterListsDbContext dbContext)
    {
        return dbContext.Syntaxes;
    }

    [UsePaging(IncludeTotalCount = true)]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Tag> GetTags(FilterListsDbContext dbContext)
    {
        return dbContext.Tags;
    }
}