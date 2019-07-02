using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class CreateOrUpdateGitHubIssue
    {
        public class Command : IRequest
        {
            public Command(IEnumerable<DataFileUrlValidationResults> dataFileUrlValidationResults)
            {
                DataFileUrlValidationResults = dataFileUrlValidationResults;
            }

            public IEnumerable<DataFileUrlValidationResults> DataFileUrlValidationResults { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}