using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetMaintainers
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<MaintainerVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Maintainers
                .Where(m => m.FilterListMaintainers.Any())
                .OrderBy(m => m.Id)
                .Select(m => new MaintainerVm
                {
                    Id = m.Id,
                    Name = m.Name,
                    Url = m.Url,
                    EmailAddress = m.EmailAddress,
                    TwitterHandle = m.TwitterHandle,
                    FilterListIds = m.FilterListMaintainers
                        .OrderBy(fm => fm.FilterListId)
                        .Select(fm => fm.FilterListId)
                })
                .TagWith(nameof(GetMaintainers))
        );

    public sealed record Request : IStreamRequest<MaintainerVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, MaintainerVm>
    {
        public async IAsyncEnumerable<MaintainerVm> Handle(Request request,
            [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var maintainer in Query(ctx).WithCancellation(ct)) yield return maintainer;
        }
    }

    [PublicAPI]
    public record MaintainerVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>7</example>
        public int Id { get; init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>The EasyList Authors</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://easylist.to/</example>
        public Uri? Url { get; init; }

        /// <summary>
        ///     The email address.
        /// </summary>
        /// <example>null</example>
        public string? EmailAddress { get; init; }

        /// <summary>
        ///     The Twitter handle.
        /// </summary>
        /// <example>null</example>
        public string? TwitterHandle { get; init; }

        /// <summary>
        ///     The identifiers of the FilterLists maintained by this Maintainer.
        /// </summary>
        /// <example>[ 11, 13, 301 ]</example>
        public IEnumerable<int> FilterListIds { get; init; } = [];
    }
}