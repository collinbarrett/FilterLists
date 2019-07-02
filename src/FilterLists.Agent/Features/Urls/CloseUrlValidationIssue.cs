using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;
using Octokit;

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
            private readonly IAgentGitHubClient _gitHubClient;

            public Handler(IAgentGitHubClient agentGitHubClient)
            {
                _gitHubClient = agentGitHubClient;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var issue = await GetOpenIssueOrNull();
                if (issue is null)
                    return;
                var updateIssue = issue.ToUpdate();
                updateIssue.State = ItemState.Closed;
                updateIssue.Body = issue.Body +
                                   "<h1>Update:</h1>This issue is being closed since all URLs seem to now be valid.";
                await _gitHubClient.UpdateIssue(issue.Number, updateIssue);
            }

            private async Task<Issue> GetOpenIssueOrNull()
            {
                var issueRequest = new RepositoryIssueRequest
                {
                    Filter = IssueFilter.All,
                    State = ItemStateFilter.Open,
                    Labels = {AgentBotLabel}
                };
                return (await _gitHubClient.GetAllIssues(issueRequest)).FirstOrDefault();
            }
        }
    }
}