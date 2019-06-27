using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using MediatR;

namespace FilterLists.Agent.ListArchiver
{
    public static class CaptureList
    {
        public class Command : IRequest
        {
            public Command(ListInfo listInfo)
            {
                ListInfo = listInfo;
            }

            public ListInfo ListInfo { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly HttpClient _httpClient;

            public Handler(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
            }
        }
    }
}