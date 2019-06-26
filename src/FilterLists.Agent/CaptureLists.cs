using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestSharp;

namespace FilterLists.Agent
{
    public class CaptureLists
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IRestClient _restClient;

            public Handler(IRestClient restClient)
            {
                _restClient = restClient;
            }

            protected override Task Handle(Command request, CancellationToken cancellationToken)
            {
                return Task.CompletedTask;
            }
        }
    }
}