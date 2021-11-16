using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record License
{
    public int Id { get; private init; }
    public string Name { get; private init; } = null!;
    public Uri? Url { get; private init; }
    public bool PermitsModification { get; private init; }
    public bool PermitsDistribution { get; private init; }
    public bool PermitsCommercialUse { get; private init; }
    public IReadOnlyCollection<FilterList> FilterLists { get; } = new HashSet<FilterList>();
}

internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
{
    public virtual void Configure(EntityTypeBuilder<License> builder)
    {
        builder.HasDataJsonFile<License>();
    }
}
