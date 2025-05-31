using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetMaintainers
{
    public class Query(QueryDbContext ctx, HybridCache cache)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            const string key = nameof(GetMaintainers);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Maintainers
                        .Where(m => m.FilterListMaintainers.Any())
                        .OrderBy(m => m.Id)
                        .Select(m => new Response(
                            m.Id,
                            m.Name,
                            m.Url,
                            m.EmailAddress,
                            m.TwitterHandle,
                            m.FilterListMaintainers
                                .OrderBy(fm => fm.FilterListId)
                                .Select(fm => fm.FilterListId)
                        ))
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
        }
    }

    /// <param name="Id" example="7">The identifier.</param>
    /// <param name="Name" example="The EasyList Authors">The unique name.</param>
    /// <param name="Url" example="https://easylist.to/">The URL of the home page.</param>
    /// <param name="EmailAddress" example="null">The email address.</param>
    /// <param name="TwitterHandle" example="null">The Twitter handle.</param>
    /// <param name="FilterListIds" example="[ 11, 13, 301 ]">The identifiers of the FilterLists maintained by this Maintainer.</param>
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        string? EmailAddress,
        string? TwitterHandle,
        IEnumerable<int> FilterListIds);
}