using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SoftwareSyntaxTypeConfiguration : JunctionBaseTypeConfiguration<SoftwareSyntax>
    {
        public override void Configure(EntityTypeBuilder<SoftwareSyntax> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("software_syntaxes");
            entityTypeBuilder.HasKey(x => new {x.SoftwareId, x.SyntaxId});
        }
    }
}