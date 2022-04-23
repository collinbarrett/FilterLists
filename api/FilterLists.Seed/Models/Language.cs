using System.Collections.Generic;

namespace FilterLists.Seed.Models;

public record Language
{
    public string Iso6391 { get; init; } = default!;
    public string Name { get; init; } = default!;
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new HashSet<FilterListLanguage>();
}