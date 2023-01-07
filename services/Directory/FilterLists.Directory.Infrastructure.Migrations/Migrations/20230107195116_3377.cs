using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3377 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2620L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, some Malware and Fake.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Light DNS Blocklist (Domains)", null, null, null },
                    { 2621L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, some Malware and Fake.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Light DNS Blocklist (Hosts)", null, null, null },
                    { 2622L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Tracking, Metrics, some Malware and Fake.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Light DNS Blocklist (Wildcard)", null, null, null },
                    { 2623L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro DNS Blocklist (Domains)", null, null, null },
                    { 2624L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro DNS Blocklist (Hosts)", null, null, null },
                    { 2625L, null, "Cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro DNS Blocklist (Wildcard)", null, null, null },
                    { 2626L, null, "Aggressive cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro++ DNS Blocklist (Domains)", null, null, null },
                    { 2627L, null, "Aggressive cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro++ DNS Blocklist (Hosts)", null, null, null },
                    { 2628L, null, "Aggressive cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking, Metrics, Telemetry, Phishing, Malware, Scam, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Pro++ DNS Blocklist (Wildcard)", null, null, null },
                    { 2629L, null, "Strictly cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking (+Referral), Metrics, Telemetry, Phishing, Malware, Scam, Free Hoster, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Ultimate DNS Blocklist (Domains)", null, null, null },
                    { 2630L, null, "Strictly cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking (+Referral), Metrics, Telemetry, Phishing, Malware, Scam, Free Hoster, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Ultimate DNS Blocklist (Hosts)", null, null, null },
                    { 2631L, null, "Strictly cleans the Internet and protects your privacy! Blocks Ads, Affiliate, Tracking (+Referral), Metrics, Telemetry, Phishing, Malware, Scam, Free Hoster, Fake, Coins and other Crap.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Multi Ultimate DNS Blocklist (Wildcard)", null, null, null },
                    { 2632L, null, "Increases security significantly! Blocks Malware, Crypto, Coin, Spam, Scam and Phishing.", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Threat Intelligence Feeds DNS Blocklist (Wildcard)", null, null, null },
                    { 2633L, null, "My personal blocklist, an extension for known blocklists. Blocks ads, trackers, native device trackers, badware and more. Not intended to be used as a standalone blocklist, it serves as a addition for other blocklists!", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Personal DNS Blocklist (Domains)", null, null, null },
                    { 2634L, null, "My personal blocklist, an extension for known blocklists. Blocks ads, trackers, native device trackers, badware and more. Not intended to be used as a standalone blocklist, it serves as a addition for other blocklists!", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Personal DNS Blocklist (Hosts)", null, null, null },
                    { 2635L, null, "My personal blocklist, an extension for known blocklists. Blocks ads, trackers, native device trackers, badware and more. Not intended to be used as a standalone blocklist, it serves as a addition for other blocklists!", null, null, null, "https://github.com/hagezi/dns-blocklists", true, "https://github.com/hagezi/dns-blocklists/issues", 2L, "HaGeZi's Personal DNS Blocklist (Wildcard)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2620L, 182L },
                    { 2621L, 182L },
                    { 2622L, 182L },
                    { 2623L, 182L },
                    { 2624L, 182L },
                    { 2625L, 182L },
                    { 2626L, 182L },
                    { 2627L, 182L },
                    { 2628L, 182L },
                    { 2629L, 182L },
                    { 2630L, 182L },
                    { 2631L, 182L },
                    { 2632L, 182L },
                    { 2633L, 182L },
                    { 2634L, 182L },
                    { 2635L, 182L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2620L, 2L },
                    { 2621L, 1L },
                    { 2622L, 16L },
                    { 2623L, 2L },
                    { 2624L, 1L },
                    { 2625L, 16L },
                    { 2626L, 2L },
                    { 2627L, 1L },
                    { 2628L, 16L },
                    { 2629L, 2L },
                    { 2630L, 1L },
                    { 2631L, 16L },
                    { 2632L, 16L },
                    { 2633L, 2L },
                    { 2634L, 1L },
                    { 2635L, 16L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2620L, 3L },
                    { 2621L, 3L },
                    { 2622L, 3L },
                    { 2623L, 3L },
                    { 2624L, 3L },
                    { 2625L, 3L },
                    { 2626L, 3L },
                    { 2627L, 3L },
                    { 2628L, 3L },
                    { 2629L, 3L },
                    { 2630L, 3L },
                    { 2631L, 3L },
                    { 2632L, 6L },
                    { 2633L, 3L },
                    { 2634L, 3L },
                    { 2635L, 3L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2620L, 2886L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/light.txt" },
                    { 2621L, 2887L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/light.txt" },
                    { 2622L, 2888L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/light.txt" },
                    { 2623L, 2889L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/pro.txt" },
                    { 2624L, 2890L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/pro.txt" },
                    { 2625L, 2891L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/pro.txt" },
                    { 2626L, 2892L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/pro.plus.txt" },
                    { 2627L, 2893L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/pro.plus.txt" },
                    { 2628L, 2894L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/pro.plus.txt" },
                    { 2629L, 2895L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/ultimate.txt" },
                    { 2630L, 2896L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/ultimate.txt" },
                    { 2631L, 2897L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/ultimate.txt" },
                    { 2632L, 2898L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/tif.txt" },
                    { 2633L, 2899L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/domains/personal.txt" },
                    { 2634L, 2900L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/hosts/personal.txt" },
                    { 2635L, 2901L, (short)1, "https://raw.githubusercontent.com/hagezi/dns-blocklists/main/wildcard/personal.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2620L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2621L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2622L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2623L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2624L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2625L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2626L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2627L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2628L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2629L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2630L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2631L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2632L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2633L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2634L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2635L, 182L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2620L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2621L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2622L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2623L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2624L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2625L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2626L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2627L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2628L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2629L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2630L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2631L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2632L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2633L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2634L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2635L, 16L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2620L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2621L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2622L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2623L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2624L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2625L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2626L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2627L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2628L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2629L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2630L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2631L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2632L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2633L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2634L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2635L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2620L, 2886L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2621L, 2887L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2622L, 2888L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2623L, 2889L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2624L, 2890L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2625L, 2891L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2626L, 2892L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2627L, 2893L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2628L, 2894L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2629L, 2895L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2630L, 2896L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2631L, 2897L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2632L, 2898L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2633L, 2899L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2634L, 2900L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2635L, 2901L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2620L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2621L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2622L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2623L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2624L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2625L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2626L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2627L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2628L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2629L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2630L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2631L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2632L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2633L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2634L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2635L);
        }
    }
}
