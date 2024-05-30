namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListViewUrl : Entity
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}