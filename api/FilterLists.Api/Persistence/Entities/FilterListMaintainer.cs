namespace FilterLists.Api.Persistence.Entities;

internal record FilterListMaintainer
{
    public int FilterListId { get; init; }
    public int MaintainerId { get; init; }
}