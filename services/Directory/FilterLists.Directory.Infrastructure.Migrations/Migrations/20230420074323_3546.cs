using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3546 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2655L, null, "List of German-speaking web-sites with fake-news, propaganda, hate-speech, etc.", null, null, null, "https://codeberg.org/badandugly/badandugly", true, "https://codeberg.org/badandugly/badandugly/issues", 4L, "The Bad & The Ugly Blocklist (German)", null, null, null });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 186L, null, true, "BadAndUgly", null, "https://codeberg.org/badandugly" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2655L, 168L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2655L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2655L, 25L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[] { 2655L, 2933L, (short)1, (short)1, "https://codeberg.org/badandugly/badandugly/raw/branch/main/blocklist" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2655L, 168L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2655L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2655L, 25L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2655L, 2933L });

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2655L);
        }
    }
}
