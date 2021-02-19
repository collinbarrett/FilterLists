using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2240 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1936,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1937,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1938,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1939,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/ip_blocklist.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1940,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/domains.rpz");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1941,
                column: "Url",
                value: "https://mkb2091.github.io/blockconvert/output/whitelist_domains.txt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1936,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1937,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1938,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1939,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/ip_blocklist.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1940,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/domains.rpz");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1941,
                column: "Url",
                value: "https://raw.githubusercontent.com/mkb2091/blockconvert/master/output/whitelist_domains.txt");
        }
    }
}
