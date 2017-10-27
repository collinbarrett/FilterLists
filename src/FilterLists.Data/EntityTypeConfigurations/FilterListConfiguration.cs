using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListConfiguration : IEntityTypeConfiguration<FilterList>
    {
        public void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            entityTypeBuilder.Property(b => b.CreatedDateUtc).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}