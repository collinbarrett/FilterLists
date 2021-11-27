using System.ComponentModel;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Commands;

public static class CreateList
{
    public record Command(
        [property: DefaultValue("EasyList")] string Name,
        IEnumerable<FilterListViewUrl> ViewUrls,
        [property: DefaultValue("EasyList is the primary filter list that removes most adverts from international web pages, including unwanted frames, images, and objects. It is the most popular list used by many ad blockers and forms the basis of over a dozen combination and supplementary filter lists.")] string? Description = default,
        [property: DefaultValue(4)] long? LicenseId = default,
        [property: DefaultValue("https://easylist.to/")] Uri? HomeUrl = default,
        [property: DefaultValue(default(Uri))] Uri? OnionUrl = default,
        [property: DefaultValue(default(Uri))] Uri? PolicyUrl = default,
        [property: DefaultValue(default(Uri))] Uri? SubmissionUrl = default,
        [property: DefaultValue("https://github.com/easylist/easylist/issues")] Uri? IssuesUrl = default,
        [property: DefaultValue("https://forums.lanik.us/viewforum.php?f=23")] Uri? ForumUrl = default,
        [property: DefaultValue(default(Uri))] Uri? ChatUrl = default,
        [property: DefaultValue("easylist@protonmail.com")] string? EmailAddress = default,
        [property: DefaultValue(default(Uri))] Uri? DonateUrl = default,
        [property: DefaultValue("Adding EasyList because I did not see it on FilterLists.com yet.")] string? CreateReason = default) : IRequest<Response>;

    public record FilterListViewUrl(
        [property: DefaultValue(1)] short SegmentNumber,
        [property: DefaultValue(1)] short Primariness,
        [property: DefaultValue("https://easylist.to/easylist/easylist.txt")] Uri Url);

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

            return new Response(filterList.Changes.Single().Id);
        }
    }

    public record Response(long ChangeId) { }
}
