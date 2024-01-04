using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4019 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2663L, null, "This robust filter is meticulously designed to fortify your online privacy by intercepting and blocking a wide array of trackers, web analytics tools, and data collectors, ensuring a more secure and confidential browsing experience. Stay protected and in control of your digital footprint with this comprehensive shield against intrusive tracking mechanisms.", null, null, null, "https://github.com/complexorganizations/content-blocker", true, "https://github.com/complexorganizations/content-blocker/issues", 2L, "Content Blocker - Advanced Tracker and Analytics Blocker", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[] { 2663L, 2942L, (short)1, (short)1, "https://raw.githubusercontent.com/complexorganizations/content-blocker/main/assets/hosts" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2663L, 2942L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2663L);
        }
    }
}
