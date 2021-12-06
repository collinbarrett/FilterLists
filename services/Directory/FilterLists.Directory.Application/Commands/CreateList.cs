using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Languages;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Domain.Aggregates.Maintainers;
using FilterLists.Directory.Domain.Aggregates.Syntaxes;
using FilterLists.Directory.Domain.Aggregates.Tags;
using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Commands;

public static class CreateList
{
    public record Command : IRequest<Response>
    {
        /// <summary>
        ///     The unique name in title case.
        /// </summary>
        /// <example>EasyList</example>
        public string Name { get; init; } = default!;

        /// <summary>
        ///     The brief description in English (preferably quoted from the project).
        /// </summary>
        /// <example>EasyList is the primary filter list that removes most adverts from international web pages, including unwanted frames, images, and objects. It is the most popular list used by many ad blockers and forms the basis of over a dozen combination and supplementary filter lists.</example>
        public string? Description { get; init; }

        /// <summary>
        ///     The identifier of the License under which this FilterList is released.
        /// </summary>
        /// <example>4</example>
        public long? LicenseId { get; init; }

        /// <summary>
        ///     The identifiers of the Syntaxes implemented by this FilterList.
        /// </summary>
        /// <example>[ 3 ]</example>
        public IEnumerable<long> SyntaxIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the Languages targeted by this FilterList.
        /// </summary>
        /// <example>[ 37 ]</example>
        public IEnumerable<long> LanguageIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the Tags applied to this FilterList.
        /// </summary>
        /// <example>[ 2 ]</example>
        public IEnumerable<long> TagIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The view URLs.
        /// </summary>
        public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();

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
        public IEnumerable<long> MaintainerIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists from which this FilterList was forked.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<long> UpstreamFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists that have been forked from this FilterList.
        /// </summary>
        /// <example>[ 166, 565 ]</example>
        public IEnumerable<long> ForkFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists that include this FilterList.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<long> IncludedInFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists that this FilterList includes.
        /// </summary>
        /// <example>[ 11, 13, 168 ]</example>
        public IEnumerable<long> IncludesFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists that this FilterList depends upon.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<long> DependencyFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The identifiers of the FilterLists dependent upon this FilterList.
        /// </summary>
        /// <example>[]</example>
        public IEnumerable<long> DependentFilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        ///     The reason that the FilterList is being added to FilterLists.
        /// </summary>
        /// <example>Adding EasyList because I did not see it on FilterLists.com yet.</example>
        public string? CreateReason { get; init; }
    }

    public record FilterListViewUrl
    {
        /// <summary>
        ///     The segment number of the URL for the FilterList (for multi-part lists).
        /// </summary>
        /// <example>1</example>
        public short SegmentNumber { get; init; }

        /// <summary>
        ///     How primary the URL is for the FilterList segment (1 is original, 2+ is a mirror; unique per SegmentNumber)
        /// </summary>
        /// <example>1</example>
        public short Primariness { get; init; }

        /// <summary>
        ///     The view URL.
        /// </summary>
        /// <example>https://easylist.to/easylist/easylist.txt</example>
        public Uri Url { get; init; } = default!;
    }

