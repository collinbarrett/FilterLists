using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListRuleTypeConfiguration : BaseJunctionTypeConfiguration<FilterListRule>
    {
        public override void Configure(EntityTypeBuilder<FilterListRule> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists_rules");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.RuleId});
        }
    }
}