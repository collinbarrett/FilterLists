using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2439, null, "A filter list optimized for DNS level blocking of ads, analytics, crypto-jacking and other such threats/nuisances.", null, null, null, "https://github.com/arapurayil/aBL/", "https://github.com/arapurayil/aBL/issues", 4, "aBL - General", null, null, null },
                    { 2440, null, "Blocks social media. Should only be used with aBL - General List", null, null, null, "https://github.com/arapurayil/aBL/", "https://github.com/arapurayil/aBL/issues", 4, "aBL - Addon - Social Media", null, null, null },
                    { 2441, null, "Blocks porn, gambling, and snuff. Should only be used with aBL - General List", null, null, null, "https://github.com/arapurayil/aBL/", "https://github.com/arapurayil/aBL/issues", 4, "aBL - Addon - Porn, Gambling, Snuff", null, null, null },
                    { 2442, null, "Blocks region/language specific domains. Should only be used with aBL - General List", null, null, null, "https://github.com/arapurayil/aBL/", "https://github.com/arapurayil/aBL/issues", 4, "aBL - Addon - Regional", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainers",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 157, "dev@arapurayil.com", "arapurayil", null, "https://github.com/arapurayil/" });

            migrationBuilder.InsertData(
                table: "Dependents",
                columns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                values: new object[,]
                {
                    { 2439, 2442 },
                    { 2439, 2440 },
                    { 2439, 2441 }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 2439, "en" },
                    { 2442, "en" },
                    { 2441, "en" },
                    { 2440, "en" }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2439, 3 },
                    { 2442, 3 },
                    { 2441, 3 },
                    { 2440, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2441, 17 },
                    { 2441, 15 },
                    { 2441, 11 },
                    { 2440, 4 },
                    { 2442, 2 },
                    { 2439, 20 },
                    { 2439, 9 },
                    { 2439, 7 },
                    { 2439, 6 },
                    { 2439, 3 },
                    { 2439, 2 },
                    { 2439, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2641, 2439, (short)1, "https://github.com/arapurayil/aBL/raw/master/lists/general/filter_list.txt" },
                    { 2643, 2441, (short)1, "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/porn_gambling_snuff/filter_list.txt" },
                    { 2642, 2440, (short)1, "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/social/filter_list.txt" },
                    { 2644, 2442, (short)1, "https://raw.githubusercontent.com/arapurayil/aBL/master/lists/regional/filter_list.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                keyValues: new object[] { 2439, 2440 });

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                keyValues: new object[] { 2439, 2441 });

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                keyValues: new object[] { 2439, 2442 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2439, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2440, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2441, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2442, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2439, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2440, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2441, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2442, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2439, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2440, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2441, 11 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2441, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2441, 17 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2442, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2641);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2643);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2644);

            migrationBuilder.DeleteData(
                table: "Maintainers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2442);
        }
    }
}
