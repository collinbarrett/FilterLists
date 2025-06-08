using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetTags
{
    public class Query(QueryDbContext ctx)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            return await ctx.Tags
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
                .ToListAsync(ct);
        }
    }

    /// <param name="Id" example="2">The identifier.</param>
    /// <param name="Name" example="ads">The unique name.</param>
    /// <param name="Description" example="Blocks advertisements">The description.</param>
    /// <param name="FilterListIds" example="[ 1, 3, 6 ]">The identifiers of the FilterLists to which this Tag is applied.</param>
    public sealed record Response(int Id, string Name, string? Description, IEnumerable<int> FilterListIds);
}