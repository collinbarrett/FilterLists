using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Infrastructure.Persistence.Commands.Context;
using FluentValidation;
using MediatR;

namespace FilterLists.Directory.Application.Commands;

public static class CreateList
{
    public record Command(string Name,
        ICollection<FilterListViewUrl> ViewUrls,
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
        string? ChangeReason = default) : IRequest<Response>;

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
            var license = request.LicenseId != null
                ? await _commandContext.Licenses.FindAsync(new object[] { request.LicenseId.Value },
                    cancellationToken) ?? throw new ArgumentException($"LicenseId {request.LicenseId} not found.",
                    nameof(request.LicenseId))
                : default;

            var filterList = FilterList.Create(
                request.Name,
                request.Description,
                license,
                request.HomeUrl,
                request.OnionUrl,
                request.PolicyUrl,
                request.SubmissionUrl,
                request.IssuesUrl,
                request.ForumUrl,
                request.ChatUrl,
                request.EmailAddress,
                request.DonateUrl,
                request.ViewUrls);
            _commandContext.FilterLists.Add(filterList);

            var change = Change.CreateFilterList(filterList, request.ChangeReason);
            _commandContext.Changes.Add(change);

            await _commandContext.SaveChangesAsync(cancellationToken);

            return new Response();
        }
    }

    public record Response
    {
    }
}
