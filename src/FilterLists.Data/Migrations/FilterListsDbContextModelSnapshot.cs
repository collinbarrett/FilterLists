using System;
using FilterLists.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FilterLists.Data.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    internal class FilterListsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("FilterLists.Data.Models.List", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("AddedDateUtc")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Author")
                    .HasMaxLength(126);

                b.Property<string>("Description")
                    .HasMaxLength(1022);

                b.Property<string>("DescriptionSourceUrl")
                    .HasMaxLength(2083);

                b.Property<string>("DonateUrl")
                    .HasMaxLength(2083);

                b.Property<string>("Email")
                    .HasMaxLength(126);

                b.Property<string>("ForumUrl")
                    .HasMaxLength(2083);

                b.Property<string>("HomeUrl")
                    .HasMaxLength(2083);

                b.Property<string>("IssuesUrl")
                    .HasMaxLength(2083);

                b.Property<DateTime?>("ModifiedDateUtc")
                    .ValueGeneratedOnAddOrUpdate();

                b.Property<string>("Name")
                    .HasMaxLength(126);

                b.Property<string>("ViewUrl")
                    .IsRequired()
                    .HasMaxLength(2083);

                b.HasKey("Id");

                b.ToTable("List");
            });

            modelBuilder.Entity("FilterLists.Data.Models.TableCsv", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("AddedDateUtc")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime?>("ModifiedDateUtc")
                    .ValueGeneratedOnAddOrUpdate();

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(126);

                b.Property<string>("Url")
                    .IsRequired()
                    .HasMaxLength(2083);

                b.HasKey("Id");

                b.ToTable("TableCsv");
            });
        }
    }
}