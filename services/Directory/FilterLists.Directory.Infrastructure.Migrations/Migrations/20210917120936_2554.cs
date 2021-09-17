using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2554 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2081,
                column: "Name",
                value: "Yuki's Cookie Dialogue filters");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 1, null, "Add this if you use Yuki's uBlock Japanese filters with uBlock Origin on Firefox for Mobile.", null, null, null, "https://github.com/Yuki2718/adblock", "https://github.com/Yuki2718/adblock/issues", 8, "Yuki's uBlock Japanese filters - Mobile", null, null, null });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[] { 1, "ja" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 1, 150 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 1, 1, (short)1, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/jp-mob.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1, 150 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2081,
                column: "Name",
                value: "Sabre Filters 2");
        }
    }
}
