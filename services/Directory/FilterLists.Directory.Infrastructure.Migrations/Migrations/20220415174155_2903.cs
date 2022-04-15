using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2903 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2585L, null, "The BlockList project was created to become protection against negative influence of the harmful and potentially dangerous events on the Internet.", null, "office@blocklist.net.ua", null, "https://blocklist.net.ua/", true, null, 5L, "BlockListNetUA", null, null, null });

            migrationBuilder.InsertData(
                table: "syntaxes",
                columns: new[] { "id", "description", "is_approved", "name", "url" },
                values: new object[] { 57L, null, true, "CSV", "https://en.wikipedia.org/wiki/Comma-separated_values" });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2585L, 167L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2585L, 57L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2585L, 2850L, (short)1, "https://blocklist.net.ua/blocklist.csv" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2585L, 167L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2585L, 57L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2585L, 2850L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2585L);

            migrationBuilder.DeleteData(
                table: "syntaxes",
                keyColumn: "id",
                keyValue: 57L);
        }
    }
}
