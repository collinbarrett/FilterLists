namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record FilterListTag
{
    public long FilterListId { get; init; }
    public long TagId { get; init; }
}