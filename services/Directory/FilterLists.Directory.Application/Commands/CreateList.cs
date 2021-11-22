using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Commands;

public static class CreateList
{
    public record Command(string Name,
        IEnumerable<FilterListViewUrl> ViewUrls,
        string? Description = default,
        int? LicenseId = default,
        Uri? HomeUrl = default,
        Uri? OnionUrl = default,
        Uri? PolicyUrl = default,
        Uri? SubmissionUrl = default,
        Uri? IssuesUrl = default,
        Uri? ForumUrl = default,
        Uri? ChatUrl = default,
        string? EmailAddress = default,
        Uri? DonateUrl = default,
        string? CreateReason = default) : IRequest<Response>;

    public record FilterListViewUrl(short SegmentNumber, short Primariness, Uri Url);

    internal class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(c => c.LicenseId)
                .GreaterThanOrEqualTo(0)
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

            return new Response();
        }
    }

    public record Response
    {
    }
}
