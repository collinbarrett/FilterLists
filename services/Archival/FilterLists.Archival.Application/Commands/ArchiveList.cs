using System;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.Apis.Clients;
using MediatR;

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
            private readonly IDirectoryApi _directory;

            public Handler(IDirectoryApi directory)
            {
                _directory = directory;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _ = request ?? throw new ArgumentNullException(nameof(request));

                var listDetails = await _directory.GetListDetailsAsync(request.ListId, cancellationToken);

                // TODO: archive

                return Unit.Value;
            }
        }
    }
}
