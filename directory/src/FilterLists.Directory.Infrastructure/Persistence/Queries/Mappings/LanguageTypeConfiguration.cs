using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
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