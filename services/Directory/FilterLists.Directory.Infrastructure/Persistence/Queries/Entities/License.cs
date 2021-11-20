using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record License : AggregateRoot
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
    public IReadOnlyCollection<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class LicenseTypeConfiguration : AggregateRootTypeConfiguration<License>
{
    public override void Configure(EntityTypeBuilder<License> builder)
    {
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.Property(l => l.PermitsModification)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsDistribution)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsCommercialUse)
            .HasDefaultValue(false);
        builder.HasDataJsonFileAggregate<License>();
        base.Configure(builder);
    }
}
