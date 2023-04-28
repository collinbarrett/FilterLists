namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The URL at which the <see cref="FilterList" /> can be viewed or downloaded
/// </summary>
public record FilterListViewUrl
{
    /// <summary>
    ///     The unique identifier of the FilterListViewUrl
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique identifier of the <see cref="FilterList" />
    /// </summary>
    public int FilterListId { get; init; }

    /// <summary>
    ///     The <see cref="FilterList" />
    /// </summary>
    public FilterList FilterList { get; init; } = null!;

    /// <summary>
    ///     The segment number of the FilterListViewUrl (for multi-part lists)
    /// </summary>
    public int SegmentNumber { get; init; }

    /// <summary>
    ///     How primary the FilterListViewUrl is to the <see cref="FilterList" /> segment (1 is original, 2+ is a mirror;
    ///     unique per filterListId and segmentNumber)
    /// </summary>
    public int Primariness { get; init; }

    /// <summary>
    ///     The URL at which the <see cref="FilterList" /> can be viewed or downloaded
    /// </summary>
    public Uri Url { get; init; } = default!;
}