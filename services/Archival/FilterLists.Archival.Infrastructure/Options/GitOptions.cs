namespace FilterLists.Archival.Infrastructure.Options;

internal class GitOptions
{
    public const string Key = "Git";

    public string RepositoryPath { get; init; } = null!;
    public string UserName { get; init; } = null!;
    public string UserEmail { get; init; } = null!;
}
