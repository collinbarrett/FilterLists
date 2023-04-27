namespace FilterLists.Api.Persistence.Entities;

internal record Merge
{
    public int IncludedInFilterListId { get; init; }
    public int IncludesFilterListId { get; init; }
}