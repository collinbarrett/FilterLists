using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities.Aggregates;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.ListArchiver.DownloadRequestsByFileExtension
{
    public static class DownloadTxt
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
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(ILogger<Handler> logger, HttpClient httpClient)
            {
                _logger = logger;
                _httpClient = httpClient;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    if (request.ListDownload.HttpResponseMessage.IsSuccessStatusCode)
                        using (Stream output =
                            File.OpenWrite(Path.Combine("archives", $"{request.ListDownload.ListInfo.Id}.txt")))
                        using (var input = await request.ListDownload.HttpResponseMessage.Content.ReadAsStreamAsync())
                        {
                            input.CopyTo(output);
                        }
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogError(ex,
                        $"Error downloading list {request.ListDownload.ListInfo.Id} from {request.ListDownload.ListInfo.ViewUrl}.");
                }
            }
        }
    }
}