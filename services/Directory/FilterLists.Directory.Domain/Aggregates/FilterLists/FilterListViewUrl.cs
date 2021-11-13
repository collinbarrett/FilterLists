namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListViewUrl
{
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = null!;
}
