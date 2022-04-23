namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record FilterListTag
{
    public long FilterListId { get; init; }
    public long TagId { get; init; }
}