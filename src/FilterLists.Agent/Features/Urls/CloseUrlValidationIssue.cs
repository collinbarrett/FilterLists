using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.GitHub;
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
            private readonly IIssuesRepository _repo;

            public Handler(IIssuesRepository issuesRepository)
            {
                _repo = issuesRepository;
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
                await _repo.UpdateIssueAsync(issue.Number, updateIssue);
            }

            private async Task<Issue> GetOpenIssueOrNull()
            {
                var issueRequest = new RepositoryIssueRequest
                {
                    Filter = IssueFilter.All,
                    State = ItemStateFilter.Open,
                    Labels = {AgentBotLabel}
                };
                return (await _repo.GetAllIssuesAsync(issueRequest)).FirstOrDefault();
            }
        }
    }
}