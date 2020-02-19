using Ardalis.GuardClauses;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class RuleTypeConfiguration : BaseEntityTypeConfiguration<Rule>
    {
        public override void Configure(EntityTypeBuilder<Rule> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("rules");
            builder.Property(x => x.Id)
                .HasColumnType("INT");
            builder.Ignore(x => x.ModifiedDateUtc);
            builder.Property(x => x.Raw)
                .HasColumnType("LONGTEXT")
                .IsRequired();
        }
    }
}