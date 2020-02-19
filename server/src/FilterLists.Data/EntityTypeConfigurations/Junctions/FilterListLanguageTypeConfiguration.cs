using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListLanguageTypeConfiguration : BaseJunctionTypeConfiguration<FilterListLanguage>
    {
        public override void Configure(EntityTypeBuilder<FilterListLanguage> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("filterlists_languages");
            builder.HasKey(x => new {x.FilterListId, x.LanguageId});
            builder.HasOne(x => x.FilterList)
                .WithMany(x => x.FilterListLanguages)
                .HasForeignKey(x => x.FilterListId);
            builder.HasOne(x => x.Language)
                .WithMany(x => x.FilterListLanguages)
                .HasForeignKey(x => x.LanguageId);
        }
    }
}