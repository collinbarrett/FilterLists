using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2897 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2578L, null, "Machine-readable .txt allowlist of Syncthing Relay Server IP Addresses, updated every hour.", null, null, null, "https://github.com/elliotwutingfeng/SyncthingRelayServerIPs", true, "https://github.com/elliotwutingfeng/SyncthingRelayServerIPs/issues", 10L, "Syncthing Relay Server IPs", null, null, null });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 174L, "wutingfeng@outlook.com", true, "Wu Tingfeng", null, "https://github.com/elliotwutingfeng" });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "id",
                keyValue: 10L,
                column: "name",
                value: "allowlist");

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2578L, 174L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2578L, 9L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2578L, 10L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2578L, 2843L, (short)1, "https://github.com/elliotwutingfeng/SyncthingRelayServerIPs/blob/main/ips.txt?raw=1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2578L, 174L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2578L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2578L, 10L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2578L, 2843L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2578L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 174L);

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "id",
                keyValue: 10L,
                column: "name",
                value: "whitelist");
        }
    }
}
