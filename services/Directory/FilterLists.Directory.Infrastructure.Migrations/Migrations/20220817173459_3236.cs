using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3236 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2609L, 2875L },
                column: "url",
                value: "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianBlockerHosts.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2608L,
                column: "license_id",
                value: 43L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2609L,
                columns: new[] { "description", "license_id", "name" },
                values: new object[] { "Finally, an optimal and extensive list for blocking ads and trackers on Persian language sites! (Domains edition)", 43L, "PersianBlockerHosts: List of Regional Persian/Iranian Domains-Only Blocklist" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2609L, 2875L },
                column: "url",
                value: "https://raw.githubusercontent.com/MasterKia/PersianBlocker/main/PersianPiHole.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2608L,
                column: "license_id",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2609L,
                columns: new[] { "description", "license_id", "name" },
                values: new object[] { "Finally, an optimal and extensive list for blocking ads and trackers on Persian language sites! (PiHole domains edition)", 4L, "PersianPiHole: List of Regional Persian/Iranian Domains-Only Blocklist" });
        }
    }
}
