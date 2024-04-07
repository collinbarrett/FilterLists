using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4219 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2657L, 3L },
                    { 2657L, 6L },
                    { 2657L, 16L },
                    { 2657L, 20L },
                    { 2657L, 24L },
                    { 2657L, 28L },
                    { 2658L, 2L },
                    { 2658L, 6L },
                    { 2658L, 16L },
                    { 2658L, 20L },
                    { 2658L, 24L },
                    { 2658L, 28L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2657L, 6L },
                    { 2658L, 6L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2657L, 2935L },
                column: "url",
                value: "https://raw.githubusercontent.com/jarelllama/Scam-Blocklist/main/lists/adblock/scams.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2658L, 2936L },
                column: "url",
                value: "https://raw.githubusercontent.com/jarelllama/Scam-Blocklist/main/lists/adblock/scams_light.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2657L,
                columns: new[] { "description", "license_id" },
                values: new object[] { "Blocklist for newly created scam domains retrieved daily using Google Search API, automated detection, and other public sources.", 4L });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2658L,
                columns: new[] { "description", "license_id", "name" },
                values: new object[] { "Light version of Jarelllama's Scam Blocklist.", 4L, "Jarelllama's Scam Blocklist LIGHT VERSION" });

            migrationBuilder.InsertData(
                table: "merges",
                columns: new[] { "included_in_filter_list_id", "includes_filter_list_id" },
                values: new object[] { 2657L, 2658L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 20L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 24L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2657L, 28L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 20L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 24L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2658L, 28L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2657L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2658L, 6L });

            migrationBuilder.DeleteData(
                table: "merges",
                keyColumns: new[] { "included_in_filter_list_id", "includes_filter_list_id" },
                keyValues: new object[] { 2657L, 2658L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2657L, 2935L },
                column: "url",
                value: "https://raw.githubusercontent.com/jarelllama/Scam-Blocklist/main/domains.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2658L, 2936L },
                column: "url",
                value: "https://raw.githubusercontent.com/jarelllama/Scam-Blocklist/main/adblock.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2657L,
                columns: new[] { "description", "license_id" },
                values: new object[] { "Blocklist for scam sites extracted from Google", 5L });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2658L,
                columns: new[] { "description", "license_id", "name" },
                values: new object[] { "Blocklist for scam sites extracted from Google", 5L, "Jarelllama's Scam Blocklist (ABP syntax)" });
        }
    }
}
