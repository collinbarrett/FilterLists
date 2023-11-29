using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3951 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2440L, 2642L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/main/filters/social.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2441L, 2643L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/main/filters/nsfw.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2442L, 2644L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/main/filters/main.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2440L, 2642L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/social/filter_list.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2441L, 2643L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/porn_gambling_snuff/filter_list.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2442L, 2644L },
                column: "url",
                value: "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/regional/filter_list.txt");
        }
    }
}
