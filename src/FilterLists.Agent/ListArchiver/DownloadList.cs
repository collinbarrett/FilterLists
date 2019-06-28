using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using FilterLists.Agent.Entities.Aggregates;
using FilterLists.Agent.ListArchiver.DownloadRequestsByFileExtension;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.ListArchiver
{
    public static class DownloadList
    {
        public class Command : IRequest
        {
            public Command(ListDownload listDownload)
            {
                ListDownload = listDownload;
            }

            public ListDownload ListDownload { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private static readonly Dictionary<string, Func<ListDownload, IRequest>> DownloadRequestsByFileExtension
                = new Dictionary<string, Func<ListDownload, IRequest>>
                {
                    {"", l => new DownloadTxt.Command(l)},
                    {".7z", l => throw new NotImplementedException()},
                    {".acl", l => throw new NotImplementedException()},
                    {".action", l => throw new NotImplementedException()},
                    {".all", l => throw new NotImplementedException()},
                    {".aspx", l => throw new NotImplementedException()},
                    {".bat", l => throw new NotImplementedException()},
                    {".blacklist", l => throw new NotImplementedException()},
                    {".conf", l => throw new NotImplementedException()},
                    {".csv", l => throw new NotImplementedException()},
                    {".dat", l => throw new NotImplementedException()},
                    {".deny", l => throw new NotImplementedException()},
                    {".host", l => throw new NotImplementedException()},
                    {".hosts", l => throw new NotImplementedException()},
                    {".ips", l => throw new NotImplementedException()},
                    {".ipset", l => throw new NotImplementedException()},
                    {".json", l => throw new NotImplementedException()},
                    {".list", l => throw new NotImplementedException()},
                    {".lsrules", l => throw new NotImplementedException()},
                    {".netset", l => throw new NotImplementedException()},
                    {".p2p", l => throw new NotImplementedException()},
                    {".php", l => throw new NotImplementedException()},
                    {".tpl", l => throw new NotImplementedException()},
                    {".txt", l => new DownloadTxt.Command(l)},
                    {".zip", l => throw new NotImplementedException()}
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
                try
                {
                    var extension = Path.GetExtension(request.ListDownload.ListInfo.ViewUrl.AbsolutePath);
                    if (DownloadRequestsByFileExtension.ContainsKey(extension))
                    {
                        _logger.LogInformation(
                            $"Downloading list {request.ListDownload.ListInfo.Id} from {request.ListDownload.ListInfo.ViewUrl}...");
                        await _mediator.Send(DownloadRequestsByFileExtension[extension].Invoke(request.ListDownload),
                            cancellationToken);
                    }
                    else
                    {
                        _logger.LogWarning(
                            $"File extension not recognized for list {request.ListDownload.ListInfo.Id} from {request.ListDownload.ListInfo.ViewUrl}.");
                    }

                    //TODO:  upsert into MariaDB Rules table https://stackoverflow.com/questions/15271202/mysql-load-data-infile-with-on-duplicate-key-update
                }
                catch (NotImplementedException)
                {
                    _logger.LogWarning(
                        $"File extension not supported for list {request.ListDownload.ListInfo.Id} from {request.ListDownload.ListInfo.ViewUrl}.");
                }
                catch (ArgumentException ex)
                {
                    _logger.LogError(ex,
                        $"Could not determine the file extension for list {request.ListDownload.ListInfo.Id} from {request.ListDownload.ListInfo.ViewUrl}.");
                }
            }
        }
    }
}