using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Language
    {
        public string Iso6391 { get; private set; } = null!;
        public string Name { get; private set; } = null!;
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
    }

    internal class LanguageTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : Language
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.HasKey(l => l.Iso6391);
        }
    }
}