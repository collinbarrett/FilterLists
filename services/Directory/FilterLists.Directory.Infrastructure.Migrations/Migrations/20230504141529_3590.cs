using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3590 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[,]
                {
                    { 2519L, 4L },
                    { 2519L, 48L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2812L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/JohnyP36/Personal-List@cdn-page/Dutch Filter List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2813L },
                column: "url",
                value: "https://cdn.statically.io/gh/JohnyP36/Personal-List/cdn-page/Dutch Filter List (uBo).txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2923L },
                column: "url",
                value: "https://raw.githubusercontent.com/JohnyP36/Personal-List/main/Personal List (uBo).txt");

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2519L, 2937L, (short)5, "https://cdn.statically.io/gh/JohnyP36/Personal-List/main/Personal List (uBo).txt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2519L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2519L, 48L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2937L });

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

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2519L, 2923L },
                column: "url",
                value: "https://cdn.statically.io/gh/JohnyP36/Personal-List/main/Personal List (uBo).txt");
        }
    }
}
