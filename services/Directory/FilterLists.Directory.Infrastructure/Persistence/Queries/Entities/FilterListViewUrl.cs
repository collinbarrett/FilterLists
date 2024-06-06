using JetBrains.Annotations;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

[PublicAPI]
public sealed record FilterListViewUrl
{
    public int Id { get; init; }
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = null!;
}