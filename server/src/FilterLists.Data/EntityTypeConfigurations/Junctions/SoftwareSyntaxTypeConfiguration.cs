using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SoftwareSyntaxTypeConfiguration : BaseJunctionTypeConfiguration<SoftwareSyntax>
    {
        public override void Configure(EntityTypeBuilder<SoftwareSyntax> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("software_syntaxes");
            entityTypeBuilder.HasKey(x => new {x.SyntaxId, x.SoftwareId});
            entityTypeBuilder.HasOne(x => x.Software)
                             .WithMany(x => x.SoftwareSyntaxes)
                             .HasForeignKey(x => x.SoftwareId);
            entityTypeBuilder.HasOne(x => x.Syntax)
                             .WithMany(x => x.SoftwareSyntaxes)
                             .HasForeignKey(x => x.SyntaxId);
        }
    }
}