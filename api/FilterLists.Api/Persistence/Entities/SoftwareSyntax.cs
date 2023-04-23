using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record SoftwareSyntax
{
    public int SoftwareId { get; init; }
    public Software Software { get; init; } = new();
    public int SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = new();
}

internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
{
    public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
    {
        builder.HasKey(ss => new { ss.SoftwareId, ss.SyntaxId });
        builder.HasDataJsonFile<SoftwareSyntax>();
    }
}