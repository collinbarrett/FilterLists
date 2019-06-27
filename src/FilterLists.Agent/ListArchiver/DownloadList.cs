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
                    {".7z", l => new DownloadTxt.Command(l)},
                    {".acl", l => new DownloadTxt.Command(l)},
                    {".action", l => new DownloadTxt.Command(l)},
                    {".all", l => new DownloadTxt.Command(l)},
                    {".aspx", l => new DownloadTxt.Command(l)},
                    {".bat", l => new DownloadTxt.Command(l)},
                    {".blacklist", l => new DownloadTxt.Command(l)},
                    {".conf", l => new DownloadTxt.Command(l)},
                    {".csv", l => new DownloadTxt.Command(l)},
                    {".dat", l => new DownloadTxt.Command(l)},
                    {".deny", l => new DownloadTxt.Command(l)},
                    {".host", l => new DownloadTxt.Command(l)},
                    {".hosts", l => new DownloadTxt.Command(l)},
                    {".ips", l => new DownloadTxt.Command(l)},
                    {".ipset", l => new DownloadTxt.Command(l)},
                    {".json", l => new DownloadTxt.Command(l)},
                    {".list", l => new DownloadTxt.Command(l)},
                    {".lsrules", l => new DownloadTxt.Command(l)},
                    {".netset", l => new DownloadTxt.Command(l)},
                    {".p2p", l => new DownloadTxt.Command(l)},
                    {".php", l => new DownloadTxt.Command(l)},
                    {".tpl", l => new DownloadTxt.Command(l)},
                    {".txt", l => new DownloadTxt.Command(l)},
                    {".zip", l => new DownloadTxt.Command(l)}
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
                    //TODO:  upsert into MariaDB Rules table https://stackoverflow.com/questions/15271202/mysql-load-data-infile-with-on-duplicate-key-update
                }
                catch (ArgumentException)
                {
                    //TODO: log
                }
            }
        }
    }
}