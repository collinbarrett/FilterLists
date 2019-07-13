using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Lists;
using MediatR;

namespace FilterLists.Agent.Features.Lists
{
    public static class ArchiveLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IMediator _mediator;
            private readonly IListViewUrlRepository _repo;

            public Handler(IMediator mediator, IListViewUrlRepository listViewUrlRepository)
            {
                _mediator = mediator;
                _repo = listViewUrlRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var lists = await _repo.GetAllAsync(cancellationToken);
                await _mediator.Send(new DownloadLists.Command(lists), cancellationToken);
                await _mediator.Send(new CommitLists.Command(), cancellationToken);
            }
        }
    }
}