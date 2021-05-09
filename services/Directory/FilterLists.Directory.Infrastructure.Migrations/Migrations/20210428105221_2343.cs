using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2343 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2095,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Enhance anti-scam capability of 280blocker adblock filter by utilizing advanced capability of AdGuard/uBlock Origin.", "Anti-scam enhancer for 280blocker adblock filter" });

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2096, null, "Removes blogroll (feed-style mutual links) on Japanese sites. Included in Yuki's uBlock Japanese filters - Annoyances", null, null, null, "https://github.com/Yuki2718/adblock", "https://github.com/Yuki2718/adblock/issues", 28, "Yuki's Blogroll filters", null, null, null });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[] { 2096, "ja" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2096, 150 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2096, 4 });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[] { 2096, 9 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2683, 2096, (short)1, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/blogroll.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2096, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2096, 150 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2096, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2096, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2095,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Enhance anti-scam capability of 280blocker for Japanese mobile site (ABP format) by utilizing advanced capability of AdGuard/uBlock Origin.", "Anti-scam enhancer for 280blocker ABP format list" });
        }
    }
}
