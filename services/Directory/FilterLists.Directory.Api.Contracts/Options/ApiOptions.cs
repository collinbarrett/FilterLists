namespace FilterLists.Directory.Api.Contracts.Options;

internal record ApiOptions
{
    public const string Key = "Api";

    public string DirectoryHost { get; init; } = null!;
}