    internal class Validator : AbstractValidator<Command>
    {
        public Validator(IValidator<long?> entityIdValidator, IValidator<Uri?> urlValidator)
        {
            RuleFor(c => c.LicenseId)
                .SetValidator(entityIdValidator);
            RuleForEach(c => c.SyntaxIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.SyntaxIds));
            RuleForEach(c => c.LanguageIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.LanguageIds));
            RuleForEach(c => c.TagIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.TagIds));
            RuleForEach(c => c.ViewUrls.Select(u => u.Url))
                .SetValidator(urlValidator)
                .OverridePropertyName(nameof(Command.ViewUrls) + "." + nameof(FilterListViewUrl.Url));
            RuleForEach(c => c.ViewUrls.Select(u => u.SegmentNumber))
                .GreaterThan((short)0)
                .OverridePropertyName(nameof(Command.ViewUrls) + "." + nameof(FilterListViewUrl.SegmentNumber));
            RuleForEach(c => c.ViewUrls.Select(u => u.Primariness))
                .GreaterThan((short)0)
                .OverridePropertyName(nameof(Command.ViewUrls) + "." + nameof(FilterListViewUrl.Primariness));
            RuleFor(c => c.HomeUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.OnionUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.PolicyUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.SubmissionUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.IssuesUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.ForumUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.ChatUrl)
                .SetValidator(urlValidator);
            RuleFor(c => c.DonateUrl)
                .SetValidator(urlValidator);
            RuleForEach(c => c.MaintainerIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.MaintainerIds));
            RuleForEach(c => c.UpstreamFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.UpstreamFilterListIds));
            RuleForEach(c => c.ForkFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.ForkFilterListIds));
            RuleForEach(c => c.IncludedInFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.IncludedInFilterListIds));
            RuleForEach(c => c.IncludesFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.IncludesFilterListIds));
            RuleForEach(c => c.DependencyFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.DependencyFilterListIds));
            RuleForEach(c => c.DependentFilterListIds.Select(id => (long?)id))
                .SetValidator(entityIdValidator)
                .OverridePropertyName(nameof(Command.DependentFilterListIds));
        }
    }

    internal class Handler : IRequestHandler<Command, Response>
    {
        private readonly ICommandContext _commandContext;

        public Handler(ICommandContext commandContext)
        {
            _commandContext = commandContext;
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            // TODO: push applying domain rule of specified or default license into domain layer?
            var license = request.LicenseId != null
                ? await _commandContext.Licenses
                      .FindAsync(new object[] { request.LicenseId.Value }, cancellationToken)
                  ?? throw new ArgumentException($"LicenseId {request.LicenseId} not found.", nameof(request.LicenseId))
                : await _commandContext.Licenses
                    .WhereIsDefaultForFilterList()
                    .SingleAsync(cancellationToken);

            var syntaxes = request.SyntaxIds.Any()
                ? await _commandContext.Syntaxes
                    .Where(s => request.SyntaxIds.Contains(s.Id))
                    .ToListAsync(cancellationToken)
                : new List<Syntax>();
            if (request.SyntaxIds.Any(sid => !syntaxes.Select(s => s.Id).Contains(sid)))
            {
                throw new ArgumentException("One or more SyntaxIds not found.", nameof(request.SyntaxIds));
            }

            var languages = request.LanguageIds.Any()
                ? await _commandContext.Languages
                    .Where(l => request.LanguageIds.Contains(l.Id))
                    .ToListAsync(cancellationToken)
                : new List<Language>();
            if (request.LanguageIds.Any(lid => !languages.Select(l => l.Id).Contains(lid)))
            {
                throw new ArgumentException("One or more LanguageIds not found.", nameof(request.LanguageIds));
            }

            var tags = request.TagIds.Any()
                ? await _commandContext.Tags
                    .Where(t => request.TagIds.Contains(t.Id))
                    .ToListAsync(cancellationToken)
                : new List<Tag>();
            if (request.TagIds.Any(tig => !tags.Select(t => t.Id).Contains(tig)))
            {
                throw new ArgumentException("One or more TagIds not found.", nameof(request.TagIds));
            }

            var maintainers = request.MaintainerIds.Any()
                ? await _commandContext.Maintainers
                    .Where(m => request.MaintainerIds.Contains(m.Id))
                    .ToListAsync(cancellationToken)
                : new List<Maintainer>();
            if (request.MaintainerIds.Any(mid => !maintainers.Select(m => m.Id).Contains(mid)))
            {
                throw new ArgumentException("One or more MaintainerIds not found.", nameof(request.MaintainerIds));
            }

            var relatedFilterListIds = request.UpstreamFilterListIds
                .Concat(request.ForkFilterListIds)
                .Concat(request.IncludedInFilterListIds)
                .Concat(request.IncludesFilterListIds)
                .Concat(request.DependencyFilterListIds)
                .Concat(request.DependentFilterListIds)
                .ToList();
            var relatedFilterLists = relatedFilterListIds.Count > 0
                ? await _commandContext.FilterLists
                    .Where(f => relatedFilterListIds.Contains(f.Id))
                    .ToListAsync(cancellationToken)
                : new List<FilterList>();
            if (request.UpstreamFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more UpstreamFilterListIds not found.", nameof(request.UpstreamFilterListIds));
            }
            if (request.ForkFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more ForkFilterListIds not found.", nameof(request.ForkFilterListIds));
            }
            if (request.IncludedInFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more IncludedInFilterListIds not found.", nameof(request.IncludedInFilterListIds));
            }
            if (request.IncludesFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more IncludesFilterListIds not found.", nameof(request.IncludesFilterListIds));
            }
            if (request.DependencyFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more DependencyFilterListIds not found.", nameof(request.DependencyFilterListIds));
            }
            if (request.DependentFilterListIds.Any(fid => !relatedFilterLists.Select(f => f.Id).Contains(fid)))
            {
                throw new ArgumentException("One or more DependentFilterListIds not found.", nameof(request.DependentFilterListIds));
            }

            var filterList = FilterList.CreatePendingApproval(
                request.Name,
                request.Description,
                license,
                syntaxes,
                languages,
                tags,
                request.ViewUrls.Select(u => (u.SegmentNumber, u.Primariness, u.Url)),
                request.HomeUrl,
                request.OnionUrl,
                request.PolicyUrl,
                request.SubmissionUrl,
                request.IssuesUrl,
                request.ForumUrl,
                request.ChatUrl,
                request.EmailAddress,
                request.DonateUrl,
                maintainers,
                relatedFilterLists.Where(f => request.UpstreamFilterListIds.Contains(f.Id)),
                relatedFilterLists.Where(f => request.ForkFilterListIds.Contains(f.Id)),
                relatedFilterLists.Where(f => request.IncludedInFilterListIds.Contains(f.Id)),
                relatedFilterLists.Where(f => request.IncludesFilterListIds.Contains(f.Id)),
                relatedFilterLists.Where(f => request.DependencyFilterListIds.Contains(f.Id)),
                relatedFilterLists.Where(f => request.DependentFilterListIds.Contains(f.Id)),
                request.CreateReason);
            _commandContext.FilterLists.Add(filterList);

            await _commandContext.SaveChangesAsync(cancellationToken);

            return new Response
            {
                ChangeId = filterList.Changes.Select(c => c.Id).Single()
            };
        }
    }

    public record Response
    {
        /// <summary>
        ///     The identifier of the Change for the new FilterList.
        /// </summary>
        /// <example>99</example>
        public long ChangeId { get; init; }
    }
}
