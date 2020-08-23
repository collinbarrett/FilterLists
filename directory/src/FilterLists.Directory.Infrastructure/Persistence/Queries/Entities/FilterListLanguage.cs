using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListLanguage
    {
        public FilterList FilterList { get; private set; } = null!;
        public Language Language { get; private set; } = null!;
    }

    internal class FilterListLanguageTypeConfiguration : IEntityTypeConfiguration<FilterListLanguage>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListLanguage> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListLanguage.FilterList) + "Id";
            const string languageId = nameof(Language) + nameof(Language.Iso6391);
            builder.Property<int>(filterListId);
            builder.Property<string>(languageId);
            builder.HasKey(filterListId, languageId);
        }
    }
}