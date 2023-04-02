using FilterLists.Api.Queries.Context;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Queries.Handlers;

internal static class GetFilterLists
{
    public static async Task<string?> ExecuteAsync(IQueryContext dbContext, CancellationToken cancellationToken)
    {
        var list = await dbContext.FilterLists.Where(f => f.Id == 1).Include(f => f.ViewUrls)
            .SingleOrDefaultAsync(f => f.Id == 1, cancellationToken);
        return list?.ViewUrls.FirstOrDefault()?.Url.AbsoluteUri;
    }
}