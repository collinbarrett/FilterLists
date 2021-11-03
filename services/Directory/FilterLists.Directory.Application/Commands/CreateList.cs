using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FluentValidation;
using MediatR;

namespace FilterLists.Directory.Application.Commands;

public static class CreateList
{
    public record Command(string Name,
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
        Uri? DonateUrl = default) : IRequest<Response>;

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
        private readonly IChangeRepository _changeRepo;
        private readonly ILicenseRepository _licenseRepo;

        public Handler(IChangeRepository changeRepo, ILicenseRepository licenseRepo)
        {
            _changeRepo = changeRepo;
            _licenseRepo = licenseRepo;
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var license = request.LicenseId != null
                ? await _licenseRepo.GetByIdAsync(request.LicenseId.Value, cancellationToken) ??
                  throw new ArgumentException($"LicenseId {request.LicenseId} not found.",
                      nameof(request.LicenseId))
                : null;

            var filterList = new FilterList(request.Name,
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
                request.DonateUrl);

            //Change change = null;

            //await _changeRepo.AddAsync(change, cancellationToken);
            //return new Response();

            throw new NotImplementedException();
        }
    }

    public record Response
    {
    }
}
