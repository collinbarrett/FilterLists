using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Language
{
    public short Id { get; init; }
    public string Iso6391 { get; init; } = null!;
    public string Name { get; init; } = null!;
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new List<FilterListLanguage>();
}

internal sealed class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
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