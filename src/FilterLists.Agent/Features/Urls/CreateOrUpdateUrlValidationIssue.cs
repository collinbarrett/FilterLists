using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.GitHub;
using FilterLists.Agent.Core.Urls;
using MediatR;
using Octokit;

namespace FilterLists.Agent.Features.Urls
{
    public static class CreateOrUpdateUrlValidationIssue
    {
        public class Command : IRequest
        {
            public Command(IEnumerable<EntityUrl> invalidEntityUrls)
            {
                InvalidEntityUrls = invalidEntityUrls;
            }

            public IEnumerable<EntityUrl> InvalidEntityUrls { get; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private const string AgentBotLabel = "agent bot";
            private const string HelpWantedLabel = "help wanted";
            private const string DataLabel = "data";
            private const string IssueTitle = "BOT: url validation errors";
            private readonly IMediator _mediator;
            private readonly IIssuesRepository _repo;

            public Handler(IIssuesRepository issuesRepository, IMediator mediator)
            {
                _repo = issuesRepository;
                _mediator = mediator;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var issue = await GetOpenIssueOrNull() ?? await CreateBaseIssue();
                await UpdateIssue(issue, request.InvalidEntityUrls, cancellationToken);
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

            private async Task<Issue> CreateBaseIssue()
            {
                var newIssue = new NewIssue(IssueTitle);
                return await _repo.CreateIssueAsync(newIssue);
            }

            private async Task UpdateIssue(Issue issue, IEnumerable<EntityUrl> invalidEntityUrls,
                CancellationToken cancellationToken)
            {
                var updateIssue = issue.ToUpdate();
                updateIssue.AddLabel(HelpWantedLabel);
                updateIssue.AddLabel(AgentBotLabel);
                updateIssue.AddLabel(DataLabel);
                updateIssue.Body = await _mediator.Send(new BuildGitHubIssueBody.Command(invalidEntityUrls),
                    cancellationToken);
                await _repo.UpdateIssueAsync(issue.Number, updateIssue);
            }
        }
    }
}