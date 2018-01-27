using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddScrapedAndUpdatedDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                "ScrapedDateUtc",
                "filterlists",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                "UpdatedDateUtc",
                "filterlists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ScrapedDateUtc",
                "filterlists");

            migrationBuilder.DropColumn(
                "UpdatedDateUtc",
                "filterlists");
        }
    }
}