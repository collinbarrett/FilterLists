using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerConfiguration : IEntityTypeConfiguration<Maintainer>
    {
        public void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            entityTypeBuilder.Property(b => b.CreatedDateUtc).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}