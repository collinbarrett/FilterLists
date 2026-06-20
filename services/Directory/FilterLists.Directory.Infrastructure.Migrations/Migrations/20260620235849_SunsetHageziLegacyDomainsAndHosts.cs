using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SunsetHageziLegacyDomainsAndHosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2591, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2592, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2593, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2597, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2598, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2599, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2620, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2621, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2623, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2624, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2626, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2627, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2629, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2630, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2633, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2634, 182 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2591, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2592, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2593, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2597, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2598, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2599, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2620, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2621, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2623, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2624, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2626, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2627, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2629, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2630, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2633, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2634, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2591, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2592, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2592, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2593, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2597, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2598, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2598, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2599, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2620, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2621, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2623, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2624, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2626, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2627, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2629, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2630, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2633, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2634, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2591, 2856 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2592, 2857 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2593, 2858 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2597, 2862 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2598, 2863 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2599, 2864 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2620, 2886 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2621, 2887 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2623, 2889 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2624, 2890 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2626, 2892 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2627, 2893 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2629, 2895 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2630, 2896 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2633, 2899 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2634, 2900 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2591);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2597);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2598);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2599);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2621);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2626);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2627);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2629);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2634);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2591, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Multi DNS Blocklist (Hosts)", null, null, null },
                    { 2592, null, "Increases security significantly! Blocks Malware, Crypto, Coin, Spam, Scam and Phishing.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Threat Intelligence Feeds DNS Blocklist (Hosts)", null, null, null },
                    { 2593, null, "Protects against internet scams, traps & fakes! Blocks fake stores, -news, -science, -streaming, rip-offs, cost traps and co.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Fake DNS Blocklist (Hosts)", null, null, null },
                    { 2597, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Multi DNS Blocklist (Domains)", null, null, null },
                    { 2598, null, "Increases security significantly! Blocks Malware, Crypto, Coin, Spam, Scam and Phishing.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Threat Intelligence Feeds DNS Blocklist (Domains)", null, null, null },
                    { 2599, null, "Protects against internet scams, traps & fakes! Blocks fake stores, -news, -science, -streaming, rip-offs, cost traps and co.", null, null, null, "https://github.com/hagezi/dns-blocklists", null, 11, "HaGeZi's Fake DNS Blocklist (Domains)", null, null, null },
                    { 2620, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, some Malware and Fake.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Light DNS Blocklist (Domains)", null, null, null },
                    { 2621, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, some Malware and Fake.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Light DNS Blocklist (Hosts)", null, null, null },
                    { 2623, null, "Cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Pro DNS Blocklist (Domains)", null, null, null },
                    { 2624, null, "Cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Pro DNS Blocklist (Hosts)", null, null, null },
                    { 2626, null, "Aggressive cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Pro++ DNS Blocklist (Domains)", null, null, null },
                    { 2627, null, "Aggressive cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Pro++ DNS Blocklist (Hosts)", null, null, null },
                    { 2629, null, "Strictly cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking (+Referral), Metrics, Telemetry, Phishing, Malware, Scam, Free Hoster, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Ultimate DNS Blocklist (Domains)", null, null, null },
                    { 2630, null, "Strictly cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking (+Referral), Metrics, Telemetry, Phishing, Malware, Scam, Free Hoster, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Multi Ultimate DNS Blocklist (Hosts)", null, null, null },
                    { 2633, null, "My personal blocklist, an extension for known blocklists. Blocks ads, trackers, native device trackers, badware and more. Not intended to be used as a standalone blocklist, it serves as a addition for other blocklists!", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Personal DNS Blocklist (Domains)", null, null, null },
                    { 2634, null, "My personal blocklist, an extension for known blocklists. Blocks ads, trackers, native device trackers, badware and more. Not intended to be used as a standalone blocklist, it serves as a addition for other blocklists!", null, null, null, "https://github.com/hagezi/dns-blocklists", "https://github.com/hagezi/dns-blocklists/issues", 2, "HaGeZi's Personal DNS Blocklist (Hosts)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2591, 182 },
                    { 2592, 182 },
                    { 2593, 182 },
                    { 2597, 182 },
                    { 2598, 182 },
                    { 2599, 182 },
                    { 2620, 182 },
                    { 2621, 182 },
                    { 2623, 182 },
                    { 2624, 182 },
                    { 2626, 182 },
                    { 2627, 182 },
                    { 2629, 182 },
                    { 2630, 182 },
                    { 2633, 182 },
                    { 2634, 182 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2591, (short)1 },
                    { 2592, (short)1 },
                    { 2593, (short)1 },
                    { 2597, (short)2 },
                    { 2598, (short)2 },
                    { 2599, (short)2 },
                    { 2620, (short)2 },
                    { 2621, (short)1 },
                    { 2623, (short)2 },
                    { 2624, (short)1 },
                    { 2626, (short)2 },
                    { 2627, (short)1 },
                    { 2629, (short)2 },
                    { 2630, (short)1 },
                    { 2633, (short)2 },
                    { 2634, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2591, 1 },
                    { 2591, 2 },
                    { 2591, 3 },
                    { 2591, 4 },
                    { 2591, 6 },
                    { 2591, 7 },
                    { 2591, 9 },
                    { 2592, 6 },
                    { 2592, 7 },
                    { 2593, 15 },
                    { 2597, 1 },
                    { 2597, 2 },
                    { 2597, 3 },
                    { 2597, 4 },
                    { 2597, 6 },
                    { 2597, 7 },
                    { 2597, 9 },
                    { 2598, 6 },
                    { 2598, 7 },
                    { 2599, 15 },
                    { 2620, 3 },
                    { 2621, 3 },
                    { 2623, 3 },
                    { 2624, 3 },
                    { 2626, 3 },
                    { 2627, 3 },
                    { 2629, 3 },
                    { 2630, 3 },
                    { 2633, 3 },
                    { 2634, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2591, 2856, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/multi.txt" },
                    { 2592, 2857, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/tif.txt" },
                    { 2593, 2858, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/fake.txt" },
                    { 2597, 2862, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/multi.txt" },
                    { 2598, 2863, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/tif.txt" },
                    { 2599, 2864, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/fake.txt" },
                    { 2620, 2886, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/light.txt" },
                    { 2621, 2887, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/light.txt" },
                    { 2623, 2889, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/pro.txt" },
                    { 2624, 2890, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/pro.txt" },
                    { 2626, 2892, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/pro.plus.txt" },
                    { 2627, 2893, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/pro.plus.txt" },
                    { 2629, 2895, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/ultimate.txt" },
                    { 2630, 2896, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/ultimate.txt" },
                    { 2633, 2899, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/personal.txt" },
                    { 2634, 2900, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/personal.txt" }
                });
        }
    }
}
