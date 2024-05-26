using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4304 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2603L, 2867L },
                column: "url",
                value: "https://raw.githubusercontent.com/bpc-clone/bypass-paywalls-clean-filters/main/bpc-paywall-filter.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2603L,
                columns: new[] { "description", "home_url" },
                values: new object[] { "Filters for news sites (supports less sites than the extension/add-on)", "https://github.com/bpc-clone/bypass-paywalls-clean-filters" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2603L, 2867L },
                column: "url",
                value: "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters/-/raw/main/bpc-paywall-filter.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2603L,
                columns: new[] { "description", "home_url" },
                values: new object[] { "Adblocker list (experimental) which allows you to read articles from (supported) sites that implement a paywall. For some sites it will log you out (or block you to log in); caused by removing cookies or blocking general paywall-scripts. Disclaimer: the list doesn't support as many sites as the extension/add-on though.", "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters" });
        }
    }
}
