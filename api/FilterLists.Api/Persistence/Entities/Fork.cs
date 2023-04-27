namespace FilterLists.Api.Persistence.Entities;

internal record Fork
{
    public int UpstreamFilterListId { get; init; }
    public int ForkFilterListId { get; init; }
}