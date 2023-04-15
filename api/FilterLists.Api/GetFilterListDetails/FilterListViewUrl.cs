using System;

namespace FilterLists.Api.GetFilterListDetails;

public record FilterListViewUrl
{
    /// <summary>
    ///     The segment number of the URL for the FilterList (for multi-part lists).
    /// </summary>
    /// <example>1</example>
    public int SegmentNumber { get; init; }

    /// <summary>
    ///     How primary the URL is for the FilterList segment (1 is original, 2+ is a mirror; unique per SegmentNumber)
    /// </summary>
    /// <example>1</example>
    public int Primariness { get; init; }

    /// <summary>
    ///     The view URL.
    /// </summary>
    /// <example>https://easylist.to/easylist/easylist.txt</example>
    public Uri Url { get; init; } = new(string.Empty);
}