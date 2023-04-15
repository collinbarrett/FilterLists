using System;

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
    public string Name { get; init; } = string.Empty;

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
}