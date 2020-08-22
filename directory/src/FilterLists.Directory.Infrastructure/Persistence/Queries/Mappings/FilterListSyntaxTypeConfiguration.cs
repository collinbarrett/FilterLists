using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
    internal class FilterListSyntaxTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : FilterListSyntax
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListSyntax.FilterList) + "Id";
            const string syntaxId = nameof(FilterListSyntax.Syntax) + "Id";
            builder.Property<ushort>(filterListId);
            builder.Property<ushort>(syntaxId);
            builder.HasKey(filterListId, syntaxId);
        }
    }
}