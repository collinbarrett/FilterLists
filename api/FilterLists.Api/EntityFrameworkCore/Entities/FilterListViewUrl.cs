namespace FilterLists.Api.EntityFrameworkCore.Entities;

public record FilterListViewUrl
{
    public int Id { get; init; }
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public int SegmentNumber { get; init; }
    public int Primariness { get; init; }

    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public Uri Url { get; init; } = default!;
}