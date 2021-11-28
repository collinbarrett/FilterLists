using FilterLists.Directory.Domain.Aggregates.Syntaxes;
using FilterLists.SharedKernel.Domain.SeedWork;

namespace FilterLists.Directory.Domain.Aggregates.Software;

public class Software : Entity
{
    protected Software() { }

    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public Uri? HomeUrl { get; private init; }
    public Uri? DownloadUrl { get; private init; }
    public bool SupportsAbpUrlScheme { get; private init; }
    public virtual IEnumerable<Syntax> Syntaxes { get; private init; } = new HashSet<Syntax>();
}
