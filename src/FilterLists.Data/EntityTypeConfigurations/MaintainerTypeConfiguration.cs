using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class MaintainerTypeConfiguration : BaseEntityTypeConfiguration<Maintainer>
    {
        public override void Configure(EntityTypeBuilder<Maintainer> entityTypeBuilder)
        {
            entityTypeBuilder.Property(b => b.Email)
                .HasAnnotation("Description", new DescriptionAttribute("The email address of the list maintainer."))
                .HasAnnotation("EmailAddress", new EmailAddressAttribute())
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.HomeUrl)
                .HasAnnotation("Description", new DescriptionAttribute("The URL to the list maintainer's home page."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.Name)
                .HasAnnotation("Description", new DescriptionAttribute("The name of the list maintainer."))
                .IsRequired()
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.TwitterHandle)
                .HasAnnotation("Description", new DescriptionAttribute("The Twitter handle of the list maintainer."))
                .HasMaxLength(126);

            base.Configure(entityTypeBuilder);
        }
    }
}