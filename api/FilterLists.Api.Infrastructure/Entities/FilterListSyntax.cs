using FilterLists.Api.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Infrastructure.Entities;

public record FilterListSyntax
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public int SyntaxId { get; init; }
    public Syntax Syntax { get; init; } = default!;
}

internal class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
{
    public virtual void Configure(EntityTypeBuilder<FilterListSyntax> builder)
    {
        builder.HasKey(fls => new { fls.FilterListId, fls.SyntaxId });
        builder.HasDataJsonFile<FilterListSyntax>();
    }
}