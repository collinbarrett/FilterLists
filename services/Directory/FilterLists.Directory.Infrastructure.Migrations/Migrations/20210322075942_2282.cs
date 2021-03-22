using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2282 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1920,
                column: "Url",
                value: "https://n2o.io/projects/quarklist/dist/quarklist.txt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1920,
                column: "Url",
                value: "https://n2o.io/p/quarklist/dist/quarklist.txt");
        }
    }
}
