using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2669L, null, "Filter of malicious web resources (phishing, online fraud, malware, etc.) targeting Ukrainian citizens", "https://www.paypal.com/donate/?hosted_button_id=AQ9BB34WHFADC", null, null, "https://github.com/braveinnovators/ukrainian-security-filter", true, "https://github.com/braveinnovators/ukrainian-security-filter/issues", 4L, "Ukrainian Security Filter", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2669L, 3L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2669L, 7L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2669L, 2953L, (short)1, "https://raw.githubusercontent.com/braveinnovators/ukrainian-security-filter/main/lists/adblock.txt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2669L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2669L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2669L, 2953L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2669L);
        }
    }
}
