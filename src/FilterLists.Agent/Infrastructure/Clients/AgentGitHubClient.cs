using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public interface IAgentGitHubClient
    {
        Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest);

        Task<Issue> CreateIssue(NewIssue newIssue);

        Task<Issue> UpdateIssue(int issueNumber, IssueUpdate updateIssue);
    }

    public class AgentGitHubClient : IAgentGitHubClient
    {
        private readonly GitHubClient _gitHubClient;
        private readonly GitHub _gitHubOptions;

        public AgentGitHubClient(IOptions<GitHub> gitHubOptions)
        {
            _gitHubOptions = gitHubOptions.Value;
            _gitHubClient = new GitHubClient(new ProductHeaderValue(_gitHubOptions.ProductHeaderValue))
            {
                Credentials = new Credentials(_gitHubOptions.PersonalAccessToken)
            };
        }

        public async Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest)
        {
            return await _gitHubClient.Issue.GetAllForRepository(_gitHubOptions.RepositoryOwner,
                _gitHubOptions.Repository, repositoryIssueRequest);
        }

        public async Task<Issue> CreateIssue(NewIssue newIssue)
        {
            return await _gitHubClient.Issue.Create(_gitHubOptions.RepositoryOwner, _gitHubOptions.Repository,
                newIssue);
        }

        public async Task<Issue> UpdateIssue(int issueNumber, IssueUpdate updateIssue)
        {
            return await _gitHubClient.Issue.Update(_gitHubOptions.RepositoryOwner, _gitHubOptions.Repository,
                issueNumber, updateIssue);
        }
    }
}