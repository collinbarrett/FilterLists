using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListTagTypeConfiguration : BaseJunctionTypeConfiguration<FilterListTag>
    {
        public override void Configure(EntityTypeBuilder<FilterListTag> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("filterlists_tags");
            builder.HasKey(x => new {x.FilterListId, x.TagId});
            builder.HasOne(x => x.FilterList)
                .WithMany(x => x.FilterListTags)
                .HasForeignKey(x => x.FilterListId);
            builder.HasOne(x => x.Tag)
                .WithMany(x => x.FilterListTags)
                .HasForeignKey(x => x.TagId);
        }
    }
}