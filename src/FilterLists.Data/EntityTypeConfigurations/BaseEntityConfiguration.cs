using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(b => b.Id);

            entityTypeBuilder.Property(b => b.Id)
                .HasAnnotation("JsonIgnore", new JsonIgnoreAttribute())
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(b => b.CreatedDateUtc)
                .HasAnnotation("JsonIgnore", new JsonIgnoreAttribute())
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnAdd();

            entityTypeBuilder.Property(b => b.ModifiedDateUtc)
                .HasAnnotation("JsonIgnore", new JsonIgnoreAttribute())
                .HasColumnType("TIMESTAMP")
                .ValueGeneratedOnUpdate();
        }
    }
}