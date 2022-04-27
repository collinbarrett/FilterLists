using System;

namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Syntax
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
}