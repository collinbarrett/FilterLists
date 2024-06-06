using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record FilterListSyntax
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public short SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = null!;
}

internal sealed class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
{
    public void Configure(EntityTypeBuilder<FilterListSyntax> builder)
    {
        builder.HasKey(fls => new { fls.FilterListId, fls.SyntaxId });
        builder.HasDataJsonFile<FilterListSyntax>();
    }
}