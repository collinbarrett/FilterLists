using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Entities;

public record Syntax
{
    public int Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new HashSet<FilterListSyntax>();
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new HashSet<SoftwareSyntax>();
}

internal class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
{
    public virtual void Configure(EntityTypeBuilder<Syntax> builder)
    {
        builder.HasIndex(s => s.Name).IsUnique();
        builder.HasDataJsonFile<Syntax>();
    }
}