namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Merge
{
    public long IncludedInFilterListId { get; init; }
    public long IncludesFilterListId { get; init; }
}