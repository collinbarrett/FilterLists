using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Software
{
    public short Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? DownloadUrl { get; init; }
    public bool SupportsAbpUrlScheme { get; init; }
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new List<SoftwareSyntax>();
}

internal sealed class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
{
    public void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.Property(s => s.Name)
            .HasMaxLength(64);
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.HomeUrl)
            .HasMaxLength(512);
        builder.Property(s => s.DownloadUrl)
            .HasMaxLength(512);
        builder.Property(s => s.SupportsAbpUrlScheme)
            .HasDefaultValue(false);
        builder.HasDataJsonFile<Software>();
    }
}