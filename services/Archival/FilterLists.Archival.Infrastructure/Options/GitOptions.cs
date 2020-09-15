namespace FilterLists.Archival.Infrastructure.Options
{
    internal class GitOptions
    {
        public const string Key = "Git";

        public string RepositoryPath { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
    }
}
