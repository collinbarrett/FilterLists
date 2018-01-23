using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SoftwareSyntaxTypeConfiguration : BaseEntityTypeConfiguration<SoftwareSyntax>
    {
        public override void Configure(EntityTypeBuilder<SoftwareSyntax> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("software_syntaxes");
            entityTypeBuilder.HasKey(x => new {x.SoftwareId, x.SyntaxId});
            entityTypeBuilder.Ignore(x => x.Id);
            base.Configure(entityTypeBuilder);
        }
    }
}