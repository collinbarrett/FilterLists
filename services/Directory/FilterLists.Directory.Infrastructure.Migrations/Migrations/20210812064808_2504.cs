using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2504 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2679,
                column: "Url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/easydutch.txt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2679,
                column: "Url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/easydutch");
        }
    }
}
