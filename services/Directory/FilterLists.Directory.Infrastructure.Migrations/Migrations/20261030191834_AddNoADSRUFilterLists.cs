using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddNoADSRUFilterLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2883, null, "Main list. Blocks ads and annoying elements.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU", null, null, null },
                    { 2884, null, "Extended version of NoADS_RU with more filters for ads, trackers and cookie notices. Recommended for most users.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Extended", null, null, null },
                    { 2885, null, "Most aggressive variant, built on Extended, includes experimental rules. May break some sites.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Extended Plus", null, null, null },
                    { 2886, null, "Relaxed variant of NoADS_RU that keeps Russian web services (Yandex, VK, Mail.ru, etc.) working. It strives to ensure the best possible performance for Russian websites, even if this conflicts with some of the author's principles.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU RWS", null, null, null },
                    { 2887, null, "Blocks ads, analytics and tracking domains.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Hosts Blocker", null, null, null },
                    { 2888, null, "Extended domain blocklist. Recommended for most users.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Hosts BlockerFL", null, null, null },
                    { 2889, null, "Hosts entries for bypassing regional restrictions imposed on the website side. Not a blocklist.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Hosts Bypass", null, null, null },
                    { 2890, null, "Alternative bypass list, rarely updated. Not a blocklist.", null, null, null, "https://github.com/Zalexanninev15/NoADS_RU", "https://codeberg.org/Zalexanninev15/NoADS_RU/issues", 2, "NoADS_RU Hosts Bypass2", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 226, null, "Zalexanninev15", null, "https://github.com/Zalexanninev15" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2883, (short)132 },
                    { 2884, (short)132 },
                    { 2885, (short)132 },
                    { 2886, (short)132 },
                    { 2887, (short)132 },
                    { 2888, (short)132 },
                    { 2889, (short)132 },
                    { 2890, (short)132 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2883, 226 },
                    { 2884, 226 },
                    { 2885, 226 },
                    { 2886, 226 },
                    { 2887, 226 },
                    { 2888, 226 },
                    { 2889, 226 },
                    { 2890, 226 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2883, (short)3 },
                    { 2883, (short)4 },
                    { 2884, (short)3 },
                    { 2884, (short)4 },
                    { 2885, (short)3 },
                    { 2885, (short)4 },
                    { 2886, (short)3 },
                    { 2886, (short)4 },
                    { 2887, (short)54 },
                    { 2888, (short)54 },
                    { 2889, (short)14 },
                    { 2890, (short)14 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2883, 2 },
                    { 2883, 9 },
                    { 2884, 2 },
                    { 2884, 3 },
                    { 2884, 9 },
                    { 2885, 2 },
                    { 2885, 3 },
                    { 2885, 9 },
                    { 2886, 2 },
                    { 2886, 9 },
                    { 2887, 2 },
                    { 2887, 3 },
                    { 2888, 2 },
                    { 2888, 3 },
                    { 2889, 12 },
                    { 2890, 12 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
                values: new object[,]
                {
                    { 2883, 3292, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/ads_list.txt" },
                    { 2884, 3293, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/ads_list_extended.txt" },
                    { 2885, 3294, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/ads_list_extended_plus.txt" },
                    { 2886, 3295, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/ads_list_rws.txt" },
                    { 2887, 3296, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/hosts/blocker.txt" },
                    { 2888, 3297, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/hosts/blockerFL.txt" },
                    { 2889, 3298, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/hosts/bypass.txt" },
                    { 2890, 3299, (short)1, (short)1, "https://raw.githubusercontent.com/Zalexanninev15/NoADS_RU/main/hosts/bypass2.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2883, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2884, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2885, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2886, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2887, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2888, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2889, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2890, (short)132 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2883, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2884, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2885, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2886, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2887, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2888, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2889, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2890, 226 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2883, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2883, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2884, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2884, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2885, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2885, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2886, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2886, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2887, (short)54 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2888, (short)54 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2889, (short)14 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2890, (short)14 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2883, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2883, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2884, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2884, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2884, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2885, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2885, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2885, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2886, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2886, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2887, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2887, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2888, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2888, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2889, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2890, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2883, 3292 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2884, 3293 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2885, 3294 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2886, 3295 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2887, 3296 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2888, 3297 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2889, 3298 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2890, 3299 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2883);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2884);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2885);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2886);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2887);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2888);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2889);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2890);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 226);
        }
    }
}
