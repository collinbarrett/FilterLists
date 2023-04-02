namespace FilterLists.Api.Entities;

public record FilterListViewUrl
{
    public int Id { get; private init; }
    public int FilterListId { get; private init; }
    public FilterList FilterList { get; private init; } = default!;
    public int SegmentNumber { get; private init; }
    public int Primariness { get; private init; }
    public Uri Url { get; private init; } = default!;
}