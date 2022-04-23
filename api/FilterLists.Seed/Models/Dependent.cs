namespace FilterLists.Seed.Models;

public record Dependent
{
    public long DependencyFilterListId { get; init; }
    public FilterList DependencyFilterList { get; init; } = default!;
    public long DependentFilterListId { get; init; }
    public FilterList DependentFilterList { get; init; } = default!;
}