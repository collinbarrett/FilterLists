using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3668 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2660L, null, "Blocks use of @ (i.e. https://google.com@example.com) before domain names, which is being used to trick people", null, null, null, "https://github.com/L8X/AntiAuthenticationUrlFilter", true, "https://github.com/L8X/AntiAuthenticationUrlFilter/issues", "Anti-Authentication-Url-Filter", null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2660L);
        }
    }
}
