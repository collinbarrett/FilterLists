using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListSoftwareTypeConfiguration : BaseEntityTypeConfiguration<FilterListSoftware>
    {
        public override void Configure(EntityTypeBuilder<FilterListSoftware> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_software");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.SoftwareId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}