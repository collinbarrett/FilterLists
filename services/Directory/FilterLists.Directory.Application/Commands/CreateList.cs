using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Licenses;
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
        ///     The view URLs.
        /// </summary>
        public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();

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
        public long? LicenseId { get; init; }

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
        public Validator()
        {
            RuleFor(c => c.LicenseId)
                .GreaterThan(0)
                .When(c => c.LicenseId != null);
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

            var filterList = FilterList.CreatePendingApproval(
                request.Name,
                request.Description,
                license,
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
                request.CreateReason);
            _commandContext.FilterLists.Add(filterList);

            await _commandContext.SaveChangesAsync(cancellationToken);

            return new Response
            {
                ChangeId =
                    filterList.Changes.Single()
                        .Id
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
