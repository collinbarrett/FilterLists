using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Persistence;
using FilterLists.SharedKernel.Apis.Clients;
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
            private readonly IArchiveFiles _archiver;
            private readonly IDirectoryApi _directory;
            private readonly ILogger _logger;

            public Handler(IArchiveFiles archiver, IDirectoryApi directory, ILogger<Handler> logger)
            {
                _archiver = archiver;
                _directory = directory;
                _logger = logger;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _ = request ?? throw new ArgumentNullException(nameof(request));
                _logger.LogDebug("Archiving list {ListId}", request.ListId);

                var listDetails = await _directory.GetListDetailsAsync(request.ListId, cancellationToken);
                var segments = listDetails.ViewUrls?
                    .GroupBy(u => u.SegmentNumber)
                    .Select(g => g.OrderBy(u => u.Primariness))
                    .First()
                    .ToList();

                if (segments != null)
                {
                    var archiveTasks = new List<Task>();
                    foreach (var segment in segments)
                    {
                        Stream? contents = default; // TODO: fetch list file stream
                        var path = Path.Combine(
                            listDetails.Id.ToString(CultureInfo.InvariantCulture),
                            segment.SegmentNumber.ToString(CultureInfo.InvariantCulture));
                        _logger.LogDebug("Archiving segment {SegmentNumber} of list {ListId}", segment.SegmentNumber, request.ListId);
                        archiveTasks.Add(_archiver.ArchiveFileAsync(contents, path, cancellationToken));
                    }

                    await Task.WhenAll(archiveTasks);
                    _archiver.Commit();
                    _logger.LogDebug("Archived segments {@SegmentNumbers} of list {ListId}", segments.Select(s => s.SegmentNumber), request.ListId);
                }
                else
                {
                    _logger.LogDebug("List {ListId} has no view URLs to archive", request.ListId);
                }

                return Unit.Value;
            }
        }
    }
}
