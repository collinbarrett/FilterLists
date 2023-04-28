using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The language of the websites targeted by <see cref="FilterList" />s
/// </summary>
public record Language
{
    /// <summary>
    ///     The unique identifier of the Language
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique two-character ISO 639-1 code of the Language
    /// </summary>
    public string Iso6391 { get; init; } = string.Empty;

    /// <summary>
    ///     The unique name of the Language
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The <see cref="FilterList" />s targeting websites in the Language
    /// </summary>
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
}

internal class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
{
    public virtual void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(l => l.Iso6391)
            .IsFixedLength()
            .HasMaxLength(2);
        builder.HasIndex(l => l.Iso6391)
            .IsUnique();
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.HasDataJsonFile<Language>();
    }
}