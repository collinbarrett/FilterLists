using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetMaintainers
{
    public class Query(QueryDbContext ctx)
    {
        public async Task<List<Response>> ExecuteAsync(CancellationToken ct)
        {
            return await ctx.Maintainers
                .Where(m => m.FilterListMaintainers.Any())
                .OrderBy(m => m.Id)
                .Select(m => new Response(
                    m.Id,
                    m.Name,
                    m.Url,
                    m.EmailAddress,
                    m.TwitterHandle
                ))
                .TagWith(nameof(GetMaintainers))
                .ToListAsync(ct);
        }
    }

    /// <param name="Id" example="7">The identifier.</param>
    /// <param name="Name" example="The EasyList Authors">The unique name.</param>
    /// <param name="Url" example="https://easylist.to/">The URL of the home page.</param>
    /// <param name="EmailAddress" example="null">The email address.</param>
    /// <param name="TwitterHandle" example="null">The Twitter handle.</param>
    public sealed record Response(
        int Id,
        string Name,
        Uri? Url,
        string? EmailAddress,
        string? TwitterHandle);
}