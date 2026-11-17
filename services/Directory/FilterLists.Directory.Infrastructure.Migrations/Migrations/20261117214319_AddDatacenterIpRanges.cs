using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations;

/// <inheritdoc />
public partial class _20261117214319_AddDatacenterIpRanges : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "FilterList",
            columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
            values: new object[,]
            {
                { 2894, null, "Cloud, hosting and CDN IP ranges (AWS, Google Cloud, Oracle Cloud, DigitalOcean, Akamai Cloud/Linode, Vultr, Cloudflare, Fastly, GitHub) merged from the feeds each provider publishes itself, rebuilt daily. One CIDR per line. Tor exits, iCloud Private Relay and crawler ranges are kept out of these two lists. An nginx `geo` setup is in the README.", null, null, null, "https://github.com/moonetix/datacenter-ip-ranges", "https://github.com/moonetix/datacenter-ip-ranges/issues", 2, "Datacenter IP Ranges (IPv4)", null, null, null },
                { 2895, null, "Cloud, hosting and CDN IP ranges (AWS, Google Cloud, Oracle Cloud, DigitalOcean, Akamai Cloud/Linode, Vultr, Cloudflare, Fastly, GitHub) merged from the feeds each provider publishes itself, rebuilt daily. One CIDR per line. Tor exits, iCloud Private Relay and crawler ranges are kept out of these two lists. An nginx `geo` setup is in the README.", null, null, null, "https://github.com/moonetix/datacenter-ip-ranges", "https://github.com/moonetix/datacenter-ip-ranges/issues", 2, "Datacenter IP Ranges (IPv6)", null, null, null }
            });

        migrationBuilder.InsertData(
            table: "Maintainer",
            columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
            values: new object[] { 227, null, "Moonetix", null, "https://moonetix.com/" });

        migrationBuilder.InsertData(
            table: "FilterListMaintainer",
            columns: new[] { "FilterListId", "MaintainerId" },
            values: new object[,]
            {
                { 2894, 227 },
                { 2895, 227 }
            });

        migrationBuilder.InsertData(
            table: "FilterListSyntax",
            columns: new[] { "FilterListId", "SyntaxId" },
            values: new object[,]
            {
                { 2894, (short)34 },
                { 2895, (short)41 }
            });

        migrationBuilder.InsertData(
            table: "FilterListTag",
            columns: new[] { "FilterListId", "TagId" },
            values: new object[,]
            {
                { 2894, 20 },
                { 2895, 20 }
            });

        migrationBuilder.InsertData(
            table: "FilterListViewUrl",
            columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
            values: new object[,]
            {
                { 2894, 3303, (short)1, (short)1, "https://raw.githubusercontent.com/moonetix/datacenter-ip-ranges/main/data/ipv4.txt" },
                { 2895, 3304, (short)1, (short)1, "https://raw.githubusercontent.com/moonetix/datacenter-ip-ranges/main/data/ipv6.txt" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "FilterListMaintainer",
            keyColumns: new[] { "FilterListId", "MaintainerId" },
            keyValues: new object[] { 2894, 227 });

        migrationBuilder.DeleteData(
            table: "FilterListMaintainer",
            keyColumns: new[] { "FilterListId", "MaintainerId" },
            keyValues: new object[] { 2895, 227 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2894, (short)34 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2895, (short)41 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2894, 20 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2895, 20 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2894, 3303 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2895, 3304 });

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2894);

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2895);

        migrationBuilder.DeleteData(
            table: "Maintainer",
            keyColumn: "Id",
            keyValue: 227);
    }
}
