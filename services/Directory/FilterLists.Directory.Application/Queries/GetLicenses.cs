using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    public class Query(QueryDbContext ctx)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            return await ctx.Licenses
                .Where(l => l.FilterLists.Any())
                .OrderBy(l => l.Id)
                .Select(l => new Response(
                    l.Id,
                    l.Name,
                    l.Url,
                    l.PermitsModification,
                    l.PermitsDistribution,
                    l.PermitsCommercialUse
                ))
                .TagWith(nameof(GetLicenses))
                .ToListAsync(ct);
        }
    }

    /// <param name="Id" example="5">The identifier.</param>
    /// <param name="Name" example="All Rights Reserved">The unique name.</param>
    /// <param name="Url" example="https://en.wikipedia.org/wiki/All_rights_reserved">The URL of the home page.</param>
    /// <param name="PermitsModification" example="false">If the License permits modification.</param>
    /// <param name="PermitsDistribution" example="false">If the License permits distribution.</param>
    /// <param name="PermitsCommercialUse" example="false">If the License permits commercial use.</param>
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        bool PermitsModification,
        bool PermitsDistribution,
        bool PermitsCommercialUse);
}