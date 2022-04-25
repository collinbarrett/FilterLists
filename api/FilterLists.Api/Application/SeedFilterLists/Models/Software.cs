namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Software
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public string? HomeUrl { get; init; }
    public string? DownloadUrl { get; init; }
    public bool SupportsAbpUrlScheme { get; init; }
}