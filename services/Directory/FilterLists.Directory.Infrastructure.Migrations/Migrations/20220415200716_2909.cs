using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2909 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[,]
                {
                    { 2589L, null, "ThreatShare is an advanced threat tracker that publicly tracks command & control servers for malware. The tracker is powered by Sentinel, an automated intelligence platform built to supply ThreatShare with a constant stream of control panels. Threat intelligence can be submitted through the site and will then be displayed to our users. This service is non profit and has been created to expose cybercriminals to the public along with providing researchers with a steady stream of threat intelligence.", null, null, null, "https://threatshare.io/", true, null, 5L, "ThreatShare", null, null, "https://threatshare.io/submit/" },
                    { 2590L, null, "Websites deemed by the Bank of Lithuania to be used for conducting fraudulent activities and money scams.", null, null, null, "https://www.lb.lt/en/illegalwww", true, null, 5L, "Bank of Lithuania Illegal websites", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 181L, null, true, "Bank of Lithuania", null, "https://www.lb.lt/" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2590L, 181L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[,]
                {
                    { 2589L, 57L },
                    { 2590L, 57L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2589L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2589L, 2854L, (short)1, "https://threatshare.io/feed" },
                    { 2590L, 2855L, (short)1, "https://www.lb.lt/en/illegalwww?export=csv" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2590L, 181L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2589L, 57L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2590L, 57L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2589L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2589L, 2854L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2590L, 2855L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2589L);

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2590L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 181L);
        }
    }
}
