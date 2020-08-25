using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Fork
    {
        public int UpstreamFilterListId { get; private set; }
        public FilterList UpstreamFilterList { get; private set; } = null!;
        public int ForkFilterListId { get; private set; }
        public FilterList ForkFilterList { get; private set; } = null!;
    }

    internal class ForkTypeConfiguration : IEntityTypeConfiguration<Fork>
    {
        public virtual void Configure(EntityTypeBuilder<Fork> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(Fork) + "s");

            builder.HasKey(f => new {f.UpstreamFilterListId, f.ForkFilterListId});
            builder.HasOne(f => f.UpstreamFilterList)
                .WithMany(fl => fl.ForkFilterLists)
                .HasForeignKey(f => f.UpstreamFilterListId);
            builder.HasOne(f => f.ForkFilterList)
                .WithMany(fl => fl.UpstreamFilterLists)
                .HasForeignKey(f => f.ForkFilterListId);
        }
    }
}