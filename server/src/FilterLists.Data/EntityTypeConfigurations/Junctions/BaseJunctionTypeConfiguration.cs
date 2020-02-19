using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using FilterLists.Data.Seed.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class BaseJunctionTypeConfiguration<TJunction> : IEntityTypeConfiguration<TJunction>
        where TJunction : BaseJunctionEntity
    {
        public virtual void Configure(EntityTypeBuilder<TJunction> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            builder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired()
                .HasDefaultValueSql("current_timestamp()");
            builder.HasDataJsonFile<TJunction>();
        }
    }
}