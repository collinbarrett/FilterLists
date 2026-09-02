using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class FabrizioSalmiDomainsBlacklist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2862, null, "Daily-updated domains blocklist aggregated and de-duplicated from 46 curated upstream sources, with per-source attribution, verified licences and a public false-positive cross-check. Covers advertising, tracking, malware and phishing, plus gambling, piracy, streaming and adult domains from some upstream sources.", null, null, null, "https://github.com/fabriziosalmi/blacklists", "https://github.com/fabriziosalmi/blacklists/issues", 4, "Fabrizio Salmi's Domains Blacklist", null, null, "https://github.com/fabriziosalmi/blacklists/pulls" },
                    { 2863, null, "Daily-updated domains blocklist aggregated and de-duplicated from 46 curated upstream sources, published in Unbound format with per-source attribution, verified licences and a public false-positive cross-check. Covers advertising, tracking, malware and phishing, plus gambling, piracy, streaming and adult domains from some upstream sources.", null, null, null, "https://github.com/fabriziosalmi/blacklists", "https://github.com/fabriziosalmi/blacklists/issues", 4, "Fabrizio Salmi's Domains Blacklist (Unbound)", null, null, "https://github.com/fabriziosalmi/blacklists/pulls" },
                    { 2864, null, "Daily-updated domains blocklist aggregated and de-duplicated from 46 curated upstream sources, published in Response Policy Zone format with per-source attribution, verified licences and a public false-positive cross-check. Covers advertising, tracking, malware and phishing, plus gambling, piracy, streaming and adult domains from some upstream sources.", null, null, null, "https://github.com/fabriziosalmi/blacklists", "https://github.com/fabriziosalmi/blacklists/issues", 4, "Fabrizio Salmi's Domains Blacklist (RPZ)", null, null, "https://github.com/fabriziosalmi/blacklists/pulls" }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 218, null, "Fabrizio Salmi", null, "https://github.com/fabriziosalmi" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2862, 218 },
                    { 2863, 218 },
                    { 2864, 218 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2862, (short)2 },
                    { 2863, (short)24 },
                    { 2864, (short)25 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2862, 2 },
                    { 2862, 3 },
                    { 2862, 6 },
                    { 2862, 7 },
                    { 2863, 2 },
                    { 2863, 3 },
                    { 2863, 6 },
                    { 2863, 7 },
                    { 2864, 2 },
                    { 2864, 3 },
                    { 2864, 6 },
                    { 2864, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2862, 3269, (short)1, "https://github.com/fabriziosalmi/blacklists/releases/download/latest/blacklist.txt" },
                    { 2863, 3270, (short)1, "https://github.com/fabriziosalmi/blacklists/releases/download/latest/unbound_blacklist.txt" },
                    { 2864, 3271, (short)1, "https://github.com/fabriziosalmi/blacklists/releases/download/latest/rpz_blacklist.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2862, 218 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2863, 218 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2864, 218 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2862, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2863, (short)24 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2864, (short)25 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2862, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2862, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2862, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2862, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2863, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2863, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2863, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2863, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2864, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2864, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2864, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2864, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2862, 3269 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2863, 3270 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2864, 3271 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2862);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2863);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2864);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 218);
        }
    }
}
