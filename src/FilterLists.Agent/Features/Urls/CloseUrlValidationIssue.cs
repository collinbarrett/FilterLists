using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class CloseUrlValidationIssue
    {
        public class Command : IRequest
        {
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const string AgentBotLabel = "agent bot";
            private const string IssueTitle = "Url Validation Errors";
            private readonly IAgentGitHubClient _gitHubClient;

            public Handler(IAgentGitHubClient agentGitHubClient)
            {
                _gitHubClient = agentGitHubClient;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
            }
        }
    }
}