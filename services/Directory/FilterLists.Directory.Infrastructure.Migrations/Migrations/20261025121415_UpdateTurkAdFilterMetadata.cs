using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTurkAdFilterMetadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2859, 3266 });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2859,
                columns: new[] { "EmailAddress", "ForumUrl", "PolicyUrl" },
                values: new object[] { "info@reklamsiz-turkiye.com", "https://github.com/omerdduran/turk-adfilter/discussions", "https://reklamsiz-turkiye.com/docs/gizlilik" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2860,
                columns: new[] { "EmailAddress", "ForumUrl", "PolicyUrl" },
                values: new object[] { "info@reklamsiz-turkiye.com", "https://github.com/omerdduran/turk-adfilter/discussions", "https://reklamsiz-turkiye.com/docs/gizlilik" });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 216,
                column: "EmailAddress",
                value: "info@reklamsiz-turkiye.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2859,
                columns: new[] { "EmailAddress", "ForumUrl", "PolicyUrl" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2860,
                columns: new[] { "EmailAddress", "ForumUrl", "PolicyUrl" },
                values: new object[] { null, null, null });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[] { 2859, 3266, (short)2, "https://codeberg.org/omerdduran/turk-adfilter/raw/branch/main/turk-adfilter.txt" });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 216,
                column: "EmailAddress",
                value: null);
        }
    }
}
