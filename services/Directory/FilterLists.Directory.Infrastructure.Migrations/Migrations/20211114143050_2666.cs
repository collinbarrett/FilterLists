using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2666 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2564, null, "Filters that accept cookies/GDPR/privacy policy on Polish websites.", null, "contact-project+filtersheroes-pccassets-30920945-issue-@incoming.gitlab.com", "https://www.reddit.com/r/PolishCookieConsent", "https://github.com/FiltersHeroes/PCCassets", "https://github.com/FiltersHeroes/PCCassets/issues", 33, "Polish Cookie Database", null, null, null },
                    { 2565, null, "Filters that accept cookies/GDPR/privacy policy on European websites (based on I don't care about cookies).", null, "contact-project+filtersheroes-pccassets-30920945-issue-@incoming.gitlab.com", "https://www.reddit.com/r/PolishCookieConsent", "https://github.com/FiltersHeroes/PCCassets", "https://github.com/FiltersHeroes/PCCassets/issues", 4, "European Cookie Database", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Software",
                columns: new[] { "Id", "Description", "DownloadUrl", "HomeUrl", "Name", "SupportsAbpUrlScheme" },
                values: new object[] { 47, "Automatically accepts cookie policy/GDPR on websites.", "https://github.com/FiltersHeroes/PolishCookieConsent/#how-to-install-it", "https://github.com/FiltersHeroes/PolishCookieConsent", "Polish Cookie Consent", false });

            migrationBuilder.InsertData(
                table: "Syntaxes",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 56, null, "Polish Cookie Consent", "https://polishannoyancefilters.netlify.app/en/PolishCookieConsent/syntax/" });

            migrationBuilder.InsertData(
                table: "Dependents",
                columns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                values: new object[] { 224, 2564 });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[] { 2564, "pl" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2564, 34 },
                    { 2565, 34 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2564, 56 },
                    { 2565, 56 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2564, 8 },
                    { 2565, 8 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2788, 2564, (short)1, "https://raw.githubusercontent.com/FiltersHeroes/PCCassets/main/plCDB.txt" },
                    { 2789, 2564, (short)2, "https://cdn.jsdelivr.net/gh/FiltersHeroes/PCCassets@main/plCDB.txt" },
                    { 2790, 2564, (short)3, "https://combinatronics.io/FiltersHeroes/PCCassets/main/plCDB.txt" },
                    { 2791, 2564, (short)4, "https://cdn.statically.io/gh/FiltersHeroes/PCCassets/main/plCDB.txt" },
                    { 2792, 2564, (short)5, "https://filtersheroes.gitlab.io/AssetsMirror/plCDB.txt" },
                    { 2793, 2565, (short)1, "https://raw.githubusercontent.com/FiltersHeroes/PCCassets/main/euCDB.txt" },
                    { 2794, 2565, (short)2, "https://cdn.jsdelivr.net/gh/FiltersHeroes/PCCassets@main/euCDB.txt" },
                    { 2795, 2565, (short)3, "https://combinatronics.io/FiltersHeroes/PCCassets/main/euCDB.txt" },
                    { 2796, 2565, (short)4, "https://cdn.statically.io/gh/FiltersHeroes/PCCassets/main/euCDB.txt" },
                    { 2797, 2565, (short)5, "https://filtersheroes.gitlab.io/AssetsMirror/euCDB.txt" }
                });

            migrationBuilder.InsertData(
                table: "SoftwareSyntaxes",
                columns: new[] { "SoftwareId", "SyntaxId" },
                values: new object[] { 47, 56 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumns: new[] { "DependencyFilterListId", "DependentFilterListId" },
                keyValues: new object[] { 224, 2564 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2564, "pl" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2564, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2565, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2564, 56 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2565, 56 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2564, 8 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2565, 8 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2788);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2789);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2790);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2791);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2793);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2795);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2796);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2797);

            migrationBuilder.DeleteData(
                table: "SoftwareSyntaxes",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { 47, 56 });

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "Software",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Syntaxes",
                keyColumn: "Id",
                keyValue: 56);
        }
    }
}
