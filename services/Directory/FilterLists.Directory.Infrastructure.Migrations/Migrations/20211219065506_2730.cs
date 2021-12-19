using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2730 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2080L, 37L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2083L, 73L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2086L, 37L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2090L, 37L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2080L, 150L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2083L, 150L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2086L, 150L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2090L, 150L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2080L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2083L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2086L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2090L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2080L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2083L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2086L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2090L, 31L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2080L, 2187L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2083L, 2190L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2086L, 2193L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2090L, 2197L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2080L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2083L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2086L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2090L);

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2095L, null, "Enhance anti-scam capability of 280blocker adblock filter by utilizing advanced capability of AdGuard/uBlock Origin.", null, null, null, "https://github.com/Yuki2718/adblock", true, "https://github.com/Yuki2718/adblock/issues", 28L, "Anti-scam enhancer for 280blocker adblock filter", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2095L, 73L });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2095L, 150L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2095L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2095L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2095L, 2202L, (short)1, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/280-patch.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2095L, 73L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2095L, 150L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2095L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2095L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2095L, 2202L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2095L);

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2080L, null, "AdGuard Tracking Protection filter is probably the least false-positive prone anti-tracking list; however, it comes with its own cost of less coverage which this filter aims to complement.", null, null, null, "https://github.com/Yuki2718/adblock", true, "https://github.com/Yuki2718/adblock/issues", 8L, "AdGuard Tracking Protection Plus", null, null, null },
                    { 2083L, null, "Removes ranking buttons on adult sites.", null, null, null, "https://github.com/Yuki2718/adblock", true, "https://github.com/Yuki2718/adblock/issues", 8L, "Yuki's Blog Parts Adult", null, null, null },
                    { 2086L, null, "WordPress plugins have been security nightmare and are usually implemented in first-party resource that bypasses medium mode. Although it's impossible to block thousands of these plugins without breaking too many sites, blocking those unwanted plugins won't be a bad idea. While popular social and annoyances filters block many of them, they come with tons of unnecessary rules[^1] and also occasionally cause false-positive. For these reasons I've settled down to AdGuard Social media filter which is relatively small in size and rarely breaks pages; however, it only blocks minimal set of the plugins. This list includes 1) rules for the plugins not on the Social media filter or other default filter lists, 2) rules almost equivalent to Noscript's Application Boundaries Enforcer, and 3) a regex rule focused only on the latest survey scam campaign.", null, null, null, "https://github.com/Yuki2718/adblock", true, "https://github.com/Yuki2718/adblock/issues", 8L, "Yuki's uBlock Static Rules", null, null, null },
                    { 2090L, null, "It's a mobile version of Placeholder Hider with no generic hiding.", null, null, null, "https://github.com/Yuki2718/adblock", true, "https://github.com/Yuki2718/adblock/issues", 8L, "Placeholder Hider with no generic hiding for mobile", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[,]
                {
                    { 2080L, 37L },
                    { 2083L, 73L },
                    { 2086L, 37L },
                    { 2090L, 37L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2080L, 150L },
                    { 2083L, 150L },
                    { 2086L, 150L },
                    { 2090L, 150L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2080L, 3L },
                    { 2083L, 3L },
                    { 2086L, 4L },
                    { 2090L, 4L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2080L, 3L },
                    { 2083L, 15L },
                    { 2086L, 15L },
                    { 2090L, 31L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 2080L, 2187L, (short)1, (short)0, "https://raw.githubusercontent.com/Yuki2718/adblock/master/adguard/tracking-plus.txt" },
                    { 2083L, 2190L, (short)1, (short)0, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/blog-parts-adult.txt" },
                    { 2086L, 2193L, (short)1, (short)0, "https://raw.githubusercontent.com/Yuki2718/adblock/master/medium_mode/static-rules.txt" },
                    { 2090L, 2197L, (short)1, (short)0, "https://raw.githubusercontent.com/Yuki2718/adblock/master/no_gen_cosm/phhider-mob.txt" }
                });
        }
    }
}
