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
            private readonly IMediator _mediator;

            public Handler(IDirectoryApi directory, IMediator mediator)
            {
                _directory = directory;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var lists = await _directory.GetListsAsync(cancellationToken);
                foreach (var list in lists)
                {
                    _mediator.Enqueue(new ArchiveList.Command(list.Id));
                }

                return Unit.Value;
            }
        }
    }
}
