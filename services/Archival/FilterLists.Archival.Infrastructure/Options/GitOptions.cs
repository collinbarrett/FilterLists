namespace FilterLists.Archival.Infrastructure.Options;

internal record GitOptions
{
    public const string Key = "Git";

    public string RepositoryPath { get; init; } = default!;
    public string UserName { get; init; } = default!;
    public string UserEmail { get; init; } = default!;
}
