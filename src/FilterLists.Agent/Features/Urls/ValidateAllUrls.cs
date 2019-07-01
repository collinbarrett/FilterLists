using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Features.Urls.Models;
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
            private readonly IUrlsRepository _repo;

            public Handler(IMediator mediator, IUrlsRepository urlsRepository)
            {
                _mediator = mediator;
                _repo = urlsRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var results = new List<DataFileUrlValidationResults>();

                var licenseUrls = await _repo.GetAllAsync<LicenseUrls>();
                var licenseUrlErrors = (await _mediator.Send(new ValidateUrls.Command(licenseUrls), cancellationToken)).ToList();
                if (licenseUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("License.json", licenseUrlErrors));

                var listUrls = await _repo.GetAllAsync<ListUrls>();
                var listUrlErrors = (await _mediator.Send(new ValidateUrls.Command(listUrls), cancellationToken)).ToList();
                if (listUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("FilterList.json", listUrlErrors));

                var maintainerUrls = await _repo.GetAllAsync<MaintainerUrls>();
                var maintainerUrlErrors = (await _mediator.Send(new ValidateUrls.Command(maintainerUrls), cancellationToken)).ToList();
                if (maintainerUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Maintainer.json", maintainerUrlErrors));

                var softwareUrls = await _repo.GetAllAsync<SoftwareUrls>();
                var softwareUrlErrors = (await _mediator.Send(new ValidateUrls.Command(softwareUrls), cancellationToken)).ToList();
                if (softwareUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Software.json", softwareUrlErrors));

                var syntaxUrls = await _repo.GetAllAsync<SyntaxUrls>();
                var syntaxUrlErrors = (await _mediator.Send(new ValidateUrls.Command(syntaxUrls), cancellationToken)).ToList();
                if (syntaxUrlErrors.Any())
                    results.Add(new DataFileUrlValidationResults("Syntax.json", syntaxUrlErrors));

                //TODO: create or edit GitHub issue with results
            }
        }
    }
}