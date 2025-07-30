using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddChongLuaDaoPhishingBlocklist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2814, null, "Machine-readable blocklist of phishing URLs from the Chống Lừa Đảo project, updated once a day.", null, null, null, "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist", "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/issues", 10, "ChongLuaDao Phishing Blocklist (URLs)", null, null, null },
                    { 2815, null, "Machine-readable blocklist of phishing URLs from the Chống Lừa Đảo project in AdBlock Plus format, updated once a day.", null, null, null, "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist", "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/issues", 10, "ChongLuaDao Phishing Blocklist (AdBlock Plus)", null, null, null },
                    { 2816, null, "Machine-readable blocklist of phishing URLs from the Chống Lừa Đảo project in uBlock Origin format, updated once a day.", null, null, null, "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist", "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/issues", 10, "ChongLuaDao Phishing Blocklist (uBlock Origin)", null, null, null },
                    { 2817, null, "Machine-readable blocklist of phishing URLs from the Chống Lừa Đảo project in Pi-hole format, updated once a day.", null, null, null, "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist", "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/issues", 10, "ChongLuaDao Phishing Blocklist (Pi-hole)", null, null, null },
                    { 2818, null, "Machine-readable blocklist of phishing IPv4 addresses from the Chống Lừa Đảo project, updated once a day.", null, null, null, "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist", "https://github.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/issues", 10, "ChongLuaDao Phishing Blocklist (IPs)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2814, (short)171 },
                    { 2815, (short)171 },
                    { 2816, (short)171 },
                    { 2817, (short)171 },
                    { 2818, (short)171 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2814, 174 },
                    { 2815, 174 },
                    { 2816, 174 },
                    { 2817, 174 },
                    { 2818, 174 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2814, (short)8 },
                    { 2815, (short)3 },
                    { 2816, (short)4 },
                    { 2817, (short)2 },
                    { 2818, (short)9 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2814, 7 },
                    { 2815, 7 },
                    { 2816, 7 },
                    { 2817, 7 },
                    { 2818, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2814, 3205, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/main/urls.txt" },
                    { 2815, 3206, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/main/urls-ABP.txt" },
                    { 2816, 3207, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/main/urls-UBO.txt" },
                    { 2817, 3208, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/main/urls-pihole.txt" },
                    { 2818, 3209, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/ChongLuaDao-Phishing-Blocklist/main/ips.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2814, (short)171 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2815, (short)171 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2816, (short)171 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2817, (short)171 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2818, (short)171 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2814, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2815, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2816, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2817, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2818, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2814, (short)8 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2815, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2816, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2817, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2818, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2814, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2815, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2816, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2817, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2818, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2814, 3205 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2815, 3206 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2816, 3207 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2817, 3208 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2818, 3209 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2815);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2816);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2817);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2818);
        }
    }
}
