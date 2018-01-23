using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListRuleTypeConfiguration : BaseEntityTypeConfiguration<FilterListRule>
    {
        public override void Configure(EntityTypeBuilder<FilterListRule> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists_rules");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.RuleId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}