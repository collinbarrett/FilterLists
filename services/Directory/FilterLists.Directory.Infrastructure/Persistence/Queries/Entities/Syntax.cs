using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Syntax : AggregateRoot
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new HashSet<FilterListSyntax>();
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new HashSet<SoftwareSyntax>();
}

internal class SyntaxTypeConfiguration : AggregateRootTypeConfiguration<Syntax>
{
    public override void Configure(EntityTypeBuilder<Syntax> builder)
    {
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.HasDataJsonFileAggregate<Syntax>();
        base.Configure(builder);
    }
}
