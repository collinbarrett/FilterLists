using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Fork
    {
        public FilterList UpstreamFilterList { get; private set; } = null!;
        public FilterList ForkFilterList { get; private set; } = null!;
    }

    internal class ForkTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Fork
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string upstreamFilterListId = nameof(Fork.UpstreamFilterList) + "Id";
            const string forkFilterListId = nameof(Fork.ForkFilterList) + "Id";
            builder.Property<int>(upstreamFilterListId);
            builder.Property<int>(forkFilterListId);
            builder.HasKey(upstreamFilterListId, forkFilterListId);
            builder.HasOne(f => f.UpstreamFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.UpstreamFilterLists)
                .HasForeignKey(upstreamFilterListId);
            builder.HasOne(f => f.ForkFilterList)
                .WithMany(f => (IEnumerable<TEntity>)f.ForkFilterLists)
                .HasForeignKey(forkFilterListId);
        }
    }
}