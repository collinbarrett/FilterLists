using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public class License
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
    public IReadOnlyCollection<FilterList> FilterLists { get; } = new HashSet<FilterList>();
}

internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
{
    public virtual void Configure(EntityTypeBuilder<License> builder)
    {
        builder.HasDataJsonFile<License>();
    }
}
