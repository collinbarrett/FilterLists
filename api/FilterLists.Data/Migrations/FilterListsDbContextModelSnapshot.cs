using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FilterLists.Data.Contexts;

namespace FilterLists.Data.Migrations
{
    [DbContext(typeof(FilterListsDbContext))]
    partial class FilterListsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("FilterLists.Models.List", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<string>("DescriptionSourceUrl");

                    b.Property<string>("DonateUrl");

                    b.Property<string>("Email");

                    b.Property<string>("ForumUrl");

                    b.Property<string>("HomeUrl");

                    b.Property<string>("IssuesUrl");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("ViewUrl");

                    b.HasKey("Id");

                    b.ToTable("List");
                });
        }
    }
}
