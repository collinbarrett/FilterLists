using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4451 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2669,
                column: "DonateUrl",
                value: "https://github.com/ukrainianfilters/lists#підтримати-проєкт");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2670,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/ukrainianfilters/lists#підтримати-проєкт", "https://github.com/ukrainianfilters/lists", "https://github.com/ukrainianfilters/lists/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2671,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/ukrainianfilters/lists#підтримати-проєкт", "https://github.com/ukrainianfilters/lists", "https://github.com/ukrainianfilters/lists/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2672,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/ukrainianfilters/lists#підтримати-проєкт", "https://github.com/ukrainianfilters/lists", "https://github.com/ukrainianfilters/lists/issues" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2669,
                column: "DonateUrl",
                value: "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2670,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект", "https://github.com/serhiyguryev/ukrainian-filters", "https://github.com/serhiyguryev/ukrainian-filters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2671,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект", "https://github.com/serhiyguryev/ukrainian-filters", "https://github.com/serhiyguryev/ukrainian-filters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2672,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект", "https://github.com/serhiyguryev/ukrainian-filters", "https://github.com/serhiyguryev/ukrainian-filters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2670, 2954 },
                column: "Url",
                value: "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/ads.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2671, 2955 },
                column: "Url",
                value: "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/annoyances.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2672, 2956 },
                column: "Url",
                value: "https://raw.githubusercontent.com/serhiyguryev/ukrainian-filters/main/filters/privacy.txt");
        }
    }
}
