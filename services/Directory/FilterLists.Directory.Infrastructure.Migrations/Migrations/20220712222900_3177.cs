using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3177 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 383L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 383L, "https://discordapp.com/invite/013MqTM1p1qm52VcZ", "Removes uncovered AD, AD frames, and adblock warnings from specific popular websites", "https://austinhuang.me/donate", "im@austinhuang.me", null, "https://austinhuang.me/0131-block-list/", true, "https://github.com/austinhuang0131/0131-block-list/issues", 8L, "0131 Block List", null, null, "https://austinhuang.me/contact" });
        }
    }
}
