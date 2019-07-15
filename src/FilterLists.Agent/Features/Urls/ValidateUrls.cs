using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Core.Urls;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
    {
        public class Command : IRequest<IEnumerable<EntityUrl>>
        {
            public Command(IEnumerable<EntityUrl> entityUrls)
            {
                EntityUrls = entityUrls;
            }

            public IEnumerable<EntityUrl> EntityUrls { get; }
        }


        public class Handler : IRequestHandler<Command, IEnumerable<EntityUrl>>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly IEntityUrlValidator _entityUrlValidator;

            public Handler(IEntityUrlValidator entityUrlValidator)
            {
                _entityUrlValidator = entityUrlValidator;
            }

            public async Task<IEnumerable<EntityUrl>> Handle(Command request, CancellationToken cancellationToken)
            {
                var validator = BuildValidator(cancellationToken);
                foreach (var entityUrl in request.EntityUrls)
                    await validator.SendAsync(entityUrl, cancellationToken);
                validator.Complete();
                var validatedEntityUrls = new List<EntityUrl>();
                while (await validator.OutputAvailableAsync(cancellationToken))
                    validatedEntityUrls.Add(await validator.ReceiveAsync(cancellationToken));
                await validator.Completion;
                return validatedEntityUrls;
            }

            private TransformBlock<EntityUrl, EntityUrl> BuildValidator(CancellationToken cancellationToken)
            {
                return new TransformBlock<EntityUrl, EntityUrl>(
                    e => _entityUrlValidator.ValidateAsync(e, cancellationToken),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }
        }
    }
}