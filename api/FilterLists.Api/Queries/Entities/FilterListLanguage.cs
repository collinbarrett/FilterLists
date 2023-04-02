using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Queries.Entities;

internal record FilterListLanguage
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public int LanguageId { get; init; }
    public Language Language { get; init; } = default!;
}

internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        builder.HasKey(fll => new { fll.FilterListId, fll.LanguageId });
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}