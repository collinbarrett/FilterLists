using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Syntax
{
    public int Id { get; private init; }
    public string Name { get; private init; } = null!;
    public string? Description { get; private init; }
    public Uri? Url { get; private init; }
    public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
    public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; } = new HashSet<SoftwareSyntax>();
}

internal class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
{
    public virtual void Configure(EntityTypeBuilder<Syntax> builder)
    {
        builder.HasDataJsonFile<Syntax>();
    }
}
