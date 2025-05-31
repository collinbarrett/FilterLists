using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    public class Query(QueryDbContext ctx, HybridCache cache)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            const string key = nameof(GetLicenses);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Licenses
                        .Where(l => l.FilterLists.Any())
                        .OrderBy(l => l.Id)
                        .Select(l => new Response(
                            l.Id,
                            l.Name,
                            l.Url,
                            l.PermitsModification,
                            l.PermitsDistribution,
                            l.PermitsCommercialUse,
                            l.FilterLists
                                .OrderBy(f => f.Id)
                                .Select(f => f.Id)
                        ))
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
        }
    }

    /// <param name="Id" example="5">The identifier.</param>
    /// <param name="Name" example="All Rights Reserved">The unique name.</param>
    /// <param name="Url" example="https://en.wikipedia.org/wiki/All_rights_reserved">The URL of the home page.</param>
    /// <param name="PermitsModification" example="false">If the License permits modification.</param>
    /// <param name="PermitsDistribution" example="false">If the License permits distribution.</param>
    /// <param name="PermitsCommercialUse" example="false">If the License permits commercial use.</param>
    /// <param name="FilterListIds" example="[ 6, 31 ]">The identifiers of the FilterLists released under this License.</param>
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        bool PermitsModification,
        bool PermitsDistribution,
        bool PermitsCommercialUse,
        IEnumerable<int> FilterListIds);
}