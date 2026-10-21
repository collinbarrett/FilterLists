using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddUtilvoEdgeShieldCloudScraperList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2879, null, "Self-updating IPv4 CIDR blocklist targeting rotating-IP headless Chromium scrapers hosted on Tencent Cloud (AS132203), Alibaba Cloud (AS45102), Huawei Cloud (AS136907), and BytePlus (AS139902), while strictly whitelisting verified Googlebot, Bingbot, Applebot, and DuckDuckBot crawlers.", null, null, null, "https://utilvo.com/edge-shield", "https://github.com/utilvo/utilvo-edge-shield", 2, "Utilvo EdgeShield — Cloud Scraper CIDR Blocklist", null, null, null },
                    { 2880, null, "Zero-conflict Nginx http {} map configuration for blocking EdgeShield cloud scraper traffic.", null, null, null, "https://utilvo.com/edge-shield", "https://github.com/utilvo/utilvo-edge-shield", 2, "Utilvo EdgeShield — Nginx Bot Shield", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Syntax",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { (short)62, null, "Nginx geo/map", "https://utilvo.com/edge-shield/nginx-bot-shield.conf" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2879, 223 },
                    { 2880, 223 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2879, (short)34 },
                    { 2880, (short)62 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2879, 20 },
                    { 2880, 20 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
                values: new object[,]
                {
                    { 2879, 3288, (short)1, (short)1, "https://utilvo.com/api/edge-shield/threats?format=cidr" },
                    { 2880, 3289, (short)1, (short)1, "https://utilvo.com/edge-shield/nginx-bot-shield.conf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2879, 223 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2880, 223 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2879, (short)34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2880, (short)62 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2879, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2880, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2879, 3288 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2880, 3289 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2879);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2880);

            migrationBuilder.DeleteData(
                table: "Syntax",
                keyColumn: "Id",
                keyValue: (short)62);
        }
    }
}
