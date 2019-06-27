using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using FilterLists.Agent.Infrastructure;
using MediatR;
using RestSharp;

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
                var lists = await GetListInfo();
                await _mediator.Send(new DownloadLists.Command(lists), cancellationToken);
                //TODO: git add .
                //TODO: git commit
            }

            private async Task<IEnumerable<ListInfo>> GetListInfo()
            {
                var listsRequest = new RestRequest("lists");
                return await _apiClient.ExecuteAsync<IEnumerable<ListInfo>>(listsRequest);
            }
        }
    }
}