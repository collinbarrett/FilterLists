namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListViewUrl
{
    protected FilterListViewUrl() { }

    public short SegmentNumber { get; private init; }
    public short Primariness { get; private init; }
    public Uri Url { get; private init; } = null!;

    internal static FilterListViewUrl Create(short segmentNumber, short primariness, Uri url)
    {
        return new FilterListViewUrl { SegmentNumber = segmentNumber, Primariness = primariness, Url = url };
    }
}
