using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "ReplaceAutoPropertyWithComputedProperty")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListLanguage
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; } = null!;
        public string Iso6391 { get; private set; } = null!;
        public Language Language { get; } = null!;
    }

    internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
        {
            builder.ToTable(nameof(FilterListLanguage) + "s");
            builder.HasKey(fll => new { fll.FilterListId, fll.Iso6391 });
            builder.HasDataJsonFile<FilterListLanguage>();
        }
    }
}
