using System.Collections.Generic;

namespace FilterLists.Seed.Models;

public record Tag
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
}