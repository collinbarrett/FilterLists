using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AddedDateUtc = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    DescriptionSourceUrl = table.Column<string>(maxLength: 2083, nullable: true),
                    DonateUrl = table.Column<string>(maxLength: 2083, nullable: true),
                    Email = table.Column<string>(maxLength: 254, nullable: true),
                    ForumUrl = table.Column<string>(maxLength: 2083, nullable: true),
                    HomeUrl = table.Column<string>(maxLength: 2083, nullable: true),
                    IssuesUrl = table.Column<string>(maxLength: 2083, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    ViewUrl = table.Column<string>(maxLength: 2083, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "List");
        }
    }
}
