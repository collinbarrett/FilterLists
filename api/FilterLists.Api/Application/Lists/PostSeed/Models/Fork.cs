namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record Fork
{
    public long UpstreamFilterListId { get; init; }
    public long ForkFilterListId { get; init; }
}