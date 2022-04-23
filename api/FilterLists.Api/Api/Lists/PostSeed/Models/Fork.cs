namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record Fork
{
    public long UpstreamFilterListId { get; init; }
    public long ForkFilterListId { get; init; }
}