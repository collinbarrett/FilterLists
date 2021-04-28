using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2342 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2475, null, "This allowlist fixes incorrect blocking by standard filters such as EasyList, mainly on Japanese websites. It is based largely on Yuki's uBlock Japanese filters.", null, null, null, "https://github.com/hirorpt/filters", "https://github.com/hirorpt/filters/issues", 28, "Konayuki filters", null, null, null });

            migrationBuilder.InsertData(
                table: "Maintainers",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 159, null, "hirorpt", null, "https://github.com/hirorpt" });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[] { 2475, "ja" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2475, 159 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2475, 4 });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[] { 2475, 10 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2684, 2475, (short)1, "https://raw.githubusercontent.com/hirorpt/filters/main/fix.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2475, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2475, 159 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2475, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2475, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 159);
        }
    }
}
