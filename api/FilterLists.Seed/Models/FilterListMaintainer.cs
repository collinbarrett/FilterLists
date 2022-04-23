namespace FilterLists.Seed.Models;

public record FilterListMaintainer
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public long MaintainerId { get; init; }
    public Maintainer Maintainer { get; init; } = default!;
}