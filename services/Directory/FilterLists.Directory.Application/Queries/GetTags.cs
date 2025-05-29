using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetTags
{
    public sealed record Request : IRequest<List<Response>>;

    private sealed class Handler(QueryDbContext ctx, HybridCache cache) : IRequestHandler<Request, List<Response>>
    {
        public async Task<List<Response>> Handle(Request request, CancellationToken ct)
        {
            const string key = nameof(GetTags);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Tags
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
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
        }
    }

    /// <param name="Id" example="2">The identifier.</param>
    /// <param name="Name" example="ads">The unique name.</param>
    /// <param name="Description" example="Blocks advertisements">The description.</param>
    /// <param name="FilterListIds" example="[ 1, 3, 6 ]">The identifiers of the FilterLists to which this Tag is applied.</param>
    public sealed record Response(int Id, string Name, string? Description, IEnumerable<int> FilterListIds);
}