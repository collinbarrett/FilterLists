using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4045 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1841L,
                column: "name",
                value: "Dandelion Sprout's Nordic Filters for Tidier Websites (for Legacy Pi-hole version ≤5.21)");

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2664L, null, "This list aims to remove news articles about sports competitions that are laughably corrupt and money-hoarding, especially those that are in the pockets of the homicidal, anti-atheist Saudi Arabian royal house.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Anti-'Corrupt Sports' List", null, null, null },
                    { 2665L, null, "When I declared war on Chrome Manifest V3 in 2021, I really meant it. With this list that blocks MV3 extensions' download files and homepages, you too can be an active participant in the survival war.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Anti-MV3 List", null, null, null },
                    { 2666L, null, "Spun off from «Ad Removal List for Unusual Ads», as a result of not all African languages having newssites with high enough Alexa ranks to make it to AdGuard Base Filter's «Foreign» section.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "African Languages List", null, null, null },
                    { 2667L, null, "I discovered in November 2023 that there was a non-zero market for this kind of list, so here it is.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "HTTPS-only Mode for All Browsers", null, null, null },
                    { 2668L, null, "This list removes «Your fav is» and some character-specific «Daily _____» from some sites, to reduce clutter when searching for top-class fanart of various franchises.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", true, "https://github.com/DandelionSprout/adfilt/issues", 35L, "Anti-'Stock vector art on copypaste backgrounds'", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[,]
                {
                    { 2666L, 6L },
                    { 2666L, 55L },
                    { 2666L, 99L },
                    { 2666L, 133L },
                    { 2666L, 145L },
                    { 2666L, 148L },
                    { 2666L, 151L },
                    { 2666L, 177L },
                    { 2666L, 180L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2664L, 22L },
                    { 2665L, 22L },
                    { 2666L, 22L },
                    { 2667L, 22L },
                    { 2668L, 22L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2664L, 4L },
                    { 2665L, 3L },
                    { 2666L, 3L },
                    { 2667L, 4L },
                    { 2668L, 3L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 2664L, 30L },
                    { 2665L, 19L },
                    { 2665L, 25L },
                    { 2666L, 2L },
                    { 2667L, 7L },
                    { 2668L, 15L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2664L, 2943L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiCorruptSportsList.txt" },
                    { 2664L, 2944L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiCorruptSportsList.txt" },
                    { 2665L, 2945L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiMV3List.txt" },
                    { 2665L, 2946L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiMV3List.txt" },
                    { 2666L, 2947L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AfricanLanguagesList.txt" },
                    { 2666L, 2948L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AfricanLanguagesList.txt" },
                    { 2667L, 2949L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Special security lists/HTTPSOnlyModeForAllBrowsers.txt" },
                    { 2667L, 2950L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Special security lists/HTTPSOnlyModeForAllBrowsers.txt" },
                    { 2668L, 2951L, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Sensitive lists/Anti-'StockVectorArtOnCopypasteBackgrounds'.txt" },
                    { 2668L, 2952L, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Sensitive lists/Anti-'StockVectorArtOnCopypasteBackgrounds'.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 55L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 99L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 133L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 145L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 148L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 151L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 177L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 2666L, 180L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2664L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2665L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2666L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2667L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2668L, 22L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2664L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2665L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2666L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2667L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2668L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2664L, 30L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2665L, 19L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2665L, 25L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2666L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2667L, 7L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2668L, 15L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2664L, 2943L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2664L, 2944L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2665L, 2945L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2665L, 2946L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2666L, 2947L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2666L, 2948L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2667L, 2949L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2667L, 2950L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2668L, 2951L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2668L, 2952L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2664L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2665L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2666L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2667L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2668L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1841L,
                column: "name",
                value: "Dandelion Sprout's Nordic Filters for Tidier Websites (for Pi-hole)");
        }
    }
}
