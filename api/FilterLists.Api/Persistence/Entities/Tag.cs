using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The tag applied to <see cref="FilterList" />s
/// </summary>
public record Tag
{
    /// <summary>
    ///     The unique identifier of the Tag
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name of the Tag
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The brief English description of the Tag
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The <see cref="FilterList" />s to which the Tag is applied
    /// </summary>
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name).IsUnique();
        builder.HasDataJsonFile<Tag>();
    }
}