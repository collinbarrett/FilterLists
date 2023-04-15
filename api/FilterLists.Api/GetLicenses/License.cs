using System;

namespace FilterLists.Api.GetLicenses;

public record License
{
    /// <summary>
    ///     The identifier.
    /// </summary>
    /// <example>5</example>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name.
    /// </summary>
    /// <example>All Rights Reserved</example>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The URL of the home page.
    /// </summary>
    /// <example>https://en.wikipedia.org/wiki/All_rights_reserved</example>
    public Uri? Url { get; init; }

    /// <summary>
    ///     If the License permits modification.
    /// </summary>
    /// <example>false</example>
    public bool PermitsModification { get; init; }

    /// <summary>
    ///     If the License permits distribution.
    /// </summary>
    /// <example>false</example>
    public bool PermitsDistribution { get; init; }

    /// <summary>
    ///     If the License permits commercial use.
    /// </summary>
    /// <example>false</example>
    public bool PermitsCommercialUse { get; init; }
}