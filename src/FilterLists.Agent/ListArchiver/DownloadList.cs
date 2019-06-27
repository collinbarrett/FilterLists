using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using FilterLists.Agent.ListArchiver.DownloadRequestsByFileExtension;
using MediatR;

namespace FilterLists.Agent.ListArchiver
{
    public static class DownloadList
    {
        public class Command : IRequest
        {
            public Command(ListInfo listInfo)
            {
                ListInfo = listInfo;
            }

            public ListInfo ListInfo { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private static readonly Dictionary<string, Func<ListInfo, IRequest>> DownloadRequestsByFileExtension
                = new Dictionary<string, Func<ListInfo, IRequest>>
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

            private readonly IMediator _mediator;

            public Handler(IMediator mediator)
            {
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var extension = Path.GetExtension(request.ListInfo.ViewUrl.AbsolutePath);
                    if (DownloadRequestsByFileExtension.ContainsKey(extension))
                        await _mediator.Send(DownloadRequestsByFileExtension[extension].Invoke(request.ListInfo),
                            cancellationToken);
                    //TODO: handle and/or log unrecognized extension
                    //TODO:  upsert into MariaDB Rules table https://stackoverflow.com/questions/15271202/mysql-load-data-infile-with-on-duplicate-key-update
                }
                catch (NotImplementedException)
                {
                    //TODO: log
                }
                catch (ArgumentException)
                {
                    //TODO: log
                }
            }
        }
    }
}