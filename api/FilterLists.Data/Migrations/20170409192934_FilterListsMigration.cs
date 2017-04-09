using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class FilterListsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "List",
                table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DescriptionSourceUrl = table.Column<string>(nullable: true),
                    DonateUrl = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ForumUrl = table.Column<string>(nullable: true),
                    HomeUrl = table.Column<string>(nullable: true),
                    IssuesUrl = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ViewUrl = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_List", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "List");
        }
    }
}