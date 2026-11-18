using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations;

/// <inheritdoc />
public partial class _20261118001908_AddThreatClusterMaliciousDomains : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "FilterList",
            columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
            values: new object[,]
            {
                { 2896, null, "High-confidence malicious domains observed in security incidents over the last 30 days, extracted from multi-source threat reporting and validated before publication. Refreshed hourly; stable entries, false positives retired automatically.", null, "hello@threatcluster.io", null, "https://threatcluster.io/iocs", "https://github.com/Jam0k/Threat-Intelligence-MCP/issues", 24, "ThreatCluster Malicious Domains", null, "https://threatcluster.io/iocs", null },
                { 2897, null, "High-confidence malicious domains observed in security incidents over the last 30 days, extracted from multi-source threat reporting and validated before publication. Refreshed hourly; stable entries, false positives retired automatically.", null, "hello@threatcluster.io", null, "https://threatcluster.io/iocs", "https://github.com/Jam0k/Threat-Intelligence-MCP/issues", 24, "ThreatCluster Malicious Domains (Hosts)", null, "https://threatcluster.io/iocs", null },
                { 2898, null, "High-confidence malicious domains observed in security incidents over the last 30 days, extracted from multi-source threat reporting and validated before publication. Refreshed hourly; stable entries, false positives retired automatically.", null, "hello@threatcluster.io", null, "https://threatcluster.io/iocs", "https://github.com/Jam0k/Threat-Intelligence-MCP/issues", 24, "ThreatCluster Malicious Domains (AdGuard/uBlock)", null, "https://threatcluster.io/iocs", null }
            });

        migrationBuilder.InsertData(
            table: "Maintainer",
            columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
            values: new object[] { 228, null, "ThreatCluster", null, "https://threatcluster.io/" });

        migrationBuilder.InsertData(
            table: "Tag",
            columns: new[] { "Id", "Description", "Name" },
            values: new object[,]
            {
                { 46, "Indicators of compromise and reporting about cyber threats", "threat-intelligence" },
                { 47, "Focuses on cybersecurity threats and defensive use", "security" }
            });

        migrationBuilder.InsertData(
            table: "FilterListLanguage",
            columns: new[] { "FilterListId", "LanguageId" },
            values: new object[,]
            {
                { 2896, (short)37 },
                { 2897, (short)37 },
                { 2898, (short)37 }
            });

        migrationBuilder.InsertData(
            table: "FilterListMaintainer",
            columns: new[] { "FilterListId", "MaintainerId" },
            values: new object[,]
            {
                { 2896, 228 },
                { 2897, 228 },
                { 2898, 228 }
            });

        migrationBuilder.InsertData(
            table: "FilterListSyntax",
            columns: new[] { "FilterListId", "SyntaxId" },
            values: new object[,]
            {
                { 2896, (short)2 },
                { 2897, (short)54 },
                { 2898, (short)4 }
            });

        migrationBuilder.InsertData(
            table: "FilterListTag",
            columns: new[] { "FilterListId", "TagId" },
            values: new object[,]
            {
                { 2896, 6 },
                { 2896, 46 },
                { 2896, 47 },
                { 2897, 6 },
                { 2897, 46 },
                { 2897, 47 },
                { 2898, 6 },
                { 2898, 46 },
                { 2898, 47 }
            });

        migrationBuilder.InsertData(
            table: "FilterListViewUrl",
            columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
            values: new object[,]
            {
                { 2896, 3305, (short)1, (short)1, "https://threatcluster.io/api/iocs/public/domains.txt" },
                { 2897, 3306, (short)1, (short)1, "https://threatcluster.io/api/iocs/public/hosts.txt" },
                { 2898, 3307, (short)1, (short)1, "https://threatcluster.io/api/iocs/public/adguard.txt" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "FilterListLanguage",
            keyColumns: new[] { "FilterListId", "LanguageId" },
            keyValues: new object[] { 2896, (short)37 });

        migrationBuilder.DeleteData(
            table: "FilterListLanguage",
            keyColumns: new[] { "FilterListId", "LanguageId" },
            keyValues: new object[] { 2897, (short)37 });

        migrationBuilder.DeleteData(
            table: "FilterListLanguage",
            keyColumns: new[] { "FilterListId", "LanguageId" },
            keyValues: new object[] { 2898, (short)37 });

        migrationBuilder.DeleteData(
            table: "FilterListMaintainer",
            keyColumns: new[] { "FilterListId", "MaintainerId" },
            keyValues: new object[] { 2896, 228 });

        migrationBuilder.DeleteData(
            table: "FilterListMaintainer",
            keyColumns: new[] { "FilterListId", "MaintainerId" },
            keyValues: new object[] { 2897, 228 });

        migrationBuilder.DeleteData(
            table: "FilterListMaintainer",
            keyColumns: new[] { "FilterListId", "MaintainerId" },
            keyValues: new object[] { 2898, 228 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2896, (short)2 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2897, (short)54 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2898, (short)4 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2896, 6 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2896, 46 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2896, 47 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2897, 6 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2897, 46 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2897, 47 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2898, 6 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2898, 46 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2898, 47 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2896, 3305 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2897, 3306 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2898, 3307 });

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2896);

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2897);

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2898);

        migrationBuilder.DeleteData(
            table: "Maintainer",
            keyColumn: "Id",
            keyValue: 228);

        migrationBuilder.DeleteData(
            table: "Tag",
            keyColumn: "Id",
            keyValue: 46);

        migrationBuilder.DeleteData(
            table: "Tag",
            keyColumn: "Id",
            keyValue: 47);
    }
}
