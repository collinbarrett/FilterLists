﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Merge
    {
        public int IncludedInFilterListId { get; set; }
        public FilterList IncludedInFilterList { get; private set; } = null!;
        public int IncludesFilterListId { get; set; }
        public FilterList IncludesFilterList { get; private set; } = null!;
    }

    internal class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
    {
        public virtual void Configure(EntityTypeBuilder<Merge> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(Merge) + "s");

            builder.HasKey(m => new {m.IncludedInFilterListId, m.IncludesFilterListId});
            builder.HasOne(m => m.IncludedInFilterList)
                .WithMany(fl => fl.IncludesFilterLists)
                .HasForeignKey(m => m.IncludedInFilterListId);
            builder.HasOne(m => m.IncludesFilterList)
                .WithMany(fl => fl.IncludedInFilterLists)
                .HasForeignKey(m => m.IncludesFilterListId);
        }
    }
}