using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The License under which a <see cref="FilterList" /> is licensed
/// </summary>
public record License
{
    /// <summary>
    ///     The unique identifier of the License
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name of the License
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The homepage URL of the License
    /// </summary>
    public Uri? Url { get; init; }

    /// <summary>
    ///     If the License permits modification
    /// </summary>
    public bool PermitsModification { get; init; }

    /// <summary>
    ///     If the License permits distribution
    /// </summary>
    public bool PermitsDistribution { get; init; }

    /// <summary>
    ///     If the License permits commercial use
    /// </summary>
    public bool PermitsCommercialUse { get; init; }

    /// <summary>
    ///     The <see cref="FilterList" />s licensed under the License
    /// </summary>
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