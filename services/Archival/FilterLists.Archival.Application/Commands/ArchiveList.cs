using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Application.Models;
using FilterLists.Archival.Infrastructure.Clients;
using FilterLists.Archival.Infrastructure.Persistence;
using FilterLists.SharedKernel.Apis.Clients;
using FilterLists.SharedKernel.Apis.Contracts.Directory;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Archival.Application.Commands
{
    public static class ArchiveList
    {
        public class Command : IRequest
        {
            public Command(int listId)
            {
                ListId = listId;
            }

            public int ListId { get; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFileArchiver _archiver;
            private readonly IFileClient _client;
            private readonly IDirectoryApi _directory;
            private readonly ILogger _logger;

            public Handler(
                IFileArchiver archiver,
                IFileClient fileClient,
                IDirectoryApi directory,
                ILogger<Handler> logger)
            {
                _archiver = archiver;
                _client = fileClient;
                _directory = directory;
                _logger = logger;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _ = request ?? throw new ArgumentNullException(nameof(request));
                _logger.LogDebug("Archiving list {ListId}", request.ListId);

                var segmentUrls = await GetSegmentUrlsAsync(request.ListId, cancellationToken);
                if (segmentUrls.Count > 0)
                {
                    var file = await GetFileAsync(request.ListId, segmentUrls, cancellationToken);
                    await _archiver.ArchiveFileAsync(file, cancellationToken);
                    _archiver.Commit();

                    _logger.LogDebug(
                        "Archived segments {@SegmentNumbers} of list {ListId}",
                        segmentUrls.Select(s => s.SegmentNumber),
                        request.ListId);
                }
                else
                {
                    _logger.LogInformation("List {ListId} has no URLs to archive", request.ListId);
                }

                return Unit.Value;
            }

            private async Task<List<ListDetailsViewUrlVm>> GetSegmentUrlsAsync(
                int listId,
                CancellationToken cancellationToken)
            {
                var listDetails = await _directory.GetListDetailsAsync(listId, cancellationToken);
                return listDetails.ViewUrls?
                           .GroupBy(u => u.SegmentNumber)
                           .Select(g => g.OrderBy(u => u.Primariness))
                           .FirstOrDefault()
                           ?.ToList() ??
                       new List<ListDetailsViewUrlVm>();
            }

            private async Task<FileToArchive> GetFileAsync(
                int listId,
                IReadOnlyCollection<ListDetailsViewUrlVm> segmentUrls,
                CancellationToken cancellationToken)
            {
                var contentsAsync = GetContentsAsync(segmentUrls, cancellationToken);
                var sourceFileName = Uri.UnescapeDataString(segmentUrls.First().Url.Segments.Last());
                var sourceExtension = Path.GetExtension(sourceFileName);
                var target = new FileInfo($"{listId}.txt");
                return new FileToArchive(sourceExtension, await contentsAsync, target);
            }

            // TODO: IAsyncEnumerable?
            private async Task<IEnumerable<Stream>> GetContentsAsync(
                IEnumerable<ListDetailsViewUrlVm> segmentUrls,
                CancellationToken cancellationToken)
            {
                var downloads = new List<Task<Stream>>();
                foreach (var segment in segmentUrls)
                {
                    downloads.Add(_client.DownloadFileAsync(segment.Url, cancellationToken));
                }

                return await Task.WhenAll(downloads);
            }
        }
    }
}
