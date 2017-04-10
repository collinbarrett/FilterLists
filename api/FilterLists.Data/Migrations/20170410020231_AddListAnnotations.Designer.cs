using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FilterLists.Data.Contexts;

namespace FilterLists.Data.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    [Migration("20170410020231_AddListAnnotations")]
    partial class AddListAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("FilterLists.Models.List", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDateUtc")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<string>("DescriptionSourceUrl")
                        .HasMaxLength(6);

                    b.Property<string>("DonateUrl")
                        .HasMaxLength(6);

                    b.Property<string>("Email")
                        .HasMaxLength(7);

                    b.Property<string>("ForumUrl")
                        .HasMaxLength(6);

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(6);

                    b.Property<string>("IssuesUrl")
                        .HasMaxLength(6);

                    b.Property<DateTime>("ModifiedDateUtc")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<string>("ViewUrl")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.ToTable("List");
                });
        }
    }
}
