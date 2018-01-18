using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SyntaxTypeConfiguration : BaseEntityTypeConfiguration<Syntax>
    {
        public override void Configure(EntityTypeBuilder<Syntax> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("syntaxes");
            entityTypeBuilder.Property(x => x.DefinitionUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(126);
            base.Configure(entityTypeBuilder);
        }
    }
}