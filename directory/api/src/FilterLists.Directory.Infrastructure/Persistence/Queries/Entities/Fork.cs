using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Fork
    {
        public FilterList UpstreamFilterList { get; private set; } = null!;
        public FilterList ForkFilterList { get; private set; } = null!;
    }

    internal class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
    {
        public virtual void Configure(EntityTypeBuilder<Fork> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(Fork) + "s");

            const string upstreamFilterListId = nameof(Fork.UpstreamFilterList) + "Id";
            const string forkFilterListId = nameof(Fork.ForkFilterList) + "Id";
            builder.Property<int>(upstreamFilterListId);
            builder.Property<int>(forkFilterListId);
            builder.HasKey(upstreamFilterListId, forkFilterListId);
            builder.HasOne(f => f.UpstreamFilterList)
                .WithMany(f => f.UpstreamFilterLists)
                .HasForeignKey(upstreamFilterListId);
            builder.HasOne(f => f.ForkFilterList)
                .WithMany(f => f.ForkFilterLists)
                .HasForeignKey(forkFilterListId);
        }
    }
}