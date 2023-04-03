using System;
using System.Collections.Generic;

namespace FilterLists.Api.GetSyntaxes;

public record Syntax
{
    /// <summary>
    ///     The identifier.
    /// </summary>
    /// <example>3</example>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name.
    /// </summary>
    /// <example>Adblock Plus</example>
    public string Name { get; init; } = default!;

    /// <summary>
    ///     The description.
    /// </summary>
    /// <example>null</example>
    public string? Description { get; init; }

    /// <summary>
    ///     The URL of the home page.
    /// </summary>
    /// <example>https://adblockplus.org/filters</example>
    public Uri? Url { get; init; }

    /// <summary>
    ///     The identifiers of the FilterLists implementing this Syntax.
    /// </summary>
    /// <example>[ 2, 6, 11 ]</example>
    public IEnumerable<int> FilterListIds { get; init; } = new HashSet<int>();

    /// <summary>
    ///     The identifiers of the Software that supports this Syntax.
    /// </summary>
    /// <example>[ 1, 2, 3 ]</example>
    public IEnumerable<int> SoftwareIds { get; init; } = new HashSet<int>();
}