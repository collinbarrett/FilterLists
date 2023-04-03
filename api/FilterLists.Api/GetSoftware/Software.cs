using System;
using System.Collections.Generic;

namespace FilterLists.Api.GetSoftware;

public record Software
{
    /// <summary>
    ///     The identifier.
    /// </summary>
    /// <example>2</example>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name.
    /// </summary>
    /// <example>Adblock Plus</example>
    public string Name { get; init; } = default!;

    /// <summary>
    ///     The description.
    /// </summary>
    /// <example>
    ///     Adblock Plus is a free extension that allows you to customize your web experience. You can block annoying ads,
    ///     disable tracking and lots more. It’s available for all major desktop browsers and for your mobile devices.
    /// </example>
    public string? Description { get; init; }

    /// <summary>
    ///     The URL of the home page.
    /// </summary>
    /// <example>https://adblockplus.org/</example>
    public Uri? HomeUrl { get; init; }

    /// <summary>
    ///     The URL of the Software download.
    /// </summary>
    /// <example>https://adblockplus.org/</example>
    public Uri? DownloadUrl { get; init; }

    /// <summary>
    ///     If the Software supports the abp: URL scheme to click-to-subscribe to a FilterList.
    /// </summary>
    /// <example>true</example>
    public bool SupportsAbpUrlScheme { get; init; }

    /// <summary>
    ///     The identifiers of the Syntaxes that this Software supports.
    /// </summary>
    /// <example>[ 3, 28, 38, 48 ]</example>
    public IEnumerable<int> SyntaxIds { get; init; } = new HashSet<int>();
}