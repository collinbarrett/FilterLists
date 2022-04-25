namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record FilterListTag
{
    public long FilterListId { get; init; }
    public long TagId { get; init; }
}