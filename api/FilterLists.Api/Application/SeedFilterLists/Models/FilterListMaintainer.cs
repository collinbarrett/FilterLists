namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record FilterListMaintainer
{
    public long FilterListId { get; init; }
    public long MaintainerId { get; init; }
}