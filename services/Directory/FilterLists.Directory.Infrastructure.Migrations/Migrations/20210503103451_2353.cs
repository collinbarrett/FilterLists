using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2353 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2490, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (Snort 2)", null, null, null },
                    { 2491, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (Snort 3)", null, null, null },
                    { 2492, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (Suricata)", null, null, null },
                    { 2493, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (Snort 2)", null, null, null },
                    { 2494, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (Snort 3)", null, null, null },
                    { 2495, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (Suricata)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2490, 158 },
                    { 2495, 158 },
                    { 2491, 158 },
                    { 2492, 158 },
                    { 2493, 158 },
                    { 2494, 158 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2490, 6 },
                    { 2491, 6 },
                    { 2492, 6 },
                    { 2495, 7 },
                    { 2493, 7 },
                    { 2494, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2703, 2494, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-snort3.rules" },
                    { 2701, 2492, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-suricata-online.rules" },
                    { 2700, 2491, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-snort3-online.rules" },
                    { 2699, 2490, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-snort2-online.rules" },
                    { 2702, 2493, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-snort2.rules" },
                    { 2704, 2495, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-suricata.rules" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2490, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2491, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2492, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2493, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2494, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2495, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2490, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2491, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2492, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2493, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2494, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2495, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2495);
        }
    }
}
