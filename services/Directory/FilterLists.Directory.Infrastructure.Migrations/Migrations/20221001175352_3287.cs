using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3287 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2614L, null, "A filter list for Adblock Plus for remove all newsletters banners", null, null, null, "https://github.com/thedoggybrad/no-newsletter", true, "https://github.com/thedoggybrad/no-newsletter/issues", 17L, "no-newsletter", null, null, null },
                    { 2615L, null, "No mercy for 3rd Party Frames.", null, null, null, "https://github.com/thedoggybrad/Frame-Blocker-Filter", true, "https://github.com/thedoggybrad/Frame-Blocker-Filter/issues", 17L, "Frame-Blocker-Filter (3rd Party only)", null, null, null },
                    { 2616L, null, "No mercy for all frames.", null, null, null, "https://github.com/thedoggybrad/Frame-Blocker-Filter", true, "https://github.com/thedoggybrad/Frame-Blocker-Filter/issues", 17L, "Frame-Blocker-Filter (All Frames)", null, null, null },
                    { 2617L, null, "No mercy for 3rd party frames with Google and YouTube exceptions.", null, null, null, "https://github.com/thedoggybrad/Frame-Blocker-Filter", true, "https://github.com/thedoggybrad/Frame-Blocker-Filter/issues", 17L, "3rd Party only Frame Blocking with Google and YouTube exceptions", null, null, null },
                    { 2618L, null, "No mercy for 3rd Party Frames except for common Social Media sites.", null, null, null, "https://github.com/thedoggybrad/Frame-Blocker-Filter", true, "https://github.com/thedoggybrad/Frame-Blocker-Filter/issues", 17L, "3rd Party only Frame Blocking with Social Media exceptions", null, null, null },
                    { 2619L, null, "A bigger variant of Frame-Blocker-Filter. This variant-filter is designed to block non-essential Frames.", null, null, null, "https://github.com/thedoggybrad/Non-Essential-Frames-Blocker", true, "https://github.com/thedoggybrad/Non-Essential-Frames-Blocker/issues", 17L, "Non-Essential-Frames-Blocker", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 185L, null, true, "The Doggy Brad", null, "https://github.com/thedoggybrad" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[,]
                {
                    { 2614L, 185L },
                    { 2615L, 185L },
                    { 2616L, 185L },
                    { 2617L, 185L },
                    { 2618L, 185L },
                    { 2619L, 185L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2614L, 3L },
                    { 2615L, 3L },
                    { 2616L, 3L },
                    { 2617L, 3L },
                    { 2618L, 3L },
                    { 2619L, 3L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2614L, 2881L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/no-newsletter/master/filter.txt" },
                    { 2615L, 2882L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/3rdParty.txt" },
                    { 2616L, 2883L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/All.txt" },
                    { 2617L, 2884L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/googleyt-exception.txt" },
                    { 2618L, 2885L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Frame-Blocker-Filter/main/socialmedia-exception.txt" },
                    { 2619L, 2886L, (short)1, "https://raw.githubusercontent.com/thedoggybrad/Non-Essential-Frames-Blocker/main/filter.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2614L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2615L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2616L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2617L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2618L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2619L, 185L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2614L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2615L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2616L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2617L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2618L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2619L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2614L, 2881L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2615L, 2882L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2616L, 2883L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2617L, 2884L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2618L, 2885L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2619L, 2886L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2614L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2615L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2616L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2617L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2618L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2619L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 185L);
        }
    }
}
