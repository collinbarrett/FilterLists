using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListTag
    {
        public int FilterListId { get; private set; }
        public FilterList FilterList { get; } = null!;
        public int TagId { get; private set; }
        public Tag Tag { get; } = null!;
    }

    internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
        {
            builder.ToTable(nameof(FilterListTag) + "s");
            builder.HasKey(flt => new { flt.FilterListId, flt.TagId });
            builder.HasDataJsonFile<FilterListTag>();
        }
    }
}
