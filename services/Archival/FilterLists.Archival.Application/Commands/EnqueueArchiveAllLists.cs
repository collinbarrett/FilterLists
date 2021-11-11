using FilterLists.Archival.Infrastructure.Scheduling;
using FilterLists.Directory.Api.Contracts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Archival.Application.Commands;

public static class EnqueueArchiveAllLists
{
    public class Command : IRequest
    {
    }

    public class Handler : IRequestHandler<Command, Unit>
    {
        private readonly IDirectoryApi _directory;
        private readonly ILogger _logger;

        public Handler(IDirectoryApi directory, ILogger<Handler> logger)
        {
            _directory = directory;
            _logger = logger;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var r = new Random();
            var lists = (await _directory.GetListsAsync(cancellationToken)).OrderBy(_ => r.Next()).ToList();

            int archiveCount;
            TimeSpan spacing;
#if DEBUG
            archiveCount = 0;
            spacing = TimeSpan.FromSeconds(5);
#else
                archiveCount = 0;
                //archiveCount = lists.Count;
                spacing = TimeSpan.FromSeconds((double)86400 / lists.Count);
#endif

            _logger.LogInformation("Enqueuing archival of {ArchiveCount} lists spaced {Spacing} seconds apart.",
                archiveCount, spacing.Seconds);

            for (var i = 0; i < archiveCount; i++)
            {
                new ArchiveList.Command(lists[i].Id).ScheduleBackgroundJob(i * spacing);
            }

            return Unit.Value;
        }
    }
}
