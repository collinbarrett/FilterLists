using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record Software
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? DownloadUrl { get; init; }
    public bool SupportsAbpUrlScheme { get; init; }
    public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
}

internal class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
{
    public virtual void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.SupportsAbpUrlScheme)
            .HasDefaultValue(false);
        builder
            .HasMany(s => s.Syntaxes)
            .WithMany(s => s.Software)
            .UsingEntity<SoftwareSyntax>(j => j.HasDataJsonFile<SoftwareSyntax>());
        builder.HasDataJsonFile<Software>();
    }
}