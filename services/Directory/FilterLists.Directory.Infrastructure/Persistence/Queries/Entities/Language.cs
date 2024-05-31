using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Language
{
    public short Id { get; init; }
    public required string Iso6391 { get; init; }
    public required string Name { get; init; }
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new List<FilterListLanguage>();
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
        builder.Property(l => l.Name)
            .HasMaxLength(64);
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.HasDataJsonFile<Language>();
    }
}