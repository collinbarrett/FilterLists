namespace FilterLists.Api.Application.Lists.PostSeed.Models;

public record FilterListViewUrl
{
    public long FilterListId { get; init; }
    public int SegmentNumber { get; init; }
    public int Primariness { get; init; }
    public string Url { get; init; } = default!;
}