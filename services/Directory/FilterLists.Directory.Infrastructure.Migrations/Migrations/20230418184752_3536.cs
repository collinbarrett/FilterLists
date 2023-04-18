using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3536 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2619L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2619L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2619L, 2885L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2619L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2618L,
                column: "name",
                value: "3rd Party Only Frame Blocking with Social Media and Google exceptions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2618L,
                column: "name",
                value: "3rd Party only Frame Blocking with Social Media exceptions");

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2619L, null, "A bigger variant of Frame-Blocker-Filter. This variant-filter is designed to block non-essential Frames.", null, null, null, "https://github.com/thedoggybrad/Non-Essential-Frames-Blocker", true, "https://github.com/thedoggybrad/Non-Essential-Frames-Blocker/issues", 17L, "Non-Essential-Frames-Blocker", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2619L, 185L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2619L, 3L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2619L, 2885L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Non-Essential-Frames-Blocker/main/filter.txt" });
        }
    }
}
