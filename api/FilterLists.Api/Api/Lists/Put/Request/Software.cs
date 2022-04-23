using System;

namespace FilterLists.Api.Api.Lists.Put.Request;

public record Software
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? DownloadUrl { get; init; }
    public bool SupportsAbpUrlScheme { get; init; }
}