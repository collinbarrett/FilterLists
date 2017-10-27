using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListTypeConfiguration : BaseEntityTypeConfiguration<FilterList>
    {
        public override void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            entityTypeBuilder.Property(b => b.Maintainer)
                .HasAnnotation("JsonIgnore", new JsonIgnoreAttribute());

            entityTypeBuilder.Property(b => b.Description)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "A brief description of the list's functionality. Preferably, this is quoted (if non-English, translate to English via translator or Google Translate for consistency) from the list's documentation or composed by a maintainer of the list. If neither are available, a generic description should be composed by the FilterLists contributor."))
                .HasMaxLength(1022);

            entityTypeBuilder.Property(b => b.DescriptionSourceUrl)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "The URL to the list's documentation page from which the description was quoted if applicable."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.DonateUrl)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "The URL to the list's donation page. This could be a custom PayPal or similar link, or a link to a web page discussing various donation options. Pull requests that include changes to this link will undergo further verification to prevent fraud."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.EmailAddress)
                .HasAnnotation("Description",
                    new DescriptionAttribute("The email address for communicating issues or comments about the list."))
                .HasAnnotation("EmailAddress", new EmailAddressAttribute())
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.ForumUrl)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "The URL to the list's forum where issues, change requests, etc. are discussed."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.HomeUrl)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "The URL to the list's home page. Preferably, this is stated in the header of the list. Alternatively, it could be a custom domain, GitHub page, blog post, forum post, etc. that serves as a primary source of information for the list."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.IssuesUrl)
                .HasAnnotation("Description", new DescriptionAttribute("The URL to the list's GitHub Issues."))
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.Name)
                .HasAnnotation("Description",
                    new DescriptionAttribute("The name of the list as stated by the list maintainer(s) in title case."))
                .IsRequired()
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.IssuesUrl)
                .HasAnnotation("Description",
                    new DescriptionAttribute(
                        "The URL to the list in raw text format. zip files and other formats are acceptable if no text format is available."))
                .IsRequired()
                .HasAnnotation("Url", new UrlAttribute())
                .HasMaxLength(2083);

            base.Configure(entityTypeBuilder);
        }
    }
}