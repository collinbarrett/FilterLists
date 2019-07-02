using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;
using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Common;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadSevenZip
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
            private const string RepoDirectory = "archives";
            private readonly HttpClient _httpClient;

            public Handler(AgentHttpClient agentHttpClient)
            {
                _httpClient = agentHttpClient.Client;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var destinationDirectoryPath = Path.Combine(RepoDirectory, $"{request.ListInfo.Id}");
                using (var response = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                {
                    if (response.IsSuccessStatusCode)
                        using (var input = await response.Content.ReadAsStreamAsync())
                        using (var archive = SevenZipArchive.Open(input))
                        {
                            foreach (var entry in archive.Entries)
                                if (!entry.IsDirectory)
                                    entry.WriteToDirectory(destinationDirectoryPath,
                                        new ExtractionOptions {ExtractFullPath = true, Overwrite = true});
                        }
                }
            }
        }
    }
}