using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
    internal class ForkTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Fork
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string upstreamFilterListId = nameof(Fork.UpstreamFilterList) + "Id";
            const string forkFilterListId = nameof(Fork.ForkFilterList) + "Id";
            builder.Property<ushort>(upstreamFilterListId);
            builder.Property<ushort>(forkFilterListId);
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