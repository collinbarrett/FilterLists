namespace FilterLists.Api.Persistence.Entities;

internal record Dependent
{
    public int DependencyFilterListId { get; init; }
    public int DependentFilterListId { get; init; }
}