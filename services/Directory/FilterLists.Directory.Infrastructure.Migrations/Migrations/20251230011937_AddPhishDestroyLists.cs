using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddPhishDestroyLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2835, null, "Real-time updated blocklist of cryptocurrency phishing domains, scam sites, wallet drainers, fake exchanges and seed phrase phishing. DNS-verified active threats.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - Cryptocurrency Phishing Blocklist (Domains)", null, null, null },
                    { 2836, null, "Real-time updated blocklist of cryptocurrency phishing domains, scam sites, wallet drainers, fake exchanges and seed phrase phishing. DNS-verified active threats.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - Cryptocurrency Phishing Blocklist (AdBlock)", null, null, null },
                    { 2837, null, "Real-time updated blocklist of cryptocurrency phishing domains, scam sites, wallet drainers, fake exchanges and seed phrase phishing. DNS-verified active threats.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - Cryptocurrency Phishing Blocklist (Hosts)", null, null, null },
                    { 2838, null, "Real-time updated blocklist of cryptocurrency phishing domains, scam sites, wallet drainers, fake exchanges and seed phrase phishing. DNS-verified active threats.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - Cryptocurrency Phishing Blocklist (Dnsmasq)", null, null, null },
                    { 2839, null, "Community-aggregated cryptocurrency phishing blocklist from PhishDestroy containing scam sites, wallet drainers, fake exchanges and seed phrase phishing.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - Community Aggregated", null, null, null },
                    { 2840, null, "DNS-verified active cryptocurrency phishing domains from PhishDestroy including scam sites, wallet drainers, and fake exchanges.", null, "github@phishdestroy.io", null, "https://github.com/phishdestroy/destroylist", "https://github.com/phishdestroy/destroylist/issues", 2, "PhishDestroy - DNS-Verified Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 209, "github@phishdestroy.io", "PhishDestroy", null, "https://github.com/phishdestroy" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2835, (short)37 },
                    { 2836, (short)37 },
                    { 2837, (short)37 },
                    { 2838, (short)37 },
                    { 2839, (short)37 },
                    { 2840, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2835, 209 },
                    { 2836, 209 },
                    { 2837, 209 },
                    { 2838, 209 },
                    { 2839, 209 },
                    { 2840, 209 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2835, (short)2 },
                    { 2836, (short)3 },
                    { 2837, (short)1 },
                    { 2838, (short)20 },
                    { 2839, (short)2 },
                    { 2840, (short)2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2835, 1 },
                    { 2835, 6 },
                    { 2835, 7 },
                    { 2836, 1 },
                    { 2836, 6 },
                    { 2836, 7 },
                    { 2837, 1 },
                    { 2837, 6 },
                    { 2837, 7 },
                    { 2838, 1 },
                    { 2838, 6 },
                    { 2838, 7 },
                    { 2839, 1 },
                    { 2839, 6 },
                    { 2839, 7 },
                    { 2840, 1 },
                    { 2840, 6 },
                    { 2840, 7 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2835, 3232, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/list.txt" },
                    { 2836, 3233, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/rootlist/formats/primary/adblock.txt" },
                    { 2837, 3234, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/rootlist/formats/primary/hosts.txt" },
                    { 2838, 3235, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/rootlist/formats/primary/dnsmasq.conf" },
                    { 2839, 3236, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/community/blocklist.json" },
                    { 2840, 3237, (short)1, "https://raw.githubusercontent.com/phishdestroy/destroylist/main/dns/active_domains.json" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2835, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2836, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2837, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2838, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2839, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2840, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2835, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2836, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2837, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2838, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2839, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2840, 209 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2835, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2836, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2837, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2838, (short)20 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2839, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2840, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2835, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2835, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2835, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2836, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2836, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2836, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2837, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2837, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2837, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2838, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2838, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2838, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2839, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2839, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2839, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2840, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2840, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2840, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2835, 3232 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2836, 3233 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2837, 3234 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2838, 3235 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2839, 3236 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2840, 3237 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2835);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2836);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2837);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2838);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2839);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2840);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 209);
        }
    }
}
