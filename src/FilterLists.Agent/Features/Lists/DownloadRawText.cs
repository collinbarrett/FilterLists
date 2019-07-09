using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.List;
using FilterLists.Agent.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadRawText
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
            private readonly string[] _extensionsToRewrite = {"", ".aspx", ".p2p", ".php"};
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(IListRepository listRepository, ILogger<Handler> logger)
            {
                _httpClient = listRepository.HttpClient;
                _logger = logger;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var sourceExtension = request.ListUrl.ViewUrl.GetExtension();
                var destinationExtension = _extensionsToRewrite.Contains(sourceExtension) ? ".txt" : sourceExtension;
                var destinationPath = Path.Combine(RepoDirectory, $"{request.ListUrl.Id}{destinationExtension}");
                using (var response = await _httpClient.GetAsync(request.ListUrl.ViewUrl, cancellationToken))
                {
                    if (response.IsSuccessStatusCode)
                        using (var input = await response.Content.ReadAsStreamAsync())
                        using (var output = File.OpenWrite(destinationPath))
                        {
                            await input.CopyToAsync(output, cancellationToken);
                        }
                    else
                        _logger.LogError(
                            $"Error downloading list {request.ListUrl.Id} from {request.ListUrl.ViewUrl}. {response.StatusCode}");
                }
            }
        }
    }
}