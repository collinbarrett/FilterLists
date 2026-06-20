using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdGuardBaseFilterOptimizedMetadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1568,
                columns: new[] { "Description", "Name" },
                values: new object[] { "EasyList + AdGuard English filter. This filter is necessary for quality ad blocking.", "AdGuard Base filter + EasyList (Optimized)" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1568,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filter that enables removing of the ads from websites with English content or content in languages that lack separate AdGuard lists. The Optimized version is based on opt-in telemetry, is light on memory and comments, and gets below iOS/Safari filter limits.", "AdGuard Base Filter (Optimized)" });
        }
    }
}
