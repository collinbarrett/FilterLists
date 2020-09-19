using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Archival.Infrastructure.Scheduling;
using FilterLists.SharedKernel.Apis.Clients;
using MediatR;

namespace FilterLists.Archival.Application.Commands
{
    public static class EnqueueArchiveAllLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IDirectoryApi _directory;

            public Handler(IDirectoryApi directory)
            {
                _directory = directory;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var r = new Random();
                var lists = (await _directory.GetListsAsync(cancellationToken)).OrderBy(_ => r.Next()).ToList();

                int numToArchive;
#if DEBUG
                numToArchive = 25;
#else
                numToArchive = lists.Count;
#endif

                for (var i = 0; i < numToArchive; i++)
                {
                    new ArchiveList.Command(lists[i].Id).EnqueueBackgroundJob();
                }

                return Unit.Value;
            }
        }
    }
}
