using System;
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

            private static readonly Dictionary<string, Func<ListInfo, IRequest>> CommandsByExtension
                = new Dictionary<string, Func<ListInfo, IRequest>>
                {
                    {"", l => new DownloadRawText.Command(l)},
                    //{".7z", l => new DownloadRawText.Command(l)},
                    {".acl", l => new DownloadRawText.Command(l)},
                    {".action", l => new DownloadRawText.Command(l)},
                    {".all", l => new DownloadRawText.Command(l)},
                    {".aspx", l => new DownloadRawText.Command(l)},
                    {".bat", l => new DownloadRawText.Command(l)},
                    {".blacklist", l => new DownloadRawText.Command(l)},
                    {".conf", l => new DownloadRawText.Command(l)},
                    {".csv", l => new DownloadRawText.Command(l)},
                    {".dat", l => new DownloadRawText.Command(l)},
                    {".deny", l => new DownloadRawText.Command(l)},
                    {".host", l => new DownloadRawText.Command(l)},
                    {".hosts", l => new DownloadRawText.Command(l)},
                    {".ips", l => new DownloadRawText.Command(l)},
                    {".ipset", l => new DownloadRawText.Command(l)},
                    {".json", l => new DownloadRawText.Command(l)},
                    {".list", l => new DownloadRawText.Command(l)},
                    {".lsrules", l => new DownloadRawText.Command(l)},
                    {".netset", l => new DownloadRawText.Command(l)},
                    {".p2p", l => new DownloadRawText.Command(l)},
                    {".php", l => new DownloadRawText.Command(l)},
                    {".tpl", l => new DownloadRawText.Command(l)},
                    {".txt", l => new DownloadRawText.Command(l)},
                    //{".zip", l => new DownloadRawText.Command(l)}
                };

            private readonly IMediator _mediator;

            public Handler(IMediator mediator)
            {
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var downloader = new ActionBlock<ListInfo>(
                    async l =>
                    {
                        var extension = l.ViewUrl.GetExtension();
                        if (CommandsByExtension.ContainsKey(extension))
                        {
                            var command = CommandsByExtension[extension].Invoke(l);
                            await _mediator.Send(command, cancellationToken);
                        }
                    },
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