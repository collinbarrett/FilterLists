using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Hybrid;

namespace FilterLists.Directory.Application.Queries;

public static class GetSoftware
{
    public sealed record Request : IRequest<List<Response>>;

    private sealed class Handler(QueryDbContext ctx, HybridCache cache) : IRequestHandler<Request, List<Response>>
    {
        public async Task<List<Response>> Handle(Request request, CancellationToken ct)
        {
            const string key = nameof(GetSoftware);
            return await cache.GetOrCreateAsync(
                key,
                async cancel =>
                    await ctx.Software
                        .Where(s => s.SoftwareSyntaxes.Any(ss => ss.Syntax.FilterListSyntaxes.Any()))
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
                        .TagWith(key)
                        .ToListAsync(cancel),
                cancellationToken: ct);
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
    public sealed record Response(
        long Id,
        string Name,
        string? Description,
        Uri? HomeUrl,
        Uri? DownloadUrl,
        bool SupportsAbpUrlScheme,
        IEnumerable<short> SyntaxIds);
}