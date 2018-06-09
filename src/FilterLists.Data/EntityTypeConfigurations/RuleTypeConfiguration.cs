using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class RuleTypeConfiguration : BaseEntityTypeConfiguration<Rule>
    {
        public override void Configure(EntityTypeBuilder<Rule> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("rules");
            entityTypeBuilder.Property(x => x.Id)
                             .HasColumnType("INT"/* UNSIGNED"*/);
            entityTypeBuilder.Ignore(x => x.ModifiedDateUtc);
            entityTypeBuilder.Property(x => x.Raw)
                             .HasColumnType("VARCHAR(8192)")
                             .IsRequired();
        }
    }
}