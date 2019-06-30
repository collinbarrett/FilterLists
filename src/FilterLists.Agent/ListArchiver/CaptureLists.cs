using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Infrastructure;
using MediatR;

namespace FilterLists.Agent.ListArchiver
{
    public static class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IFilterListsApiClient _apiClient;
            private readonly IMediator _mediator;

            public Handler(IFilterListsApiClient apiClient, IMediator mediator)
            {
                _apiClient = apiClient;
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var lists = await _apiClient.GetListInfo();
                await _mediator.Send(new DownloadLists.Command(lists), cancellationToken);
                await _mediator.Send(new CommitDownloadedLists.Command(), cancellationToken);
            }
        }
    }
}