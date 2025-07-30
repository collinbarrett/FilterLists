using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddSuperSecurityFilterListMerges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Merge",
                columns: new[] { "IncludedInFilterListId", "IncludesFilterListId" },
                values: new object[,]
                {
                    { 2812, 692 },
                    { 2812, 1490 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Merge",
                keyColumns: new[] { "IncludedInFilterListId", "IncludesFilterListId" },
                keyValues: new object[] { 2812, 692 });

            migrationBuilder.DeleteData(
                table: "Merge",
                keyColumns: new[] { "IncludedInFilterListId", "IncludesFilterListId" },
                keyValues: new object[] { 2812, 1490 });
        }
    }
}
