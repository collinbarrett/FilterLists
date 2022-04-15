using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2900 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2583L, null, "The CCP forces the public to install the tracking app", null, null, null, "https://github.com/sioxe823/Project-RnJlRUhL", true, "https://github.com/sioxe823/Project-RnJlRUhL/issues", 5L, "Project RnJlRUhL", null, null, null });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 176L, null, true, "sioxe823", null, "https://github.com/sioxe823" });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2583L, 179L });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2583L, 176L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2583L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2583L, 2848L, (short)1, "https://raw.githubusercontent.com/sioxe823/Project-RnJlRUhL/main/chinese_gov_forced_install.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2583L, 179L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2583L, 176L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2583L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2583L, 2848L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2583L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 176L);
        }
    }
}
