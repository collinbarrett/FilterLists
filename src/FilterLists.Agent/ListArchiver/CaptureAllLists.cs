using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Infrastructure;
using FilterLists.Agent.ListArchiver.Events;
using MediatR;
using RestSharp;

namespace FilterLists.Agent.ListArchiver
{
    public static class CaptureAllLists
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
                var listsRequest = new RestRequest("lists");
                var filterLists = await _apiClient.ExecuteAsync<IEnumerable<FilterList>>(listsRequest);
                foreach (var filterList in filterLists)
                    await _mediator.Publish(new ListReadyForCapture(filterList), cancellationToken);
            }
        }
    }
}