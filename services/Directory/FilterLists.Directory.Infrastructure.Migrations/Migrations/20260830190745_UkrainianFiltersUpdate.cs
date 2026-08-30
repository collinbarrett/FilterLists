using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UkrainianFiltersUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2669,
                columns: new[] { "Description", "DonateUrl", "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "Filter list designed to remove ads from Ukrainian websites, block trackers, harmful scripts and malicious web resources (phishing, online fraud, malware, and more)", null, "https://github.com/ukrainianfilters/lists", "https://github.com/ukrainianfilters/lists/issues", "Ukrainian Ad & Privacy Filters" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2670,
                column: "DonateUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2671,
                column: "DonateUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2672,
                column: "DonateUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2669, 2953 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/ukrainianfilters/lists@main/combined/combined.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2670, 2954 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/ukrainianfilters/lists@main/ads/ads.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2671, 2955 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/ukrainianfilters/lists@main/annoyances/annoyances.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2672, 2956 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/ukrainianfilters/lists@main/privacy/privacy.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2669,
                columns: new[] { "Description", "DonateUrl", "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "Filter of malicious web resources (phishing, online fraud, malware, etc.) targeting Ukrainian citizens", "https://github.com/ukrainianfilters/lists#підтримати-проєкт", "https://github.com/braveinnovators/ukrainian-security-filter", "https://github.com/braveinnovators/ukrainian-security-filter/issues", "Ukrainian Security Filter" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2670,
                column: "DonateUrl",
                value: "https://github.com/ukrainianfilters/lists#підтримати-проєкт");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2671,
                column: "DonateUrl",
                value: "https://github.com/ukrainianfilters/lists#підтримати-проєкт");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2672,
                column: "DonateUrl",
                value: "https://github.com/ukrainianfilters/lists#підтримати-проєкт");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2669, 2953 },
                column: "Url",
                value: "https://raw.githubusercontent.com/braveinnovators/ukrainian-security-filter/main/lists/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2670, 2954 },
                column: "Url",
                value: "https://raw.githubusercontent.com/ukrainianfilters/lists/main/ads/ads.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2671, 2955 },
                column: "Url",
                value: "https://raw.githubusercontent.com/ukrainianfilters/lists/main/annoyances/annoyances.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2672, 2956 },
                column: "Url",
                value: "https://raw.githubusercontent.com/ukrainianfilters/lists/main/privacy/privacy.txt");
        }
    }
}
