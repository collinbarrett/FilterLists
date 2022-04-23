namespace FilterLists.Seed.Models;

public record Fork
{
    public long UpstreamFilterListId { get; init; }
    public FilterList UpstreamFilterList { get; init; } = default!;
    public long ForkFilterListId { get; init; }
    public FilterList ForkFilterList { get; init; } = default!;
}