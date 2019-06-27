using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Entities;
using FilterLists.Agent.Infrastructure;
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
            private const int MaxDegreeOfParallelism = 50;
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
                await DownloadLists(lists, cancellationToken);
            }

            private async Task<IEnumerable<ListInfo>> GetListInfo()
            {
                var listsRequest = new RestRequest("lists");
                return await _apiClient.ExecuteAsync<IEnumerable<ListInfo>>(listsRequest);
            }

            private async Task DownloadLists(IEnumerable<ListInfo> lists, CancellationToken cancellationToken)
            {
                var downloader = new TransformBlock<ListInfo, Task>(
                    l => _mediator.Send(new DownloadList.Command(l), cancellationToken),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism});
                foreach (var list in lists)
                    await downloader.SendAsync(list, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
            }
        }
    }
}