using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2876 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2568L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter", null, null, null },
                    { 2569L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (Domains)", null, null, null },
                    { 2570L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (dnsmasq)", null, null, null },
                    { 2571L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (hosts)", null, null, null },
                    { 2572L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (BIND)", null, null, null },
                    { 2573L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (Unbound)", null, null, null },
                    { 2574L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (AdGuard Home)", null, null, null },
                    { 2575L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (AdGuard)", null, null, null },
                    { 2576L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (Vivaldi)", null, null, null },
                    { 2577L, null, "A blocklist of malicious domains targeting Vietnamese users.", null, null, null, "https://gitlab.com/curben/vn-badsite-filter", true, "https://gitlab.com/curben/vn-badsite-filter/issues", 28L, "vn-badsite-filter (IE)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[,]
                {
                    { 2568L, 171L },
                    { 2569L, 171L },
                    { 2570L, 171L },
                    { 2571L, 171L },
                    { 2572L, 171L },
                    { 2573L, 171L },
                    { 2574L, 171L },
                    { 2575L, 171L },
                    { 2576L, 171L },
                    { 2577L, 171L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2568L, 158L },
                    { 2569L, 158L },
                    { 2570L, 158L },
                    { 2571L, 158L },
                    { 2572L, 158L },
                    { 2573L, 158L },
                    { 2574L, 158L },
                    { 2575L, 158L },
                    { 2576L, 158L },
                    { 2577L, 158L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2568L, 8L },
                    { 2569L, 2L },
                    { 2570L, 20L },
                    { 2571L, 1L },
                    { 2572L, 26L },
                    { 2573L, 24L },
                    { 2574L, 47L },
                    { 2575L, 6L },
                    { 2576L, 6L },
                    { 2577L, 10L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2568L, 2835L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter.txt" },
                    { 2569L, 2836L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-domains.txt" },
                    { 2570L, 2836L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-dnsmasq.conf" },
                    { 2571L, 2837L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-hosts.txt" },
                    { 2572L, 2838L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-bind.conf" },
                    { 2573L, 2839L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-unbound.conf" },
                    { 2574L, 2840L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-agh.txt" },
                    { 2575L, 2841L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-ag.txt" },
                    { 2576L, 2842L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter-vivaldi.txt" },
                    { 2577L, 2842L, (short)1, "https://curben.gitlab.io/malware-filter/vn-badsite-filter.tpl" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2568L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2569L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2570L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2571L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2572L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2573L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2574L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2575L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2576L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2577L, 171L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2568L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2569L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2570L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2571L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2572L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2573L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2574L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2575L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2576L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2577L, 158L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2568L, 8L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2569L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2570L, 20L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2571L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2572L, 26L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2573L, 24L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2574L, 47L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2575L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2576L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2577L, 10L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2568L, 2835L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2569L, 2836L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2570L, 2836L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2571L, 2837L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2572L, 2838L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2573L, 2839L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2574L, 2840L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2575L, 2841L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2576L, 2842L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2577L, 2842L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2568L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2569L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2570L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2571L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2572L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2573L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2574L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2575L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2576L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2577L);
        }
    }
}
