using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Urls;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateAllUrls
    {
        public class Command : IRequest
        {
        }


        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly IMediator _mediator;
            private readonly IEntityUrlRepository _repo;

            public Handler(IMediator mediator, IEntityUrlRepository entityUrlRepository)
            {
                _mediator = mediator;
                _repo = entityUrlRepository;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var entityUrls = await _repo.GetAllAsync(cancellationToken);
                var validatedEntityUrls = await _mediator.Send(new ValidateUrls.Command(entityUrls), cancellationToken);
                var invalidEntityUrls = validatedEntityUrls.Where(e => !e.IsValid()).ToList();
                if (invalidEntityUrls.Any())
                    await _mediator.Send(new CreateOrUpdateUrlValidationIssue.Command(invalidEntityUrls),
                        cancellationToken);
                else
                    await _mediator.Send(new CloseUrlValidationIssue.Command(), cancellationToken);
            }
        }
    }
}