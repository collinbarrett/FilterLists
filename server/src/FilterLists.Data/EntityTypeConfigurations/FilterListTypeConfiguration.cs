using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListTypeConfiguration : BaseEntityTypeConfiguration<FilterList>
    {
        public override void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            base.Configure(entityTypeBuilder);
            entityTypeBuilder.ToTable("filterlists");
            entityTypeBuilder.Property(x => x.ChatUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.Description)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.DescriptionSourceUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.DonateUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.EmailAddress)
                             .HasColumnType("VARCHAR(126)")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.ForumUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.HomeUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.IssuesUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.LicenseId)
                             .HasDefaultValue(5);
            entityTypeBuilder.Property(x => x.Name)
                             .HasColumnType("VARCHAR(126)")
                             .IsRequired();
            entityTypeBuilder.Property(x => x.PolicyUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.PublishedDate)
                             .HasColumnType("DATETIME")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.SubmissionUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.UpdatedDate)
                             .HasColumnType("DATETIME")
                             .HasDefaultValueSql("NULL");
            entityTypeBuilder.Property(x => x.ViewUrl)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.ViewUrlMirror1)
                             .HasColumnType("TEXT");
            entityTypeBuilder.Property(x => x.ViewUrlMirror2)
                             .HasColumnType("TEXT");
        }
    }
}