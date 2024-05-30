using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record License : Entity
{
    public string Name { get; init; } = default!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
{
    public virtual void Configure(EntityTypeBuilder<License> builder)
    {
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.Property(l => l.PermitsModification)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsDistribution)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsCommercialUse)
            .HasDefaultValue(false);
        builder.HasDataJsonFile<License>();
    }
}