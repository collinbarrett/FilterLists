using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
                    var file = GetFileToArchive(request.ListId, segmentUrls, cancellationToken);
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
                           .GroupBy(u => u.SegmentNumber, (_, g) => g.OrderBy(e => e.Primariness).First())
                           ?.ToList() ??
                       new List<ListDetailsViewUrlVm>();
            }

            private IFileToArchive GetFileToArchive(
                int listId,
                IEnumerable<ListDetailsViewUrlVm> segmentUrls,
                CancellationToken cancellationToken)
            {
                var segmentsAsync = GetSegmentsAsync(segmentUrls, cancellationToken);
                var target = new FileInfo($"{listId.ToString(CultureInfo.InvariantCulture).PadLeft(5, '0')}.txt");
                return new FileToArchive(segmentsAsync, target);
            }

            private async IAsyncEnumerable<IFileToArchiveSegment> GetSegmentsAsync(
                IEnumerable<ListDetailsViewUrlVm> segmentUrls,
                [EnumeratorCancellation] CancellationToken cancellationToken)
            {
                foreach (var segment in segmentUrls) 
                {
                    var sourceFileName = Uri.UnescapeDataString(segment.Url.Segments.Last());
                    var sourceExtension = Path.GetExtension(sourceFileName);
                    yield return new FileToArchiveSegment(
                        sourceExtension,
                        await _client.DownloadFileAsync(segment.Url, cancellationToken));
                }
            }
        }
    }
}
