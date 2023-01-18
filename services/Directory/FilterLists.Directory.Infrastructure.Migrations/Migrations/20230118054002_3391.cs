using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3391 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2636L, null, "Have you browsed through image search engines looking for transparent images, but all you can find are ones with fake transparency and grey chessboards in the background? Then this list is for you.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Anti-'Fake transparent images' List", null, null, null },
                    { 2637L, null, "This list aims to combat some sites' attempts to make it impossible to copy text, right-click on pages, open the F12 menu, create fake loading times, or who otherwise obstruct people from features that they should be perfectly in their rights to have access to.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Anti-'Functionality removal' List", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2638L, null, "Say goodbye to additional annoyances like floating videos, newsletter pop-ups, and other distractions. Using entries that include '#$#' requires Adblock Plus and an Adblock Plus Premium subscription.", null, null, null, "https://accounts.adblockplus.org/premium", true, null, "Premium - Distraction Control", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2639L, null, null, "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW", "easylist@protonmail.com", null, "https://easylist.to/", true, null, 4L, "Fanboy Notifications Blocking List (uBlock Origin)", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2636L, 22L },
                    { 2637L, 22L },
                    { 2638L, 6L },
                    { 2639L, 14L },
                    { 2639L, 22L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2636L, 4L },
                    { 2637L, 3L },
                    { 2638L, 2L },
                    { 2638L, 3L },
                    { 2638L, 38L },
                    { 2639L, 4L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2636L, 15L },
                    { 2637L, 15L },
                    { 2638L, 9L },
                    { 2639L, 32L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2636L, 2902L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiFakeTransparentImagesList.txt" },
                    { 2636L, 2903L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiFakeTransparentImagesList.txt" },
                    { 2637L, 2904L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiFunctionalityRemovalList.txt" },
                    { 2637L, 2905L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiFunctionalityRemovalList.txt" },
                    { 2638L, 2906L, (short)1, "https://easylist-downloads.adblockplus.org/adblock_premium.txt" },
                    { 2639L, 2907L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Other domains versions/FanboyNotifications-LoadableInUBO.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2636L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2637L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2638L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2639L, 14L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2639L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2636L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2637L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2638L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2638L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2638L, 38L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2639L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2636L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2637L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2638L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2639L, 32L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2636L, 2902L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2636L, 2903L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2637L, 2904L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2637L, 2905L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2638L, 2906L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2639L, 2907L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2636L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2637L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2638L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2639L);
        }
    }
}
