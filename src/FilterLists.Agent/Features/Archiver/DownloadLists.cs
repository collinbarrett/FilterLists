using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Extensions;
using MediatR;

namespace FilterLists.Agent.Features.Archiver
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
            private readonly IMediator _mediator;

            public Handler(IMediator mediator)
            {
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var downloader = new ActionBlock<ListInfo>(
                    async l => await _mediator.Send(new DownloadList.Command(l), cancellationToken),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
                var orderedListInfo = request.ListInfo.DistributeByHost();
                foreach (var listInfo in orderedListInfo)
                    await downloader.SendAsync(listInfo, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
            }
        }
    }
}