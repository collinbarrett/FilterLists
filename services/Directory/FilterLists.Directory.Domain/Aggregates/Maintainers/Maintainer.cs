using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.Maintainers;

public class Maintainer : Entity
{
    protected Maintainer() { }

    public string Name { get; private init; } = default!;
    public Uri? Url { get; private init; }
    public string? EmailAddress { get; private init; }
    public string? TwitterHandle { get; private init; }
    public virtual IEnumerable<FilterList> FilterLists { get; private init; } = new HashSet<FilterList>();
}
