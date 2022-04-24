namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record FilterListMaintainer
{
    public long FilterListId { get; init; }
    public long MaintainerId { get; init; }
}