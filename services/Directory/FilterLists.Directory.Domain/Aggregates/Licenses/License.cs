namespace FilterLists.Directory.Domain.Aggregates.Licenses;

public class License
{
    private License()
    {
    }

    public License(string name,
        Uri? url,
        bool? permitsModification,
        bool? permitsDistribution,
        bool? permitsCommercialUse)
    {
        Name = name;
        Url = url;
        PermitsModification = permitsModification ?? false;
        PermitsDistribution = permitsDistribution ?? false;
        PermitsCommercialUse = permitsCommercialUse ?? false;
    }

    public string Name { get; private init; } = null!;
    public Uri? Url { get; private init; }
    public bool PermitsModification { get; private init; }
    public bool PermitsDistribution { get; private init; }
    public bool PermitsCommercialUse { get; private init; }
}
