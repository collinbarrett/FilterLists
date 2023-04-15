using System;

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
    public string Name { get; init; } = string.Empty;

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
}