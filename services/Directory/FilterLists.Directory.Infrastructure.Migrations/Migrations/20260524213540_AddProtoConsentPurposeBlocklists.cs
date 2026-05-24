using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddProtoConsentPurposeBlocklists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2849, null, "All purposes except Security, deduplicated domain blocklist (~157K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Core", null, null, null },
                    { 2850, null, "All six purposes including Security, deduplicated domain blocklist (~257K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Full", null, null, null },
                    { 2851, null, "Advertising networks and ad servers domain blocklist (~104K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Ads", null, null, null },
                    { 2852, null, "Analytics and measurement services domain blocklist (~34K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Analytics", null, null, null },
                    { 2853, null, "Fingerprinting and advanced tracking domain blocklist (~18K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Advanced Tracking", null, null, null },
                    { 2854, null, "Phishing, scam, and malware domains blocklist (~100K entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Security", null, null, null },
                    { 2855, null, "Social widgets and external embeds domain blocklist (~640 entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Third Parties", null, null, null },
                    { 2856, null, "A/B testing and personalization domain blocklist (~285 entries).", null, null, null, "https://github.com/ProtoConsent/data", "https://github.com/ProtoConsent/data/issues", 4, "ProtoConsent Personalization", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 214, null, "ProtoConsent", null, "https://github.com/ProtoConsent" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2849, (short)37 },
                    { 2850, (short)37 },
                    { 2851, (short)37 },
                    { 2852, (short)37 },
                    { 2853, (short)37 },
                    { 2854, (short)37 },
                    { 2855, (short)37 },
                    { 2856, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2849, 214 },
                    { 2850, 214 },
                    { 2851, 214 },
                    { 2852, 214 },
                    { 2853, 214 },
                    { 2854, 214 },
                    { 2855, 214 },
                    { 2856, 214 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2849, (short)2 },
                    { 2850, (short)2 },
                    { 2851, (short)2 },
                    { 2852, (short)2 },
                    { 2853, (short)2 },
                    { 2854, (short)2 },
                    { 2855, (short)2 },
                    { 2856, (short)2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2849, 2 },
                    { 2849, 3 },
                    { 2850, 2 },
                    { 2850, 3 },
                    { 2850, 6 },
                    { 2850, 7 },
                    { 2851, 2 },
                    { 2851, 3 },
                    { 2852, 3 },
                    { 2853, 3 },
                    { 2854, 6 },
                    { 2854, 7 },
                    { 2855, 3 },
                    { 2856, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2849, 3255, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_core.txt" },
                    { 2850, 3256, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_full.txt" },
                    { 2851, 3257, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_ads.txt" },
                    { 2852, 3258, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_analytics.txt" },
                    { 2853, 3259, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_advanced_tracking.txt" },
                    { 2854, 3260, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_security.txt" },
                    { 2855, 3261, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_third_parties.txt" },
                    { 2856, 3262, (short)1, "https://cdn.jsdelivr.net/gh/ProtoConsent/data@main/lists/domains/protoconsent_personalization.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2849, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2850, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2851, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2852, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2853, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2854, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2855, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2856, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2849, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2850, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2851, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2852, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2853, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2854, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2855, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2856, 214 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2849, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2850, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2851, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2852, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2853, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2854, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2855, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2856, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2849, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2849, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2850, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2850, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2850, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2850, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2851, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2851, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2852, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2853, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2854, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2854, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2855, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2856, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2849, 3255 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2850, 3256 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2851, 3257 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2852, 3258 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2853, 3259 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2854, 3260 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2855, 3261 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2856, 3262 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2849);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2850);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2851);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2852);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2853);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2854);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2855);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2856);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 214);
        }
    }
}
