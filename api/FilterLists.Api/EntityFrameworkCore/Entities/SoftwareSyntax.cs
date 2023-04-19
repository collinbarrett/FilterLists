using FilterLists.Api.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.EntityFrameworkCore.Entities;

public record SoftwareSyntax
{
    public int SoftwareId { get; init; }
    public Software Software { get; init; } = default!;
    public int SyntaxId { get; init; }
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