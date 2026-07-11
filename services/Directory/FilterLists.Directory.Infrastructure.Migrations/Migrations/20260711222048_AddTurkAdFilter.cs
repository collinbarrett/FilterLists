using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddTurkAdFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2859, null, "Community-driven, open-source blocklist targeting Turkey-based ad, tracker and malicious content providers — including Turkish illegal gambling and phishing/scam domains that global lists don't cover. Compatible with AdGuard, uBlock Origin, Pi-hole, AdGuard Home and NextDNS. Actively maintained, daily updates.", null, null, null, "https://reklamsiz-turkiye.com/", "https://github.com/omerdduran/turk-adfilter/issues", 4, "Turk-AdFilter", null, null, "https://github.com/omerdduran/turk-adfilter/pulls" },
                    { 2860, null, "Community-driven, open-source hosts/DNS blocklist targeting Turkey-based ad, tracker and malicious content providers. Compatible with Pi-hole, AdGuard Home and NextDNS. Actively maintained, daily updates.", null, null, null, "https://reklamsiz-turkiye.com/", "https://github.com/omerdduran/turk-adfilter/issues", 4, "Turk-AdFilter (Hosts)", null, null, "https://github.com/omerdduran/turk-adfilter/pulls" }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 216, null, "omerdduran", null, "https://github.com/omerdduran" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2859, (short)161 },
                    { 2860, (short)161 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2859, 216 },
                    { 2860, 216 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2859, (short)3 },
                    { 2860, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2859, 2 },
                    { 2859, 3 },
                    { 2859, 6 },
                    { 2859, 7 },
                    { 2859, 16 },
                    { 2860, 2 },
                    { 2860, 3 },
                    { 2860, 6 },
                    { 2860, 7 },
                    { 2860, 16 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2859, 3265, (short)1, "https://raw.githubusercontent.com/omerdduran/turk-adfilter/main/turk-adfilter.txt" },
                    { 2859, 3266, (short)2, "https://codeberg.org/omerdduran/turk-adfilter/raw/branch/main/turk-adfilter.txt" },
                    { 2860, 3267, (short)1, "https://raw.githubusercontent.com/omerdduran/turk-adfilter/main/hosts.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2859, (short)161 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2860, (short)161 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2859, 216 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2860, 216 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2859, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2860, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2859, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2859, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2859, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2859, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2859, 16 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2860, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2860, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2860, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2860, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2860, 16 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2859, 3265 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2859, 3266 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2860, 3267 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2859);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2860);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 216);
        }
    }
}
