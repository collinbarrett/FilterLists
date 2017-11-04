using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListTypeConfiguration : BaseEntityTypeConfiguration<FilterList>
    {
        public override void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filterlists");
            entityTypeBuilder.Property(x => x.Description)
                .HasMaxLength(4096);
            entityTypeBuilder.Property(x => x.DescriptionSourceUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.DonateUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.EmailAddress)
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.ForumUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.HomeUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.IssuesUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(126);
            entityTypeBuilder.Property(x => x.SubmissionUrl)
                .HasMaxLength(2083);
            entityTypeBuilder.Property(x => x.ViewUrl)
                .HasMaxLength(2083);
            base.Configure(entityTypeBuilder);
        }
    }
}