using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListMaintainerTypeConfiguration : BaseEntityTypeConfiguration<FilterListMaintainer>
    {
        public override void Configure(EntityTypeBuilder<FilterListMaintainer> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_maintainers");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.MaintainerId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}