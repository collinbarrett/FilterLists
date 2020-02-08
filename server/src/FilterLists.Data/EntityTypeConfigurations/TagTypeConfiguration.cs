using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class TagTypeConfiguration : BaseEntityTypeConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("tags");
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .IsRequired();
            entityTypeBuilder.Property(x => x.Description)
                             .HasColumnType("TEXT");
        }
    }
}