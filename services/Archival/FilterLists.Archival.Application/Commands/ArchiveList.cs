using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Application.Models;
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
            private readonly IDirectoryApi _directory;
            private readonly HttpClient _httpClient;
            private readonly ILogger _logger;

            public Handler(
                IFileArchiver archiver,
                IDirectoryApi directory,
                IHttpClientFactory httpClientFactory,
                ILogger<Handler> logger)
            {
                _archiver = archiver;
                _directory = directory;
                _httpClient = httpClientFactory.CreateClient();
                _logger = logger;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _ = request ?? throw new ArgumentNullException(nameof(request));
                _logger.LogDebug("Archiving list {ListId}", request.ListId);

                var segments = await GetSegmentsAsync(request.ListId, cancellationToken);
                if (segments.Count > 0)
                {
                    var fetchTasks = segments.Select(s => FetchStreamAsync(s.Url, cancellationToken));
                    var streams = await Task.WhenAll(fetchTasks);
                    var target = new FileInfo(Uri.UnescapeDataString(segments.First().Url.Segments.Last()));
                    await _archiver.ArchiveFileAsync(new FileToArchive(target, streams), cancellationToken);
                    _archiver.Commit();

                    _logger.LogDebug(
                        "Archived segments {@SegmentNumbers} of list {ListId}",
                        segments.Select(s => s.SegmentNumber),
                        request.ListId);
                }
                else
                {
                    _logger.LogInformation("List {ListId} has no view URLs to archive", request.ListId);
                }

                return Unit.Value;
            }

            private async Task<List<ListDetailsViewUrlVm>> GetSegmentsAsync(
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

            private async Task<Stream> FetchStreamAsync(
                Uri url,
                CancellationToken cancellationToken)
            {
                using var response = await _httpClient.GetAsync(url, cancellationToken);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStreamAsync();
            }
        }
    }
}
