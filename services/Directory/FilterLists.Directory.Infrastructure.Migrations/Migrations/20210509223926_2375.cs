using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2375 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Description", "LicenseId", "Name" },
                values: new object[] { "The complete catalog for your content blocker!", 2, "Columbia by Osborne" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Description", "LicenseId", "Name" },
                values: new object[] { "A systematic Internet filter halting analytics.", 5, "Columbia Analytica" });
        }
    }
}
