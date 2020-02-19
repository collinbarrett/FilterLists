using Ardalis.GuardClauses;
using FilterLists.Data.Entities.Junctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations.Junctions
{
    public class SoftwareSyntaxTypeConfiguration : BaseJunctionTypeConfiguration<SoftwareSyntax>
    {
        public override void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
        {
            Guard.Against.Null(builder, nameof(builder));
            base.Configure(builder);
            builder.ToTable("software_syntaxes");
            builder.HasKey(x => new {x.SyntaxId, x.SoftwareId});
            builder.HasOne(x => x.Software)
                .WithMany(x => x.SoftwareSyntaxes)
                .HasForeignKey(x => x.SoftwareId);
            builder.HasOne(x => x.Syntax)
                .WithMany(x => x.SoftwareSyntaxes)
                .HasForeignKey(x => x.SyntaxId);
        }
    }
}