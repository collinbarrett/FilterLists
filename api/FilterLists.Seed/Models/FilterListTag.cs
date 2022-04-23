namespace FilterLists.Seed.Models;

public record FilterListTag
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public long TagId { get; init; }
    public Tag Tag { get; init; } = default!;
}