using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2526 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2520, null, "Dynamic rules for uBlock Origin for 3p-frame unblocking only", "https://www.paypal.com/donate?hosted_button_id=M4D2NPZX5NS4C", null, null, "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues", 4, "Dynamic rules (uBo)", null, null, null },
                    { 2521, null, "Personal filter list (My filters)", "https://www.paypal.com/donate?hosted_button_id=M4D2NPZX5NS4C", null, null, "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues", 4, "Personal filter list (My filters) (uBo)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2520, 162 },
                    { 2521, 162 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2520, 7 },
                    { 2521, 4 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[] { 2520, 3 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2733, 2520, (short)1, "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/dynamic rules" },
                    { 2734, 2521, (short)1, "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/my filters" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2520, 162 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2521, 162 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2520, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2521, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2520, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2734);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2521);
        }
    }
}
