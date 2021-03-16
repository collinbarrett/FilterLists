using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2272 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2365);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2009,
                column: "Url",
                value: "https://raw.githubusercontent.com/YanFung/Ads/master/Mobile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2009,
                column: "Url",
                value: "https://raw.githubusercontent.com/YanFung/Ads/master/Mobile.txt");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2365, null, null, null, null, null, "https://gitee.com/damengzhudamengzhu/guanggaoguolv/", "https://gitee.com/damengzhudamengzhu/guanggaoguolv/issues", null, "jiekouAD", null, null, null });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2528, 2365, (short)1, "https://gitee.com/damengzhudamengzhu/guanggaoguolv/raw/master/jiekouAD.txt" });
        }
    }
}
