using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core;
using FilterLists.Agent.Core.List;
using MediatR;
using Microsoft.Extensions.Logging;
using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Common;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadSevenZip
    {
        public class Command : IRequest
        {
            public Command(ListUrl listUrl)
            {
                ListUrl = listUrl;
            }

            public ListUrl ListUrl { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const string RepoDirectory = "archives";
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(IListRepository listRepository, ILogger<Handler> logger)
            {
                _httpClient = listRepository.HttpClient;
                _logger = logger;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var destinationDirectoryPath = Path.Combine(RepoDirectory, $"{request.ListUrl.Id}");
                using (var response = await _httpClient.GetAsync(request.ListUrl.ViewUrl, cancellationToken))
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
                    else
                        _logger.LogError(
                            $"Error downloading list {request.ListUrl.Id} from {request.ListUrl.ViewUrl}. {response.StatusCode}");
                }
            }
        }
    }
}