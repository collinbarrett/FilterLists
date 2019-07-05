using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

namespace FilterLists.Agent.Core.Interfaces.Clients
{
    public interface IAgentGitHubClient
    {
        Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest);

        Task<Issue> CreateIssue(NewIssue newIssue);

        Task<Issue> UpdateIssue(int issueNumber, IssueUpdate issueUpdate);
    }
}