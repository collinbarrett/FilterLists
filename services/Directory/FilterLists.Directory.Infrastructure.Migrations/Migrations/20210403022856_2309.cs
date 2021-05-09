using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2309 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2425, 22 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2472,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2475,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2478,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2481,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2484,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-bind.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2487,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-unbound.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2612,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-agh.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2613,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-ag.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2614,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter-vivaldi.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2640,
                column: "Url",
                value: "https://curben.gitlab.io/malware-filter/phishing-filter.tpl");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2471, null, "My own Dutch supplement for the Easylist filters", null, null, null, "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues", 4, "EasyDutch", null, null, null },
                    { 2472, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (RPZ)", null, null, null },
                    { 2473, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (RPZ)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainers",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 158, null, "Ming Di Leom", null, "https://mdleom.com/" });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[] { 2471, "nl" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2438, 158 },
                    { 2437, 158 },
                    { 2424, 158 },
                    { 2423, 158 },
                    { 2422, 158 },
                    { 2421, 158 },
                    { 2420, 158 },
                    { 2419, 158 },
                    { 2328, 158 },
                    { 2327, 158 },
                    { 2326, 158 },
                    { 2325, 158 },
                    { 2324, 158 },
                    { 2323, 158 },
                    { 2171, 158 },
                    { 2169, 158 },
                    { 2167, 158 },
                    { 2165, 158 },
                    { 1880, 158 },
                    { 1603, 158 },
                    { 2472, 158 },
                    { 2473, 158 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2473, 25 },
                    { 2472, 25 },
                    { 2471, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2473, 7 },
                    { 2472, 6 },
                    { 2471, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2681, 2473, (short)1, "https://curben.gitlab.io/malware-filter/phishing-filter-rpz.conf" },
                    { 2680, 2472, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-rpz-online.conf" },
                    { 2679, 2471, (short)1, "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/easydutch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2471, "nl" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1603, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1880, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2165, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2167, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2169, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2171, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2323, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2324, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2325, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2326, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2327, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2328, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2419, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2420, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2421, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2422, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2423, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2424, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2437, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2438, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2472, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2473, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2471, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2472, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2473, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2471, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2472, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2473, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2425, 22 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2472,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2475,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2478,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2481,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2484,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-bind.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2487,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-unbound.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2612,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-agh.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2613,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-ag.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2614,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter-vivaldi.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2640,
                column: "Url",
                value: "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter.tpl");
        }
    }
}
