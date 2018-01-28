using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class BaseJunctionTypeConfiguration<TJunction> : IEntityTypeConfiguration<TJunction>
        where TJunction : BaseJunction
    {
        public virtual void Configure(EntityTypeBuilder<TJunction> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAdd();
        }
    }
}