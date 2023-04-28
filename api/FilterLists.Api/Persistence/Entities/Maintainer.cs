using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The individual or group who maintain <see cref="FilterList" />s
/// </summary>
public record Maintainer
{
    /// <summary>
    ///     The unique identifier of the Maintainer
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name of the Maintainer
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The homepage URL of the Maintainer
    /// </summary>
    public Uri? Url { get; init; }

    /// <summary>
    ///     The email address of the Maintainer
    /// </summary>
    public string? EmailAddress { get; init; }

    /// <summary>
    ///     The Twitter handle of the Maintainer
    /// </summary>
    public string? TwitterHandle { get; init; }

    /// <summary>
    ///     The <see cref="FilterList" />s maintained by the Maintainer
    /// </summary>
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
{
    public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.HasIndex(m => m.Name)
            .IsUnique();
        builder.HasDataJsonFile<Maintainer>();
    }
}