using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListTag
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; private set; } = null!;
        public int TagId { get; private set; }
        public Tag Tag { get; private set; } = null!;
    }

    internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(FilterListTag) + "s");

            builder.HasKey(flt => new {flt.FilterListId, flt.TagId});
        }
    }
}