using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListLanguage
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; } = null!;
    public string Iso6391 { get; init; } = null!;
    public Language Language { get; } = null!;
}

internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(FilterListLanguage))}s");
        builder.HasKey(fll => new { fll.FilterListId, fll.Iso6391 });
        builder.HasOne(fll => fll.Language)
            .WithMany(l => l.FilterListLanguages)
            .HasForeignKey(fll => fll.Iso6391)
            .HasConstraintName("fk_filter_list_languages_languages_iso6391");
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}
