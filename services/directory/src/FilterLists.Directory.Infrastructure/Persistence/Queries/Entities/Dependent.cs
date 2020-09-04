﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Dependent
    {
        public int DependencyFilterListId { get; set; }
        public FilterList DependencyFilterList { get; private set; } = null!;
        public int DependentFilterListId { get; set; }
        public FilterList DependentFilterList { get; private set; } = null!;
    }

    internal class DependentTypeConfiguration : IEntityTypeConfiguration<Dependent>
    {
        public virtual void Configure(EntityTypeBuilder<Dependent> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.ToTable(nameof(Dependent) + "s");
            builder.HasKey(d => new {d.DependencyFilterListId, d.DependentFilterListId});
            builder.HasOne(d => d.DependencyFilterList)
                .WithMany(fl => fl.DependentFilterLists)
                .HasForeignKey(d => d.DependencyFilterListId);
            builder.HasOne(d => d.DependentFilterList)
                .WithMany(fl => fl.DependencyFilterLists)
                .HasForeignKey(d => d.DependentFilterListId);
            builder.HasDataJsonFile<Dependent>();
        }
    }
}