using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class addTableCsvEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableCsv",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AddedDateUtc = table.Column<DateTime>(nullable: false),
                    ModifiedDateUtc = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 126, nullable: false),
                    Url = table.Column<string>(maxLength: 2083, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableCsv", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableCsv");
        }
    }
}
