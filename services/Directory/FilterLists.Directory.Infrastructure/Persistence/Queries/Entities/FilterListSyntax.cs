using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public class FilterListSyntax
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; } = null!;
    public int SyntaxId { get; init; }
    public Syntax Syntax { get; } = null!;
}

internal class FilterListSyntaxTypeConfiguration : IEntityTypeConfiguration<FilterListSyntax>
{
    public virtual void Configure(EntityTypeBuilder<FilterListSyntax> builder)
    {
        builder.ToTable(nameof(FilterListSyntax) + "es");
        builder.HasKey(fls => new { fls.FilterListId, fls.SyntaxId });
        builder.HasDataJsonFile<FilterListSyntax>();
    }
}
