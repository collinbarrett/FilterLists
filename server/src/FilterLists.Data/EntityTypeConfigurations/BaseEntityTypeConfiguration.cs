using FilterLists.Data.Entities;
using FilterLists.Data.Seed.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.Id)
                             .UseMySqlIdentityColumn()
                             .HasColumnType("SMALLINT");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAdd()
                             .IsRequired()
                             .HasDefaultValueSql("current_timestamp()");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAddOrUpdate()
                             .IsRequired()
                             .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");
            entityTypeBuilder.HasDataJsonFile<TEntity>();
        }
    }
}