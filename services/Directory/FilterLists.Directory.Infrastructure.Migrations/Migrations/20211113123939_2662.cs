using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2662 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2537, 6 },
                    { 2537, 7 },
                    { 2538, 6 },
                    { 2538, 7 }
                });

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2537,
                column: "Description",
                value: "Block malware, phishing, and scams for a more secure computer");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2538,
                column: "Description",
                value: "Block malware, phishing, and scams for a more secure computer (HOSTS version - not for uBlock Origin)");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2541, null, "Block malware, phishing, and scams for a more secure computer (Domains version)", null, null, null, "https://github.com/iam-py-test/my_filters_001", "https://github.com/iam-py-test/my_filters_001/issues/", 28, "Malicious website blocklist (Domains)", null, null, null });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2541, 6 },
                    { 2541, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2760, 2541, (short)1, "https://raw.githubusercontent.com/iam-py-test/my_filters_001/main/Alternative list formats/antimalware_domains.txt" },
                    { 2761, 2541, (short)2, "https://iam-py-test.github.io/my_filters_001/Alternative list formats/antimalware_domains.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2537, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2537, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2538, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2538, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2541, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2541, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2541);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2537,
                column: "Description",
                value: "Block malware, phishing, and scams for a more secure browser");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2538,
                column: "Description",
                value: "Block malware, phishing, and scams for a more secure browser (HOSTS version - not for uBlock Origin)");
        }
    }
}
