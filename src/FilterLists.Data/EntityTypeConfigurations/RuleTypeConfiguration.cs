using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class RuleTypeConfiguration : BaseEntityTypeConfiguration<Rule>
    {
        public override void Configure(EntityTypeBuilder<Rule> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("rules");
            entityTypeBuilder.Property(x => x.Raw)
                .IsUnicode()
                .HasMaxLength(2083);
            base.Configure(entityTypeBuilder);
        }
    }
}