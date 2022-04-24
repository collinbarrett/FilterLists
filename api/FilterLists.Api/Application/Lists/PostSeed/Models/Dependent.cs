namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record Dependent
{
    public long DependencyFilterListId { get; init; }
    public long DependentFilterListId { get; init; }
}