namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record FilterListViewUrl
{
    public long Id { get; init; }
    public long FilterListId { get; init; }
    public int SegmentNumber { get; init; }
    public int Primariness { get; init; }
    public string Url { get; init; } = default!;
}