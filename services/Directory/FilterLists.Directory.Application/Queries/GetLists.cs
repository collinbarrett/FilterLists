using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetLists
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<Response>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.FilterLists
                .OrderBy(f => f.Id)
                .Select(f => new Response
                (
                    f.Id,
                    f.Name,
                    f.Description,
                    f.LicenseId,
                    f.FilterListSyntaxes
                        .OrderBy(fs => fs.SyntaxId)
                        .Select(fs => fs.SyntaxId),
                    f.FilterListLanguages
                        .OrderBy(fl => fl.LanguageId)
                        .Select(fl => fl.LanguageId),
                    f.FilterListTags
                        .OrderBy(ft => ft.TagId)
                        .Select(ft => ft.TagId),
                    f.ViewUrls
                        .OrderBy(u => u.SegmentNumber)
                        .ThenBy(u => u.Primariness)
                        .Select(u => u.Url)
                        .FirstOrDefault(),
                    f.FilterListMaintainers
                        .OrderBy(fm => fm.MaintainerId)
                        .Select(fm => fm.MaintainerId)
                ))
                .TagWith(nameof(GetLists))
        );

    public sealed record Request : IStreamRequest<Response>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IStreamRequestHandler<Request, Response>
    {
        public async IAsyncEnumerable<Response> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var list in cache.GetOrCreateAsyncEnumerable(
                                   nameof(GetLists),
                                   Query(ctx).WithCancellation(ct))
                               .WithCancellation(ct))
                yield return list;
        }
    }

    /// <param name="Id" example="301">The identifier.</param>
    /// <param name="Name" example="EasyList">The unique name in title case.</param>
    /// <param name="Description"
    ///     example="EasyList is the primary filter list that removes most adverts from international web pages...">
    ///     The brief description in English (preferably quoted from the project).
    /// </param>
    /// <param name="LicenseId" example="4">The identifier of the License under which this FilterList is released.</param>
    /// <param name="SyntaxIds" example="[ 3 ]">The identifiers of the Syntaxes implemented by this FilterList.</param>
    /// <param name="LanguageIds" example="[ 37 ]">The identifiers of the Languages targeted by this FilterList.</param>
    /// <param name="TagIds" example="[ 2 ]">The identifiers of the Tags applied to this FilterList.</param>
    /// <param name="PrimaryViewUrl" example="https://easylist.to/easylist/easylist.txt">The primary view URL.</param>
    /// <param name="MaintainerIds" example="[ 7 ]">The identifiers of the Maintainers of this FilterList.</param>
    [PublicAPI]
    public sealed record Response(
        int Id,
        string Name,
        string? Description,
        int LicenseId,
        IEnumerable<short> SyntaxIds,
        IEnumerable<short> LanguageIds,
        IEnumerable<int> TagIds,
        Uri? PrimaryViewUrl,
        IEnumerable<int> MaintainerIds);
}