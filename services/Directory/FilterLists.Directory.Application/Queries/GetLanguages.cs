using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetLanguages
{
    public class Query(QueryDbContext ctx, HybridCache cache)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            const string key = nameof(GetLanguages);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Languages
                        .Where(l => l.FilterListLanguages.Any())
                        .OrderBy(l => l.Iso6391)
                        .Select(l => new Response(
                            l.Id,
                            l.Iso6391,
                            l.Name,
                            l.FilterListLanguages
                                .OrderBy(fl => fl.FilterListId)
                                .Select(fl => fl.FilterListId)
                        ))
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
        }
    }

    /// <param name="Id" example="37">The identifier.</param>
    /// <param name="Iso6391" example="en">The unique ISO 639-1 code.</param>
    /// <param name="Name" example="English">The unique ISO name.</param>
    /// <param name="FilterListIds" example="[ 114, 141 ]">The identifiers of the FilterLists targeted by this Language.</param>
    public sealed record Response(short Id, string Iso6391, string Name, IEnumerable<int> FilterListIds);
}