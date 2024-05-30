using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record SoftwareSyntax
{
    public long SoftwareId { get; init; }
    public Software Software { get; init; } = default!;
    public long SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = default!;
}

internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
{
    public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
    {
        builder.HasKey(ss => new { ss.SoftwareId, ss.SyntaxId });
        builder.HasDataJsonFile<SoftwareSyntax>();
    }
}