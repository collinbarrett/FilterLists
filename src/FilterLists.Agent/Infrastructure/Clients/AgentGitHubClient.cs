using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Interfaces.Clients;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Octokit;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public class AgentGitHubClient : IAgentGitHubClient
    {
        private readonly IGitHubClient _gitHubClient;
        private readonly GitHubSettings _gitHubSettings;
        private readonly IStringLocalizer<AgentGitHubClient> _localizer;
        private readonly ILogger<AgentGitHubClient> _logger;

        public AgentGitHubClient(IGitHubClient gitHubClient, IOptions<GitHubSettings> gitHubOptions,
            IStringLocalizer<AgentGitHubClient> stringLocalizer, ILogger<AgentGitHubClient> logger)
        {
            _gitHubClient = gitHubClient;
            _gitHubSettings = gitHubOptions.Value;
            _localizer = stringLocalizer;
            _logger = logger;
        }

        public async Task<IReadOnlyList<Issue>> GetAllIssues(RepositoryIssueRequest repositoryIssueRequest)
        {
            try
            {
                return await _gitHubClient.Issue.GetAllForRepository(_gitHubSettings.RepositoryOwner,
                    _gitHubSettings.Repository, repositoryIssueRequest);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, _localizer["Failed getting all Issues from the GitHub API."]);
                throw;
            }
        }

        public async Task<Issue> CreateIssue(NewIssue newIssue)
        {
            try
            {
                return await _gitHubClient.Issue.Create(_gitHubSettings.RepositoryOwner, _gitHubSettings.Repository,
                    newIssue);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, _localizer["Failed creating Issue with the GitHub API."]);
                throw;
            }
        }

        public async Task<Issue> UpdateIssue(int issueNumber, IssueUpdate issueUpdate)
        {
            try
            {
                return await _gitHubClient.Issue.Update(_gitHubSettings.RepositoryOwner, _gitHubSettings.Repository,
                    issueNumber, issueUpdate);
            }
            catch (ApiException ex)
            {
                _logger.LogError(ex, _localizer["Failed updating Issue with the GitHub API."]);
                throw;
            }
        }
    }
}