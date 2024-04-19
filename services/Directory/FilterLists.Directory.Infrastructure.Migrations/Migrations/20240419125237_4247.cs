using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4247 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2669L,
                column: "donate_url",
                value: "https://donatello.to/serhiyguryev");

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2670L, null, "Removes ads from Ukrainian websites", "https://donatello.to/serhiyguryev", null, null, "https://github.com/serhiyguryev/ukrainian-filters", true, "https://github.com/serhiyguryev/ukrainian-filters/issues", 4L, "Ukrainian Ad Filter", null, null, null },
                    { 2671L, null, "Blocks irritating elements on Ukrainian and some popular foreign websites (cookie notices, pop-ups, banners etc.)", "https://donatello.to/serhiyguryev", null, null, "https://github.com/serhiyguryev/ukrainian-filters", true, "https://github.com/serhiyguryev/ukrainian-filters/issues", 4L, "Ukrainian Annoyance Filter", null, null, null },
                    { 2672L, null, "Blocks trackers and harmful scripts, reduces the ability of third parties to collect data about your browsing behavior", "https://donatello.to/serhiyguryev", null, null, "https://github.com/serhiyguryev/ukrainian-filters", true, "https://github.com/serhiyguryev/ukrainian-filters/issues", 4L, "Ukrainian Privacy Filter", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 192L, null, true, "Serhiy Guryev", null, "https://github.com/serhiyguryev" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2669L, 192L },
                    { 2670L, 192L },
                    { 2671L, 192L },
                    { 2672L, 192L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2670L, 4L },
                    { 2671L, 4L },
                    { 2672L, 4L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2670L, 2L },
                    { 2671L, 9L },
                    { 2672L, 3L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2670L, 2954L, (short)1, "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/ads.txt" },
                    { 2671L, 2955L, (short)1, "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/annoyances.txt" },
                    { 2672L, 2956L, (short)1, "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/privacy.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2669L, 192L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2670L, 192L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2671L, 192L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2672L, 192L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2670L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2671L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2672L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2670L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2671L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2672L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2670L, 2954L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2671L, 2955L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2672L, 2956L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2670L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2671L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2672L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 192L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2669L,
                column: "donate_url",
                value: "https://www.paypal.com/donate/?hosted_button_id=AQ9BB34WHFADC");
        }
    }
}
