using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListTypeConfiguration : BaseEntityTypeConfiguration<FilterList>
    {
        public override void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
        }
    }
}