using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record License
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
    public IEnumerable<FilterList> FilterLists { get; init; } = new List<FilterList>();
}

internal sealed class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
{
    public void Configure(EntityTypeBuilder<License> builder)
    {
        builder.Property(l => l.Name)
            .HasMaxLength(64);
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.Property(l => l.Url)
            .HasMaxLength(512);
        builder.Property(l => l.PermitsModification)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsDistribution)
            .HasDefaultValue(false);
        builder.Property(l => l.PermitsCommercialUse)
            .HasDefaultValue(false);
        builder.HasDataJsonFile<License>();
    }
}