using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.ListArchiver.DownloadRequestsByFileExtension
{
    public static class DownloadTxt
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
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(AgentHttpClient httpClient, ILogger<Handler> logger)
            {
                _httpClient = httpClient.Client;
                _logger = logger;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    using (var response = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                    {
                        if (response.IsSuccessStatusCode)
                            using (Stream output =
                                File.OpenWrite(Path.Combine("archives", $"{request.ListInfo.Id}.txt")))
                            using (var input = await response.Content.ReadAsStreamAsync())
                            {
                                input.CopyTo(output);
                            }
                    }
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogError(ex,
                        $"Error downloading list {request.ListInfo.Id} from {request.ListInfo.ViewUrl}.");
                }
                catch (TaskCanceledException ex)
                {
                    _logger.LogError(ex,
                        $"Error downloading list {request.ListInfo.Id} from {request.ListInfo.ViewUrl}.");
                }
            }
        }
    }
}