using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListSyntax
    {
        public FilterList FilterList { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class FilterListSyntaxTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : FilterListSyntax
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListSyntax.FilterList) + "Id";
            const string syntaxId = nameof(FilterListSyntax.Syntax) + "Id";
            builder.Property<int>(filterListId);
            builder.Property<int>(syntaxId);
            builder.HasKey(filterListId, syntaxId);
        }
    }
}