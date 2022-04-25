namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Syntax
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public string? Url { get; init; }
}