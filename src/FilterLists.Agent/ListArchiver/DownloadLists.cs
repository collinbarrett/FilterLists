using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Entities;
using FilterLists.Agent.Entities.Aggregates;
using MediatR;

namespace FilterLists.Agent.ListArchiver
{
    public static class DownloadLists
    {
        public class Command : IRequest
        {
            public Command(IEnumerable<ListInfo> listInfo)
            {
                ListInfo = listInfo;
            }

            public IEnumerable<ListInfo> ListInfo { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly HttpClient _httpClient;
            private readonly IMediator _mediator;

            public Handler(HttpClient httpClient, IMediator mediator)
            {
                _httpClient = httpClient;
                _mediator = mediator;
            }

            // https://stackoverflow.com/a/22492731/2343739
            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var downloader = new TransformBlock<ListInfo, ListDownload>(
                    async l => new ListDownload(l, await _httpClient.GetAsync(l.ViewUrl, cancellationToken)),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
                var buffer = new BufferBlock<ListDownload>();
                downloader.LinkTo(buffer);
                foreach (var list in request.ListInfo)
                    await downloader.SendAsync(list, cancellationToken);
                downloader.Complete();

                foreach (var _ in request.ListInfo)
                {
                    var listDownload = await buffer.ReceiveAsync(cancellationToken);
                    await _mediator.Send(new DownloadList.Command(listDownload), cancellationToken);
                    listDownload.HttpResponseMessage.Dispose();
                }

                await downloader.Completion;
            }
        }
    }
}