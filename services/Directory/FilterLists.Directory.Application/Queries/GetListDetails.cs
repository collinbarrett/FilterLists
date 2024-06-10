using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Application.Queries;

public static class GetListDetails
{
    private static readonly Func<QueryDbContext, int, Task<Response?>> Query =
        EF.CompileAsyncQuery((QueryDbContext ctx, int id) =>
            ctx.FilterLists
                .Select(f => new Response
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
                    ViewUrls = f.ViewUrls
                        .OrderBy(u => u.SegmentNumber)
                        .ThenBy(u => u.Primariness)
                        .Select(u => new ViewUrlResponse
                        (
                            u.SegmentNumber,
                            u.Primariness,
                            u.Url
                        )),
                    HomeUrl = f.HomeUrl,
                    OnionUrl = f.OnionUrl,
                    PolicyUrl = f.PolicyUrl,
                    SubmissionUrl = f.SubmissionUrl,
                    IssuesUrl = f.IssuesUrl,
                    ForumUrl = f.ForumUrl,
                    ChatUrl = f.ChatUrl,
                    EmailAddress = f.EmailAddress,
                    DonateUrl = f.DonateUrl,
                    MaintainerIds = f.FilterListMaintainers
                        .OrderBy(fm => fm.MaintainerId)
                        .Select(fm => fm.MaintainerId),
                    UpstreamFilterListIds = f.UpstreamFilterLists
                        .OrderBy(ff => ff.UpstreamFilterListId)
                        .Select(ff => ff.UpstreamFilterListId),
                    ForkFilterListIds = f.ForkFilterLists
                        .OrderBy(ff => ff.ForkFilterListId)
                        .Select(ff => ff.ForkFilterListId),
                    IncludedInFilterListIds = f.IncludedInFilterLists
                        .OrderBy(fm => fm.IncludedInFilterListId)
                        .Select(fm => fm.IncludedInFilterListId),
                    IncludesFilterListIds = f.IncludesFilterLists
                        .OrderBy(fm => fm.IncludesFilterListId)
                        .Select(fm => fm.IncludesFilterListId),
                    DependencyFilterListIds = f.DependencyFilterLists
                        .OrderBy(fd => fd.DependencyFilterListId)
                        .Select(fd => fd.DependencyFilterListId),
                    DependentFilterListIds = f.DependentFilterLists
                        .OrderBy(fd => fd.DependentFilterListId)
                        .Select(fd => fd.DependentFilterListId)
                })
                .TagWith(nameof(GetListDetails))
                .SingleOrDefault(f => f.Id == id));

    public sealed record Request(int Id) : IRequest<Response?>;

    [UsedImplicitly]
    private sealed class Handler(QueryDbContext ctx, IMemoryCache cache) : IRequestHandler<Request, Response?>
    {
        public Task<Response?> Handle(Request request, CancellationToken _)
        {
            return cache.GetOrCreateAsync($"{nameof(GetListDetails)}_{request.Id}", entry => Query(ctx, request.Id));
        }
    }

    // TODO: refactor to primary ctor syntax while allowing EF Core query compilation to succeed
    [PublicAPI]
    public sealed record Response
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
        ///     The view URLs.
        /// </summary>
        public IEnumerable<ViewUrlResponse> ViewUrls { get; init; } = [];

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://easylist.to/</example>
        public Uri? HomeUrl { get; init; }

        /// <summary>
        ///     The URL of the Tor / Onion page.
        /// </summary>
        /// <example>null</example>
        public Uri? OnionUrl { get; init; }

        /// <summary>
        ///     The URL of the policy/guidelines for the types of rules this FilterList includes.
        /// </summary>
        /// <example>null</example>
        public Uri? PolicyUrl { get; init; }

        /// <summary>
        ///     The URL of the submission/contact form for adding rules to this FilterList.
        /// </summary>
        /// <example>null</example>
        public Uri? SubmissionUrl { get; init; }

        /// <summary>
        ///     The URL of the GitHub Issues page.
        /// </summary>
        /// <example>https://github.com/easylist/easylist/issues</example>
        public Uri? IssuesUrl { get; init; }

        /// <summary>
        ///     The URL of the forum page.
        /// </summary>
        /// <example>https://forums.lanik.us/viewforum.php?f=23</example>
        public Uri? ForumUrl { get; init; }

        /// <summary>
        ///     The URL of the chat room.
        /// </summary>
        /// <example>null</example>
        public Uri? ChatUrl { get; init; }

        /// <summary>
        ///     The email address at which the project can be contacted.
        /// </summary>
        /// <example>easylist@protonmail.com</example>
        public string? EmailAddress { get; init; }

        /// <summary>
        ///     The URL at which donations to the project can be made.
        /// </summary>
        /// <example>null</example>
        public Uri? DonateUrl { get; init; }

        /// <summary>
        ///     The identifiers of the Maintainers of this FilterList.
        /// </summary>
        /// <example>[ 7 ]</example>
        public IEnumerable<int> MaintainerIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists from which this FilterList was forked.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<int> UpstreamFilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists that have been forked from this FilterList.
        /// </summary>
        /// <example>[ 166, 565 ]</example>
        public IEnumerable<int> ForkFilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists that include this FilterList.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<int> IncludedInFilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists that this FilterList includes.
        /// </summary>
        /// <example>[ 11, 13, 168 ]</example>
        public IEnumerable<int> IncludesFilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists that this FilterList depends upon.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<int> DependencyFilterListIds { get; init; } = [];

        /// <summary>
        ///     The identifiers of the FilterLists dependent upon this FilterList.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<int> DependentFilterListIds { get; init; } = [];
    }

    /// <param name="SegmentNumber" example="1">The segment number of the URL for the FilterList (for multi-part lists).</param>
    /// <param name="Primariness" example="1">
    ///     How primary the URL is for the FilterList segment (1 is original, 2+ is a mirror;
    ///     unique per SegmentNumber)
    /// </param>
    /// <param name="Url" example="https://easylist.to/easylist/easylist.txt">The view URL.</param>
    [PublicAPI]
    public sealed record ViewUrlResponse(short SegmentNumber, short Primariness, Uri Url);
}