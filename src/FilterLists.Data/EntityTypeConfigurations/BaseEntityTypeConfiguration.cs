using FilterLists.Data.Entities;
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
                             .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAdd()
                             .HasDefaultValueSql("current_timestamp()");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                             .HasColumnType("TIMESTAMP")
                             .ValueGeneratedOnAddOrUpdate()
                             .HasDefaultValueSql("current_timestamp() ON UPDATE current_timestamp()");
        }
    }
}