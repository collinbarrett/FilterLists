using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Core.Lists;
using FilterLists.Agent.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadLists
    {
        public class Command : IRequest
        {
            public Command(IEnumerable<ListViewUrl> listInfo)
            {
                ListInfo = listInfo;
            }

            public IEnumerable<ListViewUrl> ListInfo { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const int MaxDegreeOfParallelism = 5;

            private static readonly Dictionary<string, Func<ListViewUrl, IRequest>> CommandsByExtension
                = new Dictionary<string, Func<ListViewUrl, IRequest>>
                {
                    {"", l => new DownloadRawText.Command(l)},
                    {".7z", l => new DownloadSevenZip.Command(l)},
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
                    {".zip", l => new DownloadZip.Command(l)}
                };

            private readonly ILogger<Handler> _logger;
            private readonly IMediator _mediator;

            public Handler(ILogger<Handler> logger, IMediator mediator)
            {
                _logger = logger;
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var downloader = BuildDownloader(cancellationToken);
                var orderedListInfo = request.ListInfo;
                foreach (var listInfo in orderedListInfo)
                    await downloader.SendAsync(listInfo, cancellationToken);
                downloader.Complete();
                await downloader.Completion;
            }

            private ActionBlock<ListViewUrl> BuildDownloader(CancellationToken cancellationToken)
            {
                return new ActionBlock<ListViewUrl>(
                    async l =>
                    {
                        var errorMessage = $"Error downloading list {l.Id} from {l.ViewUrl}.";
                        var extension = l.ViewUrl.GetExtension();
                        if (CommandsByExtension.ContainsKey(extension))
                        {
                            var command = CommandsByExtension[extension].Invoke(l);
                            try
                            {
                                await _mediator.Send(command, cancellationToken);
                            }
                            catch (HttpRequestException ex)
                            {
                                _logger.LogError(ex, errorMessage);
                            }
                            catch (TaskCanceledException ex)
                            {
                                _logger.LogError(ex, errorMessage);
                            }
                        }
                        else
                        {
                            _logger.LogError($"The file extension of list {l.Id} from {l.ViewUrl} is not supported.");
                        }
                    },
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }
        }
    }
}