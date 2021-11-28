using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.Tags;

public class Tag : Entity
{
    protected Tag() { }

    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public virtual IEnumerable<FilterList> FilterLists { get; private init; } = new HashSet<FilterList>();
}
