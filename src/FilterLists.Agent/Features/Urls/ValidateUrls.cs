using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Core.Interfaces.Services;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
    {
        public class Command : IRequest<List<UrlValidationResult>>
        {
            public Command(IEnumerable<Uri> urls)
            {
                Urls = urls;
            }

            public IEnumerable<Uri> Urls { get; }
        }

        public class Handler : IRequestHandler<Command, List<UrlValidationResult>>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly IUrlService _urlService;

            public Handler(IUrlService urlService)
            {
                _urlService = urlService;
            }

            public async Task<List<UrlValidationResult>> Handle(Command request, CancellationToken cancellationToken)
            {
                var validator = BuildValidator(cancellationToken);
                var brokenUrls = new List<UrlValidationResult>();
                var distinctUrls = request.Urls.Distinct().DistributeByHost();
                foreach (var url in distinctUrls)
                    await validator.SendAsync(url, cancellationToken);
                validator.Complete();
                while (await validator.OutputAvailableAsync(cancellationToken))
                {
                    var result = await validator.ReceiveAsync(cancellationToken);
                    if (!result.IsValid())
                        brokenUrls.Add(result);
                }

                await validator.Completion;
                return brokenUrls;
            }

            private TransformBlock<Uri, UrlValidationResult> BuildValidator(CancellationToken cancellationToken)
            {
                return new TransformBlock<Uri, UrlValidationResult>(
                    async u => await _urlService.ValidateAsync(u, cancellationToken),
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }
        }
    }
}