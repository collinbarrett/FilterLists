using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetSyntaxes
{
    public sealed record Request : IRequest<List<Response>>;

    private sealed class Handler(QueryDbContext ctx, HybridCache cache) : IRequestHandler<Request, List<Response>>
    {
        public async Task<List<Response>> Handle(Request request, CancellationToken ct)
        {
            const string key = nameof(GetSyntaxes);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Syntaxes
                        .Where(s => s.FilterListSyntaxes.Any())
                        .OrderBy(s => s.Id)
                        .Select(s => new Response
                        (
                            s.Id,
                            s.Name,
                            s.Description,
                            s.Url,
                            s.FilterListSyntaxes
                                .OrderBy(fs => fs.FilterListId)
                                .Select(fs => fs.FilterListId),
                            s.SoftwareSyntaxes
                                .OrderBy(ss => ss.SoftwareId)
                                .Select(ss => ss.SoftwareId)
                        ))
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
        }
    }

    /// <param name="Id" example="3">The identifier.</param>
    /// <param name="Name" example="Adblock Plus">The unique name.</param>
    /// <param name="Description" example="null">The description.</param>
    /// <param name="Url" example="https://adblockplus.org/filters">The URL of the home page.</param>
    /// <param name="FilterListIds" example="[ 2, 6, 11 ]">The identifiers of the FilterLists implementing this Syntax.</param>
    /// <param name="SoftwareIds" example="[ 1, 2, 3 ]">The identifiers of the Software that supports this Syntax.</param>
    public sealed record Response(
        short Id,
        string Name,
        string? Description,
        Uri? Url,
        IEnumerable<int> FilterListIds,
        IEnumerable<short> SoftwareIds);
}