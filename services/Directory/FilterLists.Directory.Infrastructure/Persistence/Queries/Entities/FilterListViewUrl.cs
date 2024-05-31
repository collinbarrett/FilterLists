namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListViewUrl
{
    public int Id { get; init; }
    public int FilterListId { get; init; }
    public required FilterList FilterList { get; init; }
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public required Uri Url { get; init; }
}