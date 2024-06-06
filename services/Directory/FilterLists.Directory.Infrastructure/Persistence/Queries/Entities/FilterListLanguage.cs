using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record FilterListLanguage
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = null!;
    public short LanguageId { get; init; }
    public Language Language { get; init; } = null!;
}

internal sealed class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        builder.HasKey(fll => new { fll.FilterListId, fll.LanguageId });
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}