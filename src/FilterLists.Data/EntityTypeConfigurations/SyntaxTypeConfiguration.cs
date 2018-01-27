using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
    {
        public void Configure(EntityTypeBuilder<Syntax> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("syntaxes");

            entityTypeBuilder.Property(x => x.Id)
                .HasColumnType("SMALLINT UNSIGNED");
            entityTypeBuilder.Property(x => x.CreatedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP");
            entityTypeBuilder.Property(x => x.ModifiedDateUtc)
                .HasColumnType("TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");
            
            entityTypeBuilder.Property(x => x.DefinitionUrl)
                .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Name)
                .HasColumnType("NVARCHAR(126) NOT NULL");
        }
    }
}