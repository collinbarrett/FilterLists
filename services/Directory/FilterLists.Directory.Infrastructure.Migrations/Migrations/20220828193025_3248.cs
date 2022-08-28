using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3248 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1968L, 31L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2542L, 28L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 1968L, 8L },
                    { 1969L, 5L },
                    { 1969L, 28L },
                    { 2542L, 9L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1968L, 2045L },
                column: "url",
                value: "https://filters.adtidy.org/windows/filters/18.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1969L, 2046L },
                column: "url",
                value: "https://filters.adtidy.org/windows/filters/19.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1970L, 2047L },
                column: "url",
                value: "https://filters.adtidy.org/windows/filters/20.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1971L, 2048L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/Popups/sections/antiadblock.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2542L, 2762L },
                column: "url",
                value: "https://filters.adtidy.org/windows/filters/21.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1968L,
                columns: new[] { "description", "name" },
                values: new object[] { "Blocks cookie notices on web pages.", "AdGuard Cookie Notices filter" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1969L,
                columns: new[] { "description", "name" },
                values: new object[] { "Blocks all kinds of pop-ups that are not necessary for websites' operation.", "AdGuard Popups filter" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1970L,
                columns: new[] { "description", "name" },
                values: new object[] { "Blocks irritating banners that promote mobile apps of websites.", "AdGuard Mobile App Banners filter" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1971L,
                column: "name",
                value: "AdGuard Popups filter - Anti-Adblock Only");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2542L,
                columns: new[] { "description", "name" },
                values: new object[] { "Blocks irritating elements on web pages that do not fall under the popular categories of annoyances.", "AdGuard Other Annoyances filter" });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2610L, null, "Blocks annoying third-party widgets: online assistants, live support chats, etc.", null, null, "https://forum.adguard.com/index.php?categories/filter-rules.66/", "https://github.com/AdguardTeam/AdguardFilters", true, "https://github.com/AdguardTeam/AdguardFilters/issues", 12L, "AdGuard Widgets filter", null, "https://kb.adguard.com/en/general/adguard-filter-policy", null },
                    { 2611L, null, "This list makes deviantART focus more on quality custom art, by removing as much as feasible of the horrid leftovers that the site is stuffed with. No more copypaste MS Paint, no more bad takes from the authors' or \"characters'\" standpoints, no more mega crossovers, no more inflation, no more top 23 rankings, and no more Thomas the Tank Engine. This list could possibly end up saving lives.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "deviantART Quality Art Magnifier", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2610L, 46L },
                    { 2611L, 22L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2610L, 6L },
                    { 2611L, 4L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2610L, 15L },
                    { 2611L, 9L },
                    { 2611L, 11L },
                    { 2611L, 30L },
                    { 2611L, 34L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2610L, 2876L, (short)1, "https://filters.adtidy.org/windows/filters/22.txt" },
                    { 2611L, 2877L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/DeviantARTQualityArtMagnifier.txt" },
                    { 2611L, 2878L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/DeviantARTQualityArtMagnifier.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2610L, 46L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2611L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2610L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2611L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1968L, 8L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1969L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1969L, 28L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2542L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2610L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2611L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2611L, 11L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2611L, 30L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2611L, 34L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2610L, 2876L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2877L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2611L, 2878L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2610L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2611L);

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 1968L, 31L },
                    { 2542L, 28L }
                });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1968L, 2045L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/remains.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1969L, 2046L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/push-notifications.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1970L, 2047L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/mobile-app.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1971L, 2048L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/antiadblock.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2542L, 2762L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/subscriptions.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1968L,
                columns: new[] { "description", "name" },
                values: new object[] { "Blocks empty leftover boxes.", "AdGuard Annoyances Filter - Remains Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1969L,
                columns: new[] { "description", "name" },
                values: new object[] { "Rules for blocking push notifications.", "AdGuard Annoyances Filter - Push Notifications Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1970L,
                columns: new[] { "description", "name" },
                values: new object[] { "Banners of mobile apps for the sites.", "AdGuard Annoyances Filter - Mobile App Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1971L,
                column: "name",
                value: "AdGuard Annoyances Filter - Anti-Adblock Only");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2542L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "AdGuard Annoyances Filter - Subscriptions and Newsletters Only" });
        }
    }
}
