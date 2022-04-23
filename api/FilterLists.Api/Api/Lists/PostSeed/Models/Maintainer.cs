namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record Maintainer
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
}