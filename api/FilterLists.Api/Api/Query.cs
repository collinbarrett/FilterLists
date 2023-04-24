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
}