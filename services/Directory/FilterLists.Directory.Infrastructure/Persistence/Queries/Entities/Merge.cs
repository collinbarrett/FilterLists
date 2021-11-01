using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Merge
    {
        public int IncludedInFilterListId { get; set; }
        public FilterList IncludedInFilterList { get; } = null!;
        public int IncludesFilterListId { get; set; }
        public FilterList IncludesFilterList { get; } = null!;
    }

    internal class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
    {
        public virtual void Configure(EntityTypeBuilder<Merge> builder)
        {
            builder.ToTable(nameof(Merge) + "s");
            builder.HasKey(m => new { m.IncludedInFilterListId, m.IncludesFilterListId });
            builder.HasOne(m => m.IncludedInFilterList)
                .WithMany(fl => fl.IncludesFilterLists)
                .HasForeignKey(m => m.IncludedInFilterListId);
            builder.HasOne(m => m.IncludesFilterList)
                .WithMany(fl => fl.IncludedInFilterLists)
                .HasForeignKey(m => m.IncludesFilterListId);
            builder.HasDataJsonFile<Merge>();
        }
    }
}
