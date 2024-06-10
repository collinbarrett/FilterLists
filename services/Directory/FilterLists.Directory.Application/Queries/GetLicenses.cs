using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Licenses
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
                .TagWith(nameof(GetLicenses))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var license in cache.GetOrCreateAsyncEnumerable(
                                   nameof(GetLicenses),
                                   Query(ctx).WithCancellation(ct))
                               .WithCancellation(ct))
                yield return license;
        }
    }

    /// <param name="Id" example="5">The identifier.</param>
    /// <param name="Name" example="All Rights Reserved">The unique name.</param>
    /// <param name="Url" example="https://en.wikipedia.org/wiki/All_rights_reserved">The URL of the home page.</param>
    /// <param name="PermitsModification" example="false">If the License permits modification.</param>
    /// <param name="PermitsDistribution" example="false">If the License permits distribution.</param>
    /// <param name="PermitsCommercialUse" example="false">If the License permits commercial use.</param>
    /// <param name="FilterListIds" example="[ 6, 31 ]">The identifiers of the FilterLists released under this License.</param>
    [PublicAPI]
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        bool PermitsModification,
        bool PermitsDistribution,
        bool PermitsCommercialUse,
        IEnumerable<int> FilterListIds);
}