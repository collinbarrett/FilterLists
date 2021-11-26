using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Language : AggregateRoot
{
    public string Iso6391 { get; init; } = null!;
    public string Name { get; init; } = null!;
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new HashSet<FilterListLanguage>();
}

internal class LanguageTypeConfiguration : AggregateRootTypeConfiguration<Language>
{
    public override void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.Property(l => l.Iso6391)
            .IsFixedLength()
            .HasMaxLength(2);
        builder.HasIndex(l => l.Iso6391)
            .IsUnique();
        builder.HasIndex(l => l.Name)
            .IsUnique();
        builder.HasDataJsonFileAggregate<Language>();
        base.Configure(builder);
    }
}
