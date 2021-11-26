using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListLanguage
{
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public long LanguageId { get; init; }
    public Language Language { get; init; } = null!;
}

internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(FilterListLanguage))}s");
        builder.HasKey(fll => new { fll.FilterListId, fll.LanguageId });
        builder.HasQueryFilter(fll => fll.FilterList.IsApproved && fll.Language.IsApproved);
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}
