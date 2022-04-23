namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record FilterListMaintainer
{
    public long FilterListId { get; init; }
    public long MaintainerId { get; init; }
}