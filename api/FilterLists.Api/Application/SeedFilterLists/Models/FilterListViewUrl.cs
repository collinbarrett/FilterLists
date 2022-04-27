using System;

namespace FilterLists.Api.Application.SeedFilterLists.Models;

public record FilterListViewUrl
{
    public long FilterListId { get; init; }
    public int SegmentNumber { get; init; }
    public int Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}