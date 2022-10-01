using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3286 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2613L, null, "Malicious IP blocklists derived via lexical analysis of cloud virtual machine hostnames listed in the Inversion DNSBL Blocklists, updated every hour.", null, null, null, "https://github.com/elliotwutingfeng/Inversion-CloudIPs", true, "https://github.com/elliotwutingfeng/Inversion-CloudIPs/issues", 10L, "Inversion CloudIPs", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2613L, 174L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2613L, 1L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2613L, 2880L, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/Inversion-CloudIPs/main/ips.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2613L, 174L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2613L, 1L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2613L, 2880L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2613L);
        }
    }
}
