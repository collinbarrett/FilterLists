using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Entities;
using MediatR;

namespace FilterLists.Agent.ListArchiver
{
    public static class DownloadLists
    {
        public class Command : IRequest
        {
            public Command(IEnumerable<ListInfo> lists)
            {
                Lists = lists;
            }

            public IEnumerable<ListInfo> Lists { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const int MaxDegreeOfParallelism = 50;
            private readonly IMediator _mediator;

            public Handler(IMediator mediator)
            {
                _mediator = mediator;
            }

            // https://stackoverflow.com/a/22492731/2343739
            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var downloader = new TransformBlock<ListInfo, Task>(
                    l => _mediator.Send(new DownloadList.Command(l), cancellationToken),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism});
                var buffer = new BufferBlock<Task>();
                downloader.LinkTo(buffer);
                foreach (var list in request.Lists)
                    await downloader.SendAsync(list, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
                if (buffer.TryReceiveAll(out var tasks))
                    await Task.WhenAll(tasks);
            }
        }
    }
}