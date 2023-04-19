using FilterLists.Api.Infrastructure.Context;
using FilterLists.Api.Infrastructure.Entities;
using HotChocolate.Types;

namespace FilterLists.Api;

public class Query
{
    [UsePaging(IncludeTotalCount = true, DefaultPageSize = 10)]
    [UseProjection]
    public IQueryable<FilterList> GetFilterLists(FilterListsDbContext dbContext)
    {
        return dbContext.FilterLists;
    }
}