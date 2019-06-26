using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestSharp;

namespace FilterLists.Agent
{
    public class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IFilterListsApiClient apiClient;

            public Handler(IFilterListsApiClient apiClient) => this.apiClient = apiClient;

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var listsRequest = new RestRequest("lists");
                var restResponse = await apiClient.ExecuteAsync<IEnumerable<FilterListDto>>(listsRequest);
            }
        }
    }
}