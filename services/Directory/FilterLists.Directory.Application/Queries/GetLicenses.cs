using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<LicenseVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Licenses
                .Where(l => l.FilterLists.Any())
                .OrderBy(l => l.Id)
                .Select(l => new LicenseVm
                {
                    Id = l.Id,
                    Name = l.Name,
                    Url = l.Url,
                    PermitsModification = l.PermitsModification,
                    PermitsDistribution = l.PermitsDistribution,
                    PermitsCommercialUse = l.PermitsCommercialUse,
                    FilterListIds = l.FilterLists
                        .OrderBy(f => f.Id)
                        .Select(f => f.Id)
                })
                .TagWith(nameof(GetLicenses))
        );

    public sealed record Request : IStreamRequest<LicenseVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, LicenseVm>
    {
        public async IAsyncEnumerable<LicenseVm> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var license in Query(ctx).WithCancellation(ct)) yield return license;
        }
    }

    [PublicAPI]
    public record LicenseVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>5</example>
        public int Id { get; init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>All Rights Reserved</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://en.wikipedia.org/wiki/All_rights_reserved</example>
        public Uri? Url { get; init; }

        /// <summary>
        ///     If the License permits modification.
        /// </summary>
        /// <example>false</example>
        public bool PermitsModification { get; init; }

        /// <summary>
        ///     If the License permits distribution.
        /// </summary>
        /// <example>false</example>
        public bool PermitsDistribution { get; init; }

        /// <summary>
        ///     If the License permits commercial use.
        /// </summary>
        /// <example>false</example>
        public bool PermitsCommercialUse { get; init; }

        /// <summary>
        ///     The identifiers of the FilterLists released under this License.
        /// </summary>
        /// <example>[ 6, 31 ]</example>
        public IEnumerable<int> FilterListIds { get; init; } = [];
    }
}