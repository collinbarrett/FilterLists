namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record Fork
{
    public long UpstreamFilterListId { get; init; }
    public long ForkFilterListId { get; init; }
}