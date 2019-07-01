using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Entities;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;

namespace FilterLists.Agent.Features.Archiver
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
            private const string RepoDirectory = @"archives";
            private readonly HttpClient _httpClient;

            public Handler(AgentHttpClient httpClient)
            {
                _httpClient = httpClient.Client;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var sourceExtension = request.ListInfo.ViewUrl.GetExtension();
                var destinationExtension = string.IsNullOrEmpty(sourceExtension) ? ".txt" : sourceExtension;
                var destinationPath = Path.Combine(RepoDirectory, $"{request.ListInfo.Id}{destinationExtension}");
                using (var response = await _httpClient.GetAsync(request.ListInfo.ViewUrl, cancellationToken))
                {
                    if (response.IsSuccessStatusCode)
                        using (var input = await response.Content.ReadAsStreamAsync())
                        using (var output = File.OpenWrite(destinationPath))
                        {
                            await input.CopyToAsync(output, cancellationToken);
                        }
                }
            }
        }
    }
}