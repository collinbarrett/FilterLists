using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Dependent
    {
        public FilterList DependencyFilterList { get; private set; } = null!;
        public FilterList DependentFilterList { get; private set; } = null!;
    }

    internal class DependentTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Dependent
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string dependencyFilterListId = nameof(Dependent.DependencyFilterList) + "Id";
            const string dependentFilterListId = nameof(Dependent.DependentFilterList) + "Id";
            builder.Property<int>(dependencyFilterListId);
            builder.Property<int>(dependentFilterListId);
            builder.HasKey(dependencyFilterListId, dependentFilterListId);
            builder.HasOne(d => d.DependencyFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.DependencyFilterLists)
                .HasForeignKey(dependencyFilterListId);
            builder.HasOne(d => d.DependentFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.DependentFilterLists)
                .HasForeignKey(dependentFilterListId);
        }
    }
}