using System;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Core.Interfaces;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
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
                var listUrls = await _repo.GetAllAsync<ListUrls>();
                throw new NotImplementedException();
            }
        }
    }
}