using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace FilterLists.Agent
{
    public class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            protected override Task Handle(Command request, CancellationToken cancellationToken) => Task.CompletedTask;
        }
    }
}