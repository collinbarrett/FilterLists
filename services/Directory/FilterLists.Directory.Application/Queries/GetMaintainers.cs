using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetMaintainers
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Maintainers
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
                .TagWith(nameof(GetMaintainers))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var maintainer in cache.GetOrCreateAsyncEnumerable(
                                   nameof(GetMaintainers),
                                   Query(ctx).WithCancellation(ct))
                               .WithCancellation(ct))
                yield return maintainer;
        }
    }

    /// <param name="Id" example="7">The identifier.</param>
    /// <param name="Name" example="The EasyList Authors">The unique name.</param>
    /// <param name="Url" example="https://easylist.to/">The URL of the home page.</param>
    /// <param name="EmailAddress" example="null">The email address.</param>
    /// <param name="TwitterHandle" example="null">The Twitter handle.</param>
    /// <param name="FilterListIds" example="[ 11, 13, 301 ]">The identifiers of the FilterLists maintained by this Maintainer.</param>
    [PublicAPI]
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        string? EmailAddress,
        string? TwitterHandle,
        IEnumerable<int> FilterListIds);
}