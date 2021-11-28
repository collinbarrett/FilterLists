using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record License : EntityRequiringApproval
{
    public string Name { get; init; } = default!;
    public Uri? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<Change> Changes { get; init; } = new HashSet<Change>();
}

internal class LicenseTypeConfiguration : EntityRequiringApprovalTypeConfiguration<License>
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
        builder.HasDataJsonFileEntityRequiringApproval<License>();
        base.Configure(builder);
    }
}
