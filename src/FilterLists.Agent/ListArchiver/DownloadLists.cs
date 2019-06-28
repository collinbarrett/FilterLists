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
            public Command(IEnumerable<ListInfo> listInfo)
            {
                ListInfo = listInfo;
            }

            public IEnumerable<ListInfo> ListInfo { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            //TODO: sort lists and use domain sharding for concurrent downloads 
            //TODO: manual/auto-tune degrees of parallelism
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
                foreach (var list in request.ListInfo)
                    await downloader.SendAsync(list, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
            }
        }
    }
}