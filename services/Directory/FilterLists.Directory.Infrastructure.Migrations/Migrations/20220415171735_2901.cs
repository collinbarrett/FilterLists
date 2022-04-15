using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2901 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2100L, 2206L },
                column: "url",
                value: "https://raw.githubusercontent.com/Kees1958/W3C_annual_most_used_survey_blocklist/master/EU_US%2Bmost_used_ad_and_tracking_networks");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2100L,
                column: "name",
                value: "EU US most prevalent ads & trackers ABP format for uBlockOrigin and Adguard.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2100L, 2206L },
                column: "url",
                value: "https://raw.githubusercontent.com/Kees1958/WS3_annual_most_used_survey_blocklist/master/Top500");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2100L,
                column: "name",
                value: "Small but effective adblockplus format blocklist based on the (annal) W3tech and Cookiebot surveys - Top 500");
        }
    }
}
