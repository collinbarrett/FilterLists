namespace FilterLists.Archival.Infrastructure.Options
{
    internal class GitOptions
    {
        public const string Key = nameof(Key);

        public string RepositoryDirectory { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
    }
}