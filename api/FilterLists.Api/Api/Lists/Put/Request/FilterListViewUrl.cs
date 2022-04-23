using System;

namespace FilterLists.Api.Api.Lists.Put.Request;

public record FilterListViewUrl
{
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}