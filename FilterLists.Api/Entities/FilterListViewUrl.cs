namespace FilterLists.Api.Entities;

public record FilterListViewUrl
{
    public int Id { get; init; }
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}