using System.Collections.Generic;

namespace FilterLists.Api.GetTags;

public record Tag
{
    /// <summary>
    ///     The identifier.
    /// </summary>
    /// <example>2</example>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name.
    /// </summary>
    /// <example>ads</example>
    public string Name { get; init; } = default!;

    /// <summary>
    ///     The description.
    /// </summary>
    /// <example>Blocks advertisements</example>
    public string? Description { get; init; }

    /// <summary>
    ///     The identifiers of the FilterLists to which this Tag is applied.
    /// </summary>
    /// <example>[ 1, 3, 6 ]</example>
    public IEnumerable<int> FilterListIds { get; init; } = new HashSet<int>();
}