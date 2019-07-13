using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Lists;
using MediatR;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace FilterLists.Agent.Features.Lists
{
    public static class DownloadZip
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
            private readonly IListRepository _repo;

            public Handler(IListRepository listRepository)
            {
                _repo = listRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var destinationDirectoryPath = Path.Combine(RepoDirectory, $"{request.ListViewUrl.Id}");
                using var input = await _repo.GetAsStreamAsync(request.ListViewUrl.ViewUrl, cancellationToken);
                using var reader = ReaderFactory.Open(input);
                while (reader.MoveToNextEntry())
                    if (!reader.Entry.IsDirectory)
                        reader.WriteEntryToDirectory(destinationDirectoryPath,
                            new ExtractionOptions {ExtractFullPath = true, Overwrite = true});
            }
        }
    }
}