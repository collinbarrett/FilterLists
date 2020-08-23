using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Dependent
    {
        public FilterList DependencyFilterList { get; private set; } = null!;
        public FilterList DependentFilterList { get; private set; } = null!;
    }

    internal class DependentTypeConfiguration : IEntityTypeConfiguration<Dependent>
    {
        public virtual void Configure(EntityTypeBuilder<Dependent> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(Dependent) + "s");

            const string dependencyFilterListId = nameof(Dependent.DependencyFilterList) + "Id";
            const string dependentFilterListId = nameof(Dependent.DependentFilterList) + "Id";
            builder.Property<int>(dependencyFilterListId);
            builder.Property<int>(dependentFilterListId);
            builder.HasKey(dependencyFilterListId, dependentFilterListId);
            builder.HasOne(d => d.DependencyFilterList)
                .WithMany(f => f.DependencyFilterLists)
                .HasForeignKey(dependencyFilterListId);
            builder.HasOne(d => d.DependentFilterList)
                .WithMany(f => f.DependentFilterLists)
                .HasForeignKey(dependentFilterListId);
        }
    }
}