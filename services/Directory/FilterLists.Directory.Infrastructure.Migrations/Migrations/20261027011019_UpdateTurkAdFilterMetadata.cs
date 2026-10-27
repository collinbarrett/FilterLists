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
                columns: new[] { "ForumUrl", "PolicyUrl" },
                values: new object[] { "https://github.com/omerdduran/turk-adfilter/discussions", "https://reklamsiz-turkiye.com/docs/gizlilik" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2860,
                columns: new[] { "ForumUrl", "PolicyUrl" },
                values: new object[] { "https://github.com/omerdduran/turk-adfilter/discussions", "https://reklamsiz-turkiye.com/docs/gizlilik" });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 216,
                column: "EmailAddress",
                value: "me@omerduran.dev");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2859,
                columns: new[] { "ForumUrl", "PolicyUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2860,
                columns: new[] { "ForumUrl", "PolicyUrl" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
                values: new object[] { 2859, 3266, (short)2, (short)0, "https://codeberg.org/omerdduran/turk-adfilter/raw/branch/main/turk-adfilter.txt" });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 216,
                column: "EmailAddress",
                value: null);
        }
    }
}
