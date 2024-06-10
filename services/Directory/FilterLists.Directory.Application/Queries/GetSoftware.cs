using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetSoftware
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Software
                .Where(s => s.SoftwareSyntaxes
                    .Any(ss => ss.Syntax.FilterListSyntaxes.Any()))
                .OrderBy(s => s.Id)
                .Select(s => new Response
                (
                    s.Id,
                    s.Name,
                    s.Description,
                    s.HomeUrl,
                    s.DownloadUrl,
                    s.SupportsAbpUrlScheme,
                    s.SoftwareSyntaxes
                        .OrderBy(ss => ss.SyntaxId)
                        .Select(ss => ss.SyntaxId)
                ))
                .TagWith(nameof(GetSoftware))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var software in cache.GetOrCreateAsyncEnumerable(
                                   nameof(GetSoftware),
                                   Query(ctx).WithCancellation(ct))
                               .WithCancellation(ct))
                yield return software;
        }
    }

    /// <param name="Id" example="2">The identifier.</param>
    /// <param name="Name" example="Adblock Plus">The unique name.</param>
    /// <param name="Description"
    ///     example="Adblock Plus is a free extension that allows you to customize your web experience...">
    ///     The description.
    /// </param>
    /// <param name="HomeUrl" example="https://adblockplus.org/">The URL of the home page.</param>
    /// <param name="DownloadUrl" example="https://adblockplus.org/">The URL of the Software download.</param>
    /// <param name="SupportsAbpUrlScheme" example="true">
    ///     If the Software supports the abp: URL scheme to click-to-subscribe to a FilterList.
    /// </param>
    /// <param name="SyntaxIds" example="[ 3, 28, 38, 48 ]">The identifiers of the Syntaxes that this Software supports.</param>
    [PublicAPI]
    public sealed record Response(
        long Id,
        string Name,
        string? Description,
        Uri? HomeUrl,
        Uri? DownloadUrl,
        bool SupportsAbpUrlScheme,
        IEnumerable<short> SyntaxIds);
}