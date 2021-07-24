using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2477 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2514, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (dnscrypt-proxy names)", null, null, null },
                    { 2515, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (dnscrypt-proxy IPs)", null, null, null },
                    { 2516, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (dnscrypt-proxy names)", null, null, null },
                    { 2517, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (dnscrypt-proxy IPs)", null, null, null },
                    { 2518, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (dnscrypt-proxy names)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2514, 158 },
                    { 2518, 158 },
                    { 2515, 158 },
                    { 2517, 158 },
                    { 2516, 158 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2518, 2 },
                    { 2517, 9 },
                    { 2516, 2 },
                    { 2515, 9 },
                    { 2514, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2515, 6 },
                    { 2518, 6 },
                    { 2516, 7 },
                    { 2517, 7 },
                    { 2514, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2728, 2516, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-dnscrypt-blocked-names.txt" },
                    { 2726, 2514, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-dnscrypt-blocked-names-online.txt" },
                    { 2729, 2517, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-dnscrypt-blocked-ips.txt" },
                    { 2727, 2515, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-dnscrypt-blocked-ips-online.txt" },
                    { 2730, 2518, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-dnscrypt-blocked-names.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2514, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2515, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2516, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2517, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2518, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2514, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2515, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2516, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2517, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2518, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2514, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2515, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2516, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2517, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2518, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2727);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2728);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2729);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2518);
        }
    }
}
