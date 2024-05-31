using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record SoftwareSyntax
{
    public short SoftwareId { get; init; }
    public required Software Software { get; init; }
    public short SyntaxId { get; init; }
    public required Syntax Syntax { get; init; }
}

internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
{
    public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
    {
        builder.HasKey(ss => new { ss.SoftwareId, ss.SyntaxId });
        builder.HasDataJsonFile<SoftwareSyntax>();
    }
}