using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;

//TODO:  upsert into MariaDB Rules table https://stackoverflow.com/questions/15271202/mysql-load-data-infile-with-on-duplicate-key-update

namespace FilterLists.Agent.Features.Archiver
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
            private static readonly Dictionary<string, FileType> DownloadRequestsByFileExtension
                = new Dictionary<string, FileType>
                {
                    {"", FileType.RawText},
                    {".7z", FileType.NonForwardOnlyCompressed},
                    {".acl", FileType.RawText},
                    {".action", FileType.RawText},
                    {".all", FileType.RawText},
                    {".aspx", FileType.RawText},
                    {".bat", FileType.RawText},
                    {".blacklist", FileType.RawText},
                    {".conf", FileType.RawText},
                    {".csv", FileType.RawText},
                    {".dat", FileType.RawText},
                    {".deny", FileType.RawText},
                    {".host", FileType.RawText},
                    {".hosts", FileType.RawText},
                    {".ips", FileType.RawText},
                    {".ipset", FileType.RawText},
                    {".json", FileType.RawText},
                    {".list", FileType.RawText},
                    {".lsrules", FileType.RawText},
                    {".netset", FileType.RawText},
                    {".p2p", FileType.RawText},
                    {".php", FileType.RawText},
                    {".tpl", FileType.RawText},
                    {".txt", FileType.RawText},
                    {".zip", FileType.ForwardOnlyCompressed}
                };

            private readonly HttpClient _httpClient;

            public Handler(AgentHttpClient httpClient)
            {
                _httpClient = httpClient.Client;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                using (var response = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                {
                    if (response.IsSuccessStatusCode)
                        using (var input = await response.Content.ReadAsStreamAsync())
                        {
                            var sourceExtension = Path.GetExtension(request.ListInfo.ViewUrl.AbsolutePath);
                            string destinationExtension;
                            if (string.IsNullOrEmpty(sourceExtension) || sourceExtension == ".zip" || sourceExtension == ".7z")
                                destinationExtension = ".txt";
                            else
                                destinationExtension = sourceExtension;

                            using (var output = File.OpenWrite(Path.Combine("archives", $"{request.ListInfo.Id}{destinationExtension}")))
                            {
                                switch (DownloadRequestsByFileExtension[sourceExtension])
                                {
                                    case FileType.RawText:
                                        await input.CopyToAsync(output, cancellationToken);
                                        break;
                                    case FileType.ForwardOnlyCompressed:
                                        await input.CopyToWithCompressedReaderApi(output, cancellationToken);
                                        break;
                                    case FileType.NonForwardOnlyCompressed:
                                        input.CopyToWithCompressedArchiveApi(output);
                                        break;
                                    default:
                                        throw new NotImplementedException();
                                }
                            }
                        }
                }
            }
        }
    }
}