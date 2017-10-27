using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Data.EntityTypeConfigurations
{
    public class FilterListTypeConfiguration : BaseEntityTypeConfiguration<FilterList>
    {
        public override void Configure(EntityTypeBuilder<FilterList> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("filter_lists");

            entityTypeBuilder.Property(b => b.Description)
                .HasMaxLength(1022);

            entityTypeBuilder.Property(b => b.DescriptionSourceUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.DonateUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.EmailAddress)
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.ForumUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.HomeUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.IssuesUrl)
                .HasMaxLength(2083);

            entityTypeBuilder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(126);

            entityTypeBuilder.Property(b => b.ViewUrl)
                .HasMaxLength(2083);

            base.Configure(entityTypeBuilder);
        }
    }
}