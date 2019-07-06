using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

namespace FilterLists.Agent.Core.Interfaces.Repositories
{
    public interface IGitHubIssuesRepository
    {
        Task<IReadOnlyList<Issue>> GetAllIssuesAsync(RepositoryIssueRequest repositoryIssueRequest);

        Task<Issue> CreateIssueAsync(NewIssue newIssue);

        Task<Issue> UpdateIssueAsync(int issueNumber, IssueUpdate issueUpdate);
    }
}