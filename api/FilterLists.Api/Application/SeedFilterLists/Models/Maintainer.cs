using System;

namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Maintainer
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
}