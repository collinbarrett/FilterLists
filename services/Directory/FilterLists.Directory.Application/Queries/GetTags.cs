using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetTags
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.Tags
                .Where(t => t.FilterListTags.Any())
                .OrderBy(t => t.Id)
                .Select(t => new Response
                (
                    t.Id,
                    t.Name,
                    t.Description,
                    t.FilterListTags
                        .OrderBy(flt => flt.FilterListId)
                        .Select(flt => flt.FilterListId)
                ))
                .TagWith(nameof(GetTags))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var tag in cache.GetOrCreateAsyncEnumerable(
                                   nameof(GetTags),
                                   Query(ctx).WithCancellation(ct))
                               .WithCancellation(ct))
                yield return tag;
        }
    }

    /// <param name="Id" example="2">The identifier.</param>
    /// <param name="Name" example="ads">The unique name.</param>
    /// <param name="Description" example="Blocks advertisements">The description.</param>
    /// <param name="FilterListIds" example="[ 1, 3, 6 ]">The identifiers of the FilterLists to which this Tag is applied.</param>
    [PublicAPI]
    public sealed record Response(int Id, string Name, string? Description, IEnumerable<int> FilterListIds);
}