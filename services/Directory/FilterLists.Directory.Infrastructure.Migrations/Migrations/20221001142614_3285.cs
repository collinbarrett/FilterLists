using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3285 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2612L, null, "Conversion Syntax of AdAway Default Blocklist for AdGuard.", null, null, null, "https://github.com/Leaf16591/AdAway-Default-Blocklist-AdGuard-Version", true, "https://github.com/Leaf16591/AdAway-Default-Blocklist-AdGuard-Version/issues", 5L, "AdAway Default Blocklist (AdGuard Version)", null, null, null });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 184L, null, true, "Matteo", null, "https://github.com/Leaf16591" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2612L, 184L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2612L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2612L, 2879L, (short)1, "https://raw.githubusercontent.com/Leaf16591/AdAway-Default-Blocklist-AdGuard-Version/main/Host" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2612L, 184L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2612L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2612L, 2879L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2612L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 184L);
        }
    }
}
