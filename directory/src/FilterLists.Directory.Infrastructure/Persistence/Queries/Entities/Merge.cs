using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Merge
    {
        public FilterList IncludedInFilterList { get; private set; } = null!;
        public FilterList IncludesFilterList { get; private set; } = null!;
    }

    internal class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
    {
        public virtual void Configure(EntityTypeBuilder<Merge> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(Merge) + "s");

            const string includedInFilterListId = nameof(Merge.IncludedInFilterList) + "Id";
            const string includesFilterListId = nameof(Merge.IncludesFilterList) + "Id";
            builder.Property<int>(includedInFilterListId);
            builder.Property<int>(includesFilterListId);
            builder.HasKey(includedInFilterListId, includesFilterListId);
            builder.HasOne(m => m.IncludedInFilterList)
                .WithMany(f => f.IncludedInFilterLists)
                .HasForeignKey(includedInFilterListId);
            builder.HasOne(m => m.IncludesFilterList)
                .WithMany(f => f.IncludesFilterLists)
                .HasForeignKey(includesFilterListId);
        }
    }
}