using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2458 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2513, null, "Block malware, phishing, and scams for a more secure browser", null, null, null, "https://github.com/iam-py-test/my_filters_001", "https://github.com/iam-py-test/my_filters_001/issues", 28, "Malicious website blocklist", null, null, null },
                    { 2514, null, "Block malware, phishing, and scams for a more secure browser (HOSTS version - not for uBlock Origin)", null, null, null, "https://github.com/iam-py-test/my_filters_001", null, 28, "Malicious website blocklist (HOSTS)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainers",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 161, null, "iam-py-test", null, "https://github.com/iam-py-test" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2513, 161 },
                    { 2514, 161 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2513, 4 },
                    { 2514, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Url" },
                values: new object[,]
                {
                    { 2725, 2513, "https://raw.githubusercontent.com/iam-py-test/my_filters_001/main/antimalware.txt" },
                    { 2726, 2514, "https://raw.githubusercontent.com/iam-py-test/my_filters_001/main/Alternative list formats/antimalware_hosts.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2513, 161 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2514, 161 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2513, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2514, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2725);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 161);
        }
    }
}
