using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListLanguage
{
    public int FilterListId { get; init; }
    public required FilterList FilterList { get; init; }
    public short LanguageId { get; init; }
    public required Language Language { get; init; }
}

internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
{
    public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
    {
        builder.HasKey(fll => new { fll.FilterListId, fll.LanguageId });
        builder.HasDataJsonFile<FilterListLanguage>();
    }
}