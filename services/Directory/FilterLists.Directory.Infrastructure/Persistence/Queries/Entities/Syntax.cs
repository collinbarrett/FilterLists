using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Syntax
{
    public short Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new List<FilterListSyntax>();
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new List<SoftwareSyntax>();
}

internal sealed class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
{
    public void Configure(EntityTypeBuilder<Syntax> builder)
    {
        builder.Property(s => s.Name)
            .HasMaxLength(64);
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.Url)
            .HasMaxLength(512);
        builder.HasDataJsonFile<Syntax>();
    }
}