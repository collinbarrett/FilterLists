using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3486 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2731L },
                column: "url",
                value: "https://raw.githubusercontent.com/JohnyP36/Personal-List/cdn-page/Dutch Filter List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2812L },
                column: "url",
                value: "https://cdn.statically.io/gh/JohnyP36/Personal-List/cdn-page/Dutch Filter List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2813L },
                column: "url",
                value: "https://raw.githubusercontent.com/JohnyP36/Personal-List/main/Personal List (uBo).txt");

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2519L, 2914L, (short)4, "https://cdn.statically.io/gh/JohnyP36/Personal-List/main/Personal List (uBo).txt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2914L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2731L },
                column: "url",
                value: "https://raw.githubusercontent.com/JohnyP36/Personal-List/main/Personal List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2812L },
                column: "url",
                value: "https://www.combinatronics.com/JohnyP36/Personal-List/main/Personal List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2813L },
                column: "url",
                value: "https://cdn.statically.io/gh/JohnyP36/Personal-List/main/Personal List (uBo).txt");
        }
    }
}
