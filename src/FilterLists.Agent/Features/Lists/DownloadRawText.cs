using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadRawText
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
            private readonly string[] _extensionsToRewrite = {"", ".aspx", ".p2p", ".php"};
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(AgentHttpClient agentHttpClient, ILogger<Handler> logger)
            {
                _httpClient = agentHttpClient.Client;
                _logger = logger;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var sourceExtension = request.ListInfo.ViewUrl.GetExtension();
                var destinationExtension = _extensionsToRewrite.Contains(sourceExtension) ? ".txt" : sourceExtension;
                var destinationPath = Path.Combine(RepoDirectory, $"{request.ListInfo.Id}{destinationExtension}");
                using (var response = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                {
                    if (response.IsSuccessStatusCode)
                        using (var input = await response.Content.ReadAsStreamAsync())
                        using (var output = File.OpenWrite(destinationPath))
                        {
                            await input.CopyToAsync(output, cancellationToken);
                        }
                    else
                        _logger.LogError(
                            $"Error downloading list {request.ListInfo.Id} from {request.ListInfo.ViewUrl}. {response.StatusCode}");
                }
            }
        }
    }
}