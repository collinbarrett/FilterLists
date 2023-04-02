using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Entities;

public record Software
{
    public int Id { get; private init; }
    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public Uri? HomeUrl { get; private init; }
    public Uri? DownloadUrl { get; private init; }
    public bool SupportsAbpUrlScheme { get; private init; }
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; private init; } = new HashSet<SoftwareSyntax>();
}

internal class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
{
    public virtual void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.SupportsAbpUrlScheme)
            .HasDefaultValue(false);
        builder.HasDataJsonFile<Software>();
    }
}