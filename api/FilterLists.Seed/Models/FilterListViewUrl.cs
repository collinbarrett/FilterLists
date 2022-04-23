using System;

namespace FilterLists.Seed.Models;

public record FilterListViewUrl
{
    public long Id { get; init; }
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}