using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class FilterListLanguageTypeConfiguration : BaseJunctionTypeConfiguration<FilterListLanguage>
    {
        public override void Configure(EntityTypeBuilder<FilterListLanguage> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists_languages");
            entityTypeBuilder.HasKey(x => new {x.FilterListId, x.LanguageId});
            entityTypeBuilder.HasOne(x => x.FilterList)
                             .WithMany(x => x.FilterListLanguages)
                             .HasForeignKey(x => x.FilterListId);
            entityTypeBuilder.HasOne(x => x.Language)
                             .WithMany(x => x.FilterListLanguages)
                             .HasForeignKey(x => x.LanguageId);
        }
    }
}