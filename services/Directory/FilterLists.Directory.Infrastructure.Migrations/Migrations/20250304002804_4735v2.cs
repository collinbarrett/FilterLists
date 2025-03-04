using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4735v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2730,
                column: "Name",
                value: "Microsoft GitHub Less Social (Aggressive)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2730,
                column: "Name",
                value: "Microsoft GitHub Less Social");
        }
    }
}
