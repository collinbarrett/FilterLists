using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record FilterListLanguage
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = new();
    public int LanguageId { get; init; }
    public Language Language { get; init; } = new();
}

internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        builder.HasKey(fll => new { fll.FilterListId, fll.LanguageId });
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}