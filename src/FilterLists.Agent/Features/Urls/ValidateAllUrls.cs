using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Core.Interfaces;
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
                var maintainerUrls = await _repo.GetAllAsync<MaintainerUrls>();
                var errors = await _mediator.Send(new ValidateUrls.Command(maintainerUrls), cancellationToken);

                //TODO: validate if http can be changed to https

                //TODO: iterate through each IEntityUrl impl

                //TODO: create or edit GitHub issue with results
            }
        }
    }
}