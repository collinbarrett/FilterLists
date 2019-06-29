using System.Collections.Generic;
using System.Linq;
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
            private const int MaxDegreeOfParallelism = 20; //TODO: tune
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
                var orderedListInfo = ShardByHost(request.ListInfo);
                foreach (var list in orderedListInfo)
                    await downloader.SendAsync(list, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
            }

            //https://keestalkstech.com/2017/10/linq-round-robin-ordering-based-segments/
            private static IEnumerable<ListInfo> ShardByHost(IEnumerable<ListInfo> listInfo)
            {
                return listInfo.GroupBy(l => l.ViewUrl.Host)
                    .SelectMany((g, gi) => g.Select((l, li) => new {Index = li, GroupIndex = gi, Value = l}))
                    .OrderBy(u => u.Index)
                    .ThenBy(u => u.GroupIndex)
                    .Select(u => u.Value);
            }
        }
    }
}