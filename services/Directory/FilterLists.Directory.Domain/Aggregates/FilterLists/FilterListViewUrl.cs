using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.FilterLists;

public class FilterListViewUrl : Entity
{
    protected FilterListViewUrl() { }

    public short SegmentNumber { get; private init; }
    public short Primariness { get; private init; }
    public Uri Url { get; private init; } = null!;

    internal static FilterListViewUrl Create(short segmentNumber, short primariness, Uri url)
    {
        if (segmentNumber < 1)
        {
            throw new ArgumentException(
                "The segment number must be greater than or equal to 1.",
                nameof(segmentNumber));
        }

        if (primariness < 1)
        {
            throw new ArgumentException(
                "The primariness must be greater than or equal to 1.",
                nameof(segmentNumber));
        }

        return new FilterListViewUrl { SegmentNumber = segmentNumber, Primariness = primariness, Url = url };
    }
}
