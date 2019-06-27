using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
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
            private readonly HttpClient _httpClient;

            public Handler(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                if (Path.GetExtension(request.ListInfo.ViewUrl.AbsolutePath) == ".txt")
                {
                    Debug.WriteLine($"Downloading list {request.ListInfo.Id}...");
                    try
                    {
                        using (var result = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                        {
                            if (result.IsSuccessStatusCode)
                                using (Stream output =
                                    File.OpenWrite(Path.Combine("archives", $"{request.ListInfo.Id}.txt")))
                                using (var input = await result.Content.ReadAsStreamAsync())
                                {
                                    input.CopyTo(output);
                                }
                        }
                    }
                    catch (HttpRequestException)
                    {
                    }
                }
            }
        }
    }
}