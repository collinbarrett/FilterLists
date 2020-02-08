using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListTagTypeConfiguration : BaseJunctionTypeConfiguration<FilterListTag>
    {
        public override void Configure(EntityTypeBuilder<FilterListTag> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists_tags");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.TagId});
            entityTypeBuilder.HasOne(x => x.FilterList)
                             .WithMany(x => x.FilterListTags)
                             .HasForeignKey(x => x.FilterListId);
            entityTypeBuilder.HasOne(x => x.Tag)
                             .WithMany(x => x.FilterListTags)
                             .HasForeignKey(x => x.TagId);
        }
    }
}