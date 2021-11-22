namespace FilterLists.Directory.Domain.Aggregates.Licenses;

public class License
{
    protected License() { }

    public string Name { get; private init; } = null!;
    public Uri? Url { get; private init; }
    public bool PermitsModification { get; private init; }
    public bool PermitsDistribution { get; private init; }
    public bool PermitsCommercialUse { get; private init; }

    public static License Create(string name,
        Uri? url,
        bool permitsModification,
        bool permitsDistribution,
        bool permitsCommercialUse)
    {
        return new License
        {
            Name = name,
            Url = url,
            PermitsModification = permitsModification,
            PermitsDistribution = permitsDistribution,
            PermitsCommercialUse = permitsCommercialUse
        };
    }
}
