using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Merge
    {
        public FilterList IncludedInFilterList { get; private set; } = null!;
        public FilterList IncludesFilterList { get; private set; } = null!;
    }

    internal class MergeTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Merge
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string includedInFilterListId = nameof(Merge.IncludedInFilterList) + "Id";
            const string includesFilterListId = nameof(Merge.IncludesFilterList) + "Id";
            builder.Property<int>(includedInFilterListId);
            builder.Property<int>(includesFilterListId);
            builder.HasKey(includedInFilterListId, includesFilterListId);
            builder.HasOne(m => m.IncludedInFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.IncludedInFilterLists)
                .HasForeignKey(includedInFilterListId);
            builder.HasOne(m => m.IncludesFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.IncludesFilterLists)
                .HasForeignKey(includesFilterListId);
        }
    }
}