using JetBrains.Annotations;

namespace FilterLists.Agent.AppSettings
{
    public class GitHubSettings
    {
        public string ProductHeaderValue { get; [UsedImplicitly] set; }
        public string PersonalAccessToken { get; [UsedImplicitly] set; }
        public string RepositoryOwner { get; [UsedImplicitly] set; }
        public string Repository { get; [UsedImplicitly] set; }
    }
}