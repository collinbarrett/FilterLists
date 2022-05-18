using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3063 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2550L, 2770L },
                column: "url",
                value: "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/adblock/whitelist-referral.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2550L,
                columns: new[] { "email_address", "home_url", "name" },
                values: new object[] { null, "https://github.com/hagezi/dns-blocklists", "HaGeZi's Referral Whitelist" });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2591L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Multi DNS Blocklist (Hosts)", null, null, null },
                    { 2592L, null, "Increases security significantly! Blocks Malware, Crypto, Coin, Spam, Scam and Phishing.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Threat Intelligence Feeds DNS Blocklist (Hosts)", null, null, null },
                    { 2593L, null, "Protects against internet scams, traps & fakes! Blocks fake stores, -news, -science, -streaming, rip-offs, cost traps and co.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Fake DNS Blocklist (Hosts)", null, null, null },
                    { 2594L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Multi DNS Blocklist (AdBlock/AdGuard)", null, null, null },
                    { 2595L, null, "Increases security significantly! Blocks Malware, Crypto, Coin, Spam, Scam and Phishing.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Threat Intelligence Feeds DNS Blocklist (AdBlock/AdGuard)", null, null, null },
                    { 2596L, null, "Protects against internet scams, traps & fakes! Blocks fake stores, -news, -science, -streaming, rip-offs, cost traps and co.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, null, 11L, "HaGeZi's Fake DNS Blocklist (AdBlock/AdGuard)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2591L, 1L },
                    { 2592L, 1L },
                    { 2593L, 1L },
                    { 2594L, 47L },
                    { 2595L, 47L },
                    { 2596L, 47L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2591L, 1L },
                    { 2591L, 2L },
                    { 2591L, 3L },
                    { 2591L, 4L },
                    { 2591L, 6L },
                    { 2591L, 7L },
                    { 2591L, 9L },
                    { 2592L, 6L },
                    { 2592L, 7L },
                    { 2593L, 15L },
                    { 2594L, 1L },
                    { 2594L, 2L },
                    { 2594L, 3L },
                    { 2594L, 4L },
                    { 2594L, 6L },
                    { 2594L, 7L },
                    { 2594L, 9L },
                    { 2595L, 6L },
                    { 2595L, 7L },
                    { 2596L, 15L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2591L, 2856L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/multi.txt" },
                    { 2592L, 2857L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/tif.txt" },
                    { 2593L, 2858L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/fake.txt" },
                    { 2594L, 2859L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/adblock/multi.txt" },
                    { 2595L, 2860L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/adblock/tif.txt" },
                    { 2596L, 2861L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/adblock/fake.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2591L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2592L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2593L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2594L, 47L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2595L, 47L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2596L, 47L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2591L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2592L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2592L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2593L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2594L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2595L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2595L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2596L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2591L, 2856L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2592L, 2857L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2593L, 2858L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2594L, 2859L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2595L, 2860L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2596L, 2861L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2591L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2592L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2593L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2594L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2595L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2596L);

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2550L, 2770L },
                column: "url",
                value: "https://raw.githubusercontent.com/Zelo72/adguard/main/whitelist.referral.adguard");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2550L,
                columns: new[] { "email_address", "home_url", "name" },
                values: new object[] { "zelo72@dismail.de", "https://github.com/Zelo72/adguard", "Zelo72's Referral Whitelist" });
        }
    }
}
