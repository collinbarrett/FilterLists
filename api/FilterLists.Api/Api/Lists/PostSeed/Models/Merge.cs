namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record Merge
{
    public long IncludedInFilterListId { get; init; }
    public long IncludesFilterListId { get; init; }
}