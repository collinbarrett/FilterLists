using System.Runtime.CompilerServices;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLists
{
    private static readonly Func<QueryDbContext, IAsyncEnumerable<ListVm>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx) =>
            ctx.FilterLists
                .OrderBy(f => f.Id)
                .Select(f => new ListVm
                {
                    Id = f.Id,
                    Name = f.Name,
                    Description = f.Description,
                    LicenseId = f.LicenseId,
                    SyntaxIds = f.FilterListSyntaxes
                        .OrderBy(fs => fs.SyntaxId)
                        .Select(fs => fs.SyntaxId),
                    LanguageIds = f.FilterListLanguages
                        .OrderBy(fl => fl.LanguageId)
                        .Select(fl => fl.LanguageId),
                    TagIds = f.FilterListTags
                        .OrderBy(ft => ft.TagId)
                        .Select(ft => ft.TagId),
                    PrimaryViewUrl = f.ViewUrls
                        .OrderBy(u => u.SegmentNumber)
                        .ThenBy(u => u.Primariness)
                        .Select(u => u.Url)
                        .FirstOrDefault(),
                    MaintainerIds = f.FilterListMaintainers
                        .OrderBy(fm => fm.MaintainerId)
                        .Select(fm => fm.MaintainerId)
                })
                .TagWith(nameof(GetLists))
        );

    public sealed record Request : IStreamRequest<ListVm>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx) : IStreamRequestHandler<Request, ListVm>
    {
        public async IAsyncEnumerable<ListVm> Handle(Request request, [EnumeratorCancellation] CancellationToken ct)
        {
            await foreach (var list in Query(ctx).WithCancellation(ct)) yield return list;
        }
    }

    [PublicAPI]
    public record ListVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>301</example>
        public int Id { get; init; }

        /// <summary>
        ///     The unique name in title case.
        /// </summary>
        /// <example>EasyList</example>
        public required string Name { get; init; }

        /// <summary>
        ///     The brief description in English (preferably quoted from the project).
        /// </summary>
        /// <example>
        ///     EasyList is the primary filter list that removes most adverts from international web pages, including unwanted
        ///     frames, images, and objects. It is the most popular list used by many ad blockers and forms the basis of over a
        ///     dozen combination and supplementary filter lists.
        /// </example>
        public string? Description { get; init; }

        /// <summary>
        ///     The identifier of the License under which this FilterList is released.
        /// </summary>
        /// <example>4</example>
        public int LicenseId { get; init; }

        /// <summary>
        ///     The identifiers of the Syntaxes implemented by this FilterList.
        /// </summary>
        /// <example>[ 3 ]</example>
        public IEnumerable<short> SyntaxIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the Languages targeted by this FilterList.
        /// </summary>
        /// <example>[ 37 ]</example>
        public IEnumerable<short> LanguageIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the Tags applied to this FilterList.
        /// </summary>
        /// <example>[ 2 ]</example>
        public IEnumerable<int> TagIds { get; init; } = [];

        /// <summary>
        ///     The primary view URL.
        /// </summary>
        /// <example>https://easylist.to/easylist/easylist.txt</example>
        public Uri? PrimaryViewUrl { get; init; }

        /// <summary>
        ///     The identifiers of the Maintainers of this FilterList.
        /// </summary>
        /// <example>[ 7 ]</example>
        public IEnumerable<int> MaintainerIds { get; init; } = [];
    }
}