using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2352 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2476, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter", null, null, null },
                    { 2477, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Domains)", null, null, null },
                    { 2478, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (dnsmasq)", null, null, null },
                    { 2479, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Hosts)", null, null, null },
                    { 2480, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (BIND)", null, null, null },
                    { 2481, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Unbound)", null, null, null },
                    { 2482, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (AdGuard Home)", null, null, null },
                    { 2483, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (AdGuard)", null, null, null },
                    { 2484, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Vivaldi)", null, null, null },
                    { 2485, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (IE)", null, null, null },
                    { 2486, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (RPZ)", null, null, null },
                    { 2487, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Snort 2)", null, null, null },
                    { 2488, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Snort 3)", null, null, null },
                    { 2489, null, "A block of websites that host potentially unwanted programs", null, null, null, "https://gitlab.com/curben/pup-filter", "https://gitlab.com/curben/pup-filter/issues", 3, "pup-filter (Suricata)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2476, 158 },
                    { 2486, 158 },
                    { 2483, 158 },
                    { 2481, 158 },
                    { 2479, 158 },
                    { 2487, 158 },
                    { 2485, 158 },
                    { 2480, 158 },
                    { 2478, 158 },
                    { 2488, 158 },
                    { 2477, 158 },
                    { 2489, 158 },
                    { 2484, 158 },
                    { 2482, 158 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2482, 47 },
                    { 2481, 24 },
                    { 2484, 6 },
                    { 2485, 10 },
                    { 2486, 25 },
                    { 2480, 26 },
                    { 2479, 1 },
                    { 2478, 20 },
                    { 2477, 2 },
                    { 2476, 4 },
                    { 2483, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2486, 6 },
                    { 2484, 6 },
                    { 2487, 6 },
                    { 2488, 6 },
                    { 2485, 6 },
                    { 2482, 6 },
                    { 2479, 6 },
                    { 2476, 6 },
                    { 2489, 6 },
                    { 2481, 6 },
                    { 2477, 6 },
                    { 2480, 6 },
                    { 2483, 6 },
                    { 2478, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2697, 2488, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-snort3.rules" },
                    { 2685, 2476, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter.txt" },
                    { 2696, 2487, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-snort2.rules" },
                    { 2686, 2477, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-domains.txt" },
                    { 2692, 2483, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-ag.txt" },
                    { 2687, 2478, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-dnsmasq.conf" },
                    { 2688, 2479, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-hosts.txt" },
                    { 2694, 2485, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter.tpl" },
                    { 2689, 2480, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-bind.conf" },
                    { 2693, 2484, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-vivaldi.txt" },
                    { 2690, 2481, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-unbound.conf" },
                    { 2691, 2482, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-agh.txt" },
                    { 2695, 2486, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-rpz.conf" },
                    { 2698, 2489, (short)1, "https://curben.gitlab.io/malware-filter/pup-filter-suricata.conf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2476, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2477, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2478, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2479, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2480, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2481, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2482, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2483, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2484, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2485, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2486, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2487, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2488, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2489, 158 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2476, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2477, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2478, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2479, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2480, 26 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2481, 24 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2482, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2483, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2484, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2485, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2486, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2476, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2477, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2478, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2479, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2480, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2481, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2482, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2483, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2484, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2485, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2486, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2487, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2488, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2489, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2489);
        }
    }
}
