using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListRuleTypeConfiguration : IEntityTypeConfiguration<FilterListRule>
    {
        public void Configure(EntityTypeBuilder<FilterListRule> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_rules");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.RuleId});
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
        }
    }
}