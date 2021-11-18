using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListSyntax
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
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(FilterListSyntax))}es");
        builder.HasKey(fls => new { fls.FilterListId, fls.SyntaxId });
        builder.HasDataJsonFile<FilterListSyntax>();
    }
}
