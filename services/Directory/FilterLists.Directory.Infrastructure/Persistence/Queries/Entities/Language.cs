using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Language
{
    public string Iso6391 { get; init; } = null!;
    public string Name { get; init; } = null!;
    public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
}

internal class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
{
    public virtual void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(l => l.Iso6391);
        builder.Property(l => l.Iso6391)
            .IsFixedLength()
            .HasMaxLength(2);
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.HasDataJsonFile<Language>();
    }
}
