namespace FilterLists.Directory.Domain.Aggregates.Licenses;

public sealed class License
{
    private License() { }

    public string Name { get; private init; } = null!;
    public Uri? Url { get; private init; }
    public bool PermitsModification { get; private init; }
    public bool PermitsDistribution { get; private init; }
    public bool PermitsCommercialUse { get; private init; }
}
