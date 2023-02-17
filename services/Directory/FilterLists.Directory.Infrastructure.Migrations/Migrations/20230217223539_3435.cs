using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3435 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2290L, 2435L },
                column: "url",
                value: "https://raw.githubusercontent.com/liamengland1/miscfilters/master/antipaywall.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2291L, 2436L },
                column: "url",
                value: "https://raw.githubusercontent.com/liamengland1/mischosts/master/blacklist");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2290L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/liamengland1/miscfilters", "https://github.com/liamengland1/miscfilters/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2291L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/liamengland1/mischosts", "https://github.com/liamengland1/mischosts/issues" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2290L, 2435L },
                column: "url",
                value: "https://raw.githubusercontent.com/llacb47/miscfilters/master/antipaywall.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2291L, 2436L },
                column: "url",
                value: "https://raw.githubusercontent.com/llacb47/mischosts/master/blacklist");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2290L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/llacb47/miscfilters", "https://github.com/llacb47/miscfilters/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2291L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/llacb47/mischosts", "https://github.com/llacb47/mischosts/issues" });
        }
    }
}
