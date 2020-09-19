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
                var lists = await _directory.GetListsAsync(cancellationToken);
                var r = new Random();
                foreach (var list in lists.OrderBy(_ => r.Next()))
                {
                    new ArchiveList.Command(list.Id).EnqueueBackgroundJob();
                }

                return Unit.Value;
            }
        }
    }
}
