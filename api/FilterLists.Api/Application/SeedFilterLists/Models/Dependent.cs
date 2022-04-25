namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Dependent
{
    public long DependencyFilterListId { get; init; }
    public long DependentFilterListId { get; init; }
}