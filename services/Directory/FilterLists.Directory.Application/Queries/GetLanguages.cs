using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLanguages
{
    public class Query(QueryDbContext ctx)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            return await ctx.Languages
                .Where(l => l.FilterListLanguages.Any())
                .OrderBy(l => l.Iso6391)
                .Select(l => new Response(
                    l.Id,
                    l.Iso6391,
                    l.Name
                ))
                .TagWith(nameof(GetLanguages))
                .ToListAsync(ct);
        }
    }

    /// <param name="Id" example="37">The identifier.</param>
    /// <param name="Iso6391" example="en">The unique ISO 639-1 code.</param>
    /// <param name="Name" example="English">The unique ISO name.</param>
    public sealed record Response(short Id, string Iso6391, string Name);
}