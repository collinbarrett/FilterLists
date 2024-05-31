using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record SoftwareSyntax
{
    public short SoftwareId { get; init; }
    public Software Software { get; init; } = null!;
    public short SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = null!;
}

internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
{
    public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
    {
        builder.HasKey(ss => new { ss.SoftwareId, ss.SyntaxId });
        builder.HasDataJsonFile<SoftwareSyntax>();
    }
}