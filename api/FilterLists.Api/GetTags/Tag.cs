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
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The description.
    /// </summary>
    /// <example>Blocks advertisements</example>
    public string? Description { get; init; }
}