using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.Languages;

public class Language : Entity
{
    protected Language() { }

    public string Iso6391 { get; private init; } = default!;
    public string Name { get; private init; } = default!;
    public virtual IEnumerable<FilterList> FilterLists { get; private init; } = new HashSet<FilterList>();
}
