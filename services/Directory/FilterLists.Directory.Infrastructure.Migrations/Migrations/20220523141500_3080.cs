using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3080 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 391L,
                columns: new[] { "description", "name" },
                values: new object[] { "Are you tired of bad \"games\" clogging up your electronic devices' app stores? Then this list is for you.", "Anti-'Asset Flip Shovelware' List" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2286L,
                column: "name",
                value: "Dandelion Sprout's Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2377L,
                column: "name",
                value: "Dandelion Sprout's Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance) + EasyList");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2378L,
                column: "name",
                value: "Dandelion Sprout's Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance) + EasyList (TPL)");

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2600L, null, "List of malicious links.", null, null, null, "https://github.com/DevSpen/scam-links", true, null, 11L, "Scam Links - Links", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2601L, null, "Some custom cosmetic filters to be used for ublock origin & adguard. This filter is mainly for mobile browsing specifically for heavily modified AMP pages. Beware that this filter is very aggressive filters which disables the following from an webpage and is very effective if used with uBlock Origin and AdGuard.", null, null, null, "https://github.com/blogmangit/Cosmetic-Filters", true, null, "blogmangit Cosmetic-Filters", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2602L, null, "(JohnyP36:) My own updated version of EasyList Dutch. I made this filter because the EasyList Dutch filter isn't maintained often. And more important: EasyList doesn't allow anti-adblock rules.", "https://www.paypal.com/donate?hosted_button_id=8BBT5V55TGVXW", null, null, "https://github.com/JohnyP36/Personal-List", true, null, 4L, "EasyList Dutch (JohnyP36)", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2603L, null, "Adblocker list (experimental) which allows you to read articles from (supported) sites that implement a paywall. For some sites it will log you out (or block you to log in); caused by removing cookies or blocking general paywall-scripts. Disclaimer: the list doesn't support as many sites as the extension/add-on though.", null, null, null, "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters", true, null, "Bypass Paywalls Clean filter", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2604L, null, "A filter list for Adblock Plus for remove \"Go to up\" buttons", null, null, null, "https://github.com/thedoggybrad/anti-gotoup-buttons", true, null, 17L, "anti-gotoup-buttons", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2605L, null, null, null, "info@lpt.lt", null, "https://lpt.lrv.lt/lt/nelegalios-losimu-veiklos-vykdytojai/istaigoms-ir-institucijoms", true, null, "List of illegal online gambling operators by the Government of the Republic of Lithuania (For institutions)", null, null, null },
                    { 2606L, null, null, null, "info@lpt.lt", null, "https://lpt.lrv.lt/lt/nelegalios-losimu-veiklos-vykdytojai/nelegalios-losimu-veiklos-vykdytoju-sarasas", true, null, "List of illegal online gambling operators by the Government of the Republic of Lithuania", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2607L, null, "This compilation include lists that are maintained as properly and proudly as those in the main Annoyances List, but which have unresolved matters about overblocking, unusual topics, or potential regional legal issues (primarily in the Middle East), that would've caused the AdGuard Filters Registry team to raise eyebrows until resolvements have been agreed on.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Dandelion Sprout's Annoyances List 2nd Division Bachelors", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[] { 2602L, 113L });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2607L, 22L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2600L, 2L },
                    { 2601L, 3L },
                    { 2602L, 4L },
                    { 2603L, 4L },
                    { 2604L, 3L },
                    { 2605L, 2L },
                    { 2606L, 2L },
                    { 2607L, 4L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2600L, 6L },
                    { 2601L, 9L },
                    { 2602L, 2L },
                    { 2602L, 5L },
                    { 2603L, 40L },
                    { 2604L, 15L },
                    { 2605L, 17L },
                    { 2606L, 17L },
                    { 2607L, 9L },
                    { 2607L, 22L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2600L, 2865L, (short)1, "https://raw.githubusercontent.com/DevSpen/links/master/src/links.txt" },
                    { 2601L, 2866L, (short)1, "https://raw.githubusercontent.com/blogmangit/Cosmetic-Filters/main/cosmetic filters.txt" },
                    { 2602L, 2867L, (short)1, "https://raw.githubusercontent.com/JohnyP36/Personal-List/main/Personal List (uBo).txt" },
                    { 2603L, 2868L, (short)1, "https://gitlab.com/magnolia1234/bypass-paywalls-clean-filters/-/raw/main/bpc-paywall-filter.txt" },
                    { 2604L, 2869L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/anti-gotoup-buttons/master/filter.txt" },
                    { 2605L, 2870L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/institucijoms.txt" },
                    { 2606L, 2871L, (short)1, "https://lpt.lrv.lt/uploads/lpt/documents/files/neleg.txt" },
                    { 2607L, 2872L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AnnoyancesList-2ndDivision.txt" },
                    { 2607L, 2873L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AnnoyancesList-2ndDivision.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2602L, 113L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2607L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2600L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2601L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2602L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2603L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2604L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2605L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2606L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2607L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2600L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2601L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2602L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2602L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2603L, 40L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2604L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2605L, 17L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2606L, 17L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2607L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2607L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2600L, 2865L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2601L, 2866L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2602L, 2867L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2603L, 2868L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2604L, 2869L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2605L, 2870L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2606L, 2871L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2872L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2607L, 2873L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2600L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2601L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2602L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2603L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2604L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2605L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2606L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2607L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 391L,
                columns: new[] { "description", "name" },
                values: new object[] { "Removes popular games and most bad games from the front pages of various webstores and app stores.", "I Hate Overpromoted Games" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2286L,
                column: "name",
                value: "Dandelion Sprout's West Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance)");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2377L,
                column: "name",
                value: "Dandelion Sprout's West Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance) + EasyList");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2378L,
                column: "name",
                value: "Dandelion Sprout's West Nordic filters for tidier websites (for Adblock Plus with ABP inclusion compliance) + EasyList (TPL)");
        }
    }
}
