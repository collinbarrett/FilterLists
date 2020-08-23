using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListLanguage
    {
        public FilterList FilterList { get; private set; } = null!;
        public Language Language { get; private set; } = null!;
    }

    internal class FilterListLanguageTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : FilterListLanguage
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
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