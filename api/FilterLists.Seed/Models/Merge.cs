namespace FilterLists.Seed.Models;

public record Merge
{
    public long IncludedInFilterListId { get; init; }
    public FilterList IncludedInFilterList { get; init; } = default!;
    public long IncludesFilterListId { get; init; }
    public FilterList IncludesFilterList { get; init; } = default!;
}