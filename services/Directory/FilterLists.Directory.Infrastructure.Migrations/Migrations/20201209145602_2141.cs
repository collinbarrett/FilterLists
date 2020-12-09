using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2141 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Iso6391",
                table: "FilterListLanguages",
                type: "character(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2)");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2437, null, "A blocklist of malicious URLs that are being used for malware distribution.", null, null, null, "https://gitlab.com/curben/urlhaus-filter", "https://gitlab.com/curben/urlhaus-filter/issues", 28, "urlhaus-filter (IE)", null, null, null },
                    { 2438, null, "A blocklist of phishing websites. Based on PhishTank and OpenPhish.", null, null, null, "https://gitlab.com/curben/phishing-filter", "https://gitlab.com/curben/phishing-filter/issues", 8, "phishing-filter (IE)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2437, 10 },
                    { 2438, 10 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2437, 6 },
                    { 2438, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2639, 2437, (short)1, "https://curben.gitlab.io/malware-filter/urlhaus-filter-online.tpl" },
                    { 2640, 2438, (short)1, "https://curben.gitlab.io/phishing-filter-mirror/phishing-filter.tpl" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2437, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2438, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2437, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2438, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2639);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2438);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6391",
                table: "FilterListLanguages",
                type: "character varying(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character(2)");
        }
    }
}
