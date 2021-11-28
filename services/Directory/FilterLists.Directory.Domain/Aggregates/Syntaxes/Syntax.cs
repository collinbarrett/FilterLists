using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.Syntaxes;

public class Syntax : Entity
{
    protected Syntax() { }

    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public Uri? Url { get; private init; }
    public virtual IEnumerable<FilterList> FilterLists { get; private init; } = new HashSet<FilterList>();
    public virtual IEnumerable<Software.Software> Software { get; private init; } = new HashSet<Software.Software>();
}
