using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Features.Urls.Models.DataFileUrls;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateAllUrls
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IMediator _mediator;
            private readonly IUrlRepository _repo;

            public Handler(IMediator mediator, IUrlRepository urlRepository)
            {
                _mediator = mediator;
                _repo = urlRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var results = new List<DataFileUrlValidationResults>();

                var licenseUrls = await _repo.GetAllAsync<LicenseUrls>();
                var licenseUrlErrors = await _mediator.Send(new ValidateUrls.Command(licenseUrls), cancellationToken);
                if (licenseUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("License.json", licenseUrlErrors));

                var listUrls = await _repo.GetAllAsync<ListUrls>();
                var listUrlErrors = await _mediator.Send(new ValidateUrls.Command(listUrls), cancellationToken);
                if (listUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("FilterList.json", listUrlErrors));

                var maintainerUrls = await _repo.GetAllAsync<MaintainerUrls>();
                var maintainerUrlErrors = await _mediator.Send(new ValidateUrls.Command(maintainerUrls), cancellationToken);
                if (maintainerUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Maintainer.json", maintainerUrlErrors));

                var softwareUrls = await _repo.GetAllAsync<SoftwareUrls>();
                var softwareUrlErrors = await _mediator.Send(new ValidateUrls.Command(softwareUrls), cancellationToken);
                if (softwareUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Software.json", softwareUrlErrors));

                var syntaxUrls = await _repo.GetAllAsync<SyntaxUrls>();
                var syntaxUrlErrors = await _mediator.Send(new ValidateUrls.Command(syntaxUrls), cancellationToken);
                if (syntaxUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Syntax.json", syntaxUrlErrors));

                if(results.Any())
                    await _mediator.Send(new CreateOrUpdateUrlValidationIssue.Command(results), cancellationToken);
                await _mediator.Send(new CloseUrlValidationIssue.Command(), cancellationToken);
            }
        }
    }
}