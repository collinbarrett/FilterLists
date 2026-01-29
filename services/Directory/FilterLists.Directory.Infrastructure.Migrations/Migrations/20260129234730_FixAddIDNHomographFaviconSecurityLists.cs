using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class FixAddIDNHomographFaviconSecurityLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2841, null, "Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.", "https://github.com/TantalusDrive", null, null, "https://github.com/TantalusDrive/Secfilters", "https://github.com/TantalusDrive/Secfilters/issues", 9, "IDN Homograph & Favicon Security List - AdGuard version (MV2)", null, null, null },
                    { 2842, null, "Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.", "https://github.com/TantalusDrive", null, null, "https://github.com/TantalusDrive/Secfilters", "https://github.com/TantalusDrive/Secfilters/issues", 9, "IDN Homograph & Favicon Security List - ABP version (MV2)", null, null, null },
                    { 2843, null, "Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.", "https://github.com/TantalusDrive", null, null, "https://github.com/TantalusDrive/Secfilters", "https://github.com/TantalusDrive/Secfilters/issues", 9, "IDN Homograph & Favicon Security List - Brave version", null, null, null },
                    { 2844, null, "Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.", "https://github.com/TantalusDrive", null, null, "https://github.com/TantalusDrive/Secfilters", "https://github.com/TantalusDrive/Secfilters/issues", 9, "IDN Homograph & Favicon Security List - uBlock Origin version", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 210, "carlolatorre.uw4yf@slmails.com", "TantalusDrive", null, "https://github.com/TantalusDrive" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2841, (short)37 },
                    { 2842, (short)37 },
                    { 2843, (short)37 },
                    { 2844, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2841, 210 },
                    { 2842, 210 },
                    { 2843, 210 },
                    { 2844, 210 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2841, (short)6 },
                    { 2842, (short)3 },
                    { 2843, (short)3 },
                    { 2844, (short)4 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2841, 7 },
                    { 2841, 10 },
                    { 2842, 7 },
                    { 2842, 10 },
                    { 2843, 7 },
                    { 2843, 10 },
                    { 2844, 7 },
                    { 2844, 10 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2841, 3238, (short)1, "https://tantalusdrive.github.io/Secfilters/Lists/AdGuard/IDNHomographFavicon.txt" },
                    { 2841, 3239, (short)2, "https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/AdGuard/IDNHomographFavicon.txt" },
                    { 2842, 3240, (short)1, "https://tantalusdrive.github.io/Secfilters/Lists/ABP/IDNHomographFavicon.txt" },
                    { 2842, 3241, (short)2, "https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/ABP/IDNHomographFavicon.txt" },
                    { 2843, 3242, (short)1, "https://tantalusdrive.github.io/Secfilters/Lists/Brave/IDNHomographFavicon.txt" },
                    { 2843, 3243, (short)2, "https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/Brave/IDNHomographFavicon.txt" },
                    { 2844, 3244, (short)1, "https://tantalusdrive.github.io/Secfilters/Lists/uBlock/IDNHomographFavicon.txt" },
                    { 2844, 3245, (short)2, "https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/uBlock/IDNHomographFavicon.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2841, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2842, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2843, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2844, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2841, 210 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2842, 210 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2843, 210 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2844, 210 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2841, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2842, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2843, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2844, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2841, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2841, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2842, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2842, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2843, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2843, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2844, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2844, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2841, 3238 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2841, 3239 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2842, 3240 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2842, 3241 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2843, 3242 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2843, 3243 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2844, 3244 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2844, 3245 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2841);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2842);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2843);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2844);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 210);
        }
    }
}
