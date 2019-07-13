using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Lists;
using FilterLists.Agent.Extensions;
using MediatR;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadRawText
    {
        public class Command : IRequest
        {
            public Command(ListViewUrl listViewUrl)
            {
                ListViewUrl = listViewUrl;
            }

            public ListViewUrl ListViewUrl { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const string RepoDirectory = "archives";
            private readonly string[] _extensionsToRewrite = {"", ".aspx", ".p2p", ".php"};
            private readonly IListRepository _repo;

            public Handler(IListRepository listRepository)
            {
                _repo = listRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var destinationPath = BuildDestinationPath(request);
                using var input = await _repo.GetAsStreamAsync(request.ListViewUrl.ViewUrl, cancellationToken);
                using var output = File.OpenWrite(destinationPath);
                await input.CopyToAsync(output, cancellationToken);
            }

            private string BuildDestinationPath(Command request)
            {
                var sourceExtension = request.ListViewUrl.ViewUrl.GetExtension();
                var destinationExtension = _extensionsToRewrite.Contains(sourceExtension) ? ".txt" : sourceExtension;
                var destinationPath = Path.Combine(RepoDirectory, $"{request.ListViewUrl.Id}{destinationExtension}");
                return destinationPath;
            }
        }
    }
}