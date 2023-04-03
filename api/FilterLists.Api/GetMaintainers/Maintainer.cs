using System;
using System.Collections.Generic;

namespace FilterLists.Api.GetMaintainers;

public record Maintainer
{
    /// <summary>
    ///     The identifier.
    /// </summary>
    /// <example>7</example>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name.
    /// </summary>
    /// <example>The EasyList Authors</example>
    public string Name { get; init; } = default!;

    /// <summary>
    ///     The URL of the home page.
    /// </summary>
    /// <example>https://easylist.to/</example>
    public Uri? Url { get; init; }

    /// <summary>
    ///     The email address.
    /// </summary>
    /// <example>null</example>
    public string? EmailAddress { get; init; }

    /// <summary>
    ///     The Twitter handle.
    /// </summary>
    /// <example>null</example>
    public string? TwitterHandle { get; init; }

    /// <summary>
    ///     The identifiers of the FilterLists maintained by this Maintainer.
    /// </summary>
    /// <example>[ 11, 13, 301 ]</example>
    public IEnumerable<int> FilterListIds { get; init; } = new HashSet<int>();
}