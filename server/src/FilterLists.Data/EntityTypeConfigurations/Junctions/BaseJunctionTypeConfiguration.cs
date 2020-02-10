using FilterLists.Data.Entities.Junctions;
using FilterLists.Data.Seed.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class BaseJunctionTypeConfiguration<TJunction> : IEntityTypeConfiguration<TJunction>
        where TJunction : BaseJunctionEntity
    {
        public virtual void Configure(EntityTypeBuilder<TJunction> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAdd()
                             .IsRequired()
                             .HasDefaultValueSql("current_timestamp()");
            entityTypeBuilder.HasDataJsonFile<TJunction>();
        }
    }
}