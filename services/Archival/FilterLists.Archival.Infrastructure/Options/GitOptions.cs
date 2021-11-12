namespace FilterLists.Archival.Infrastructure.Options;

internal record GitOptions
{
    public const string Key = "Git";

    public string RepositoryPath { get; init; } = null!;
    public string UserName { get; init; } = null!;
    public string UserEmail { get; init; } = null!;
}
