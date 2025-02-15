using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4458 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2603,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Filters to bypass paywalls for news sites (supports less sites than the extension/add-on)", "https://gitflic.ru/project/magnolia1234/bypass-paywalls-clean-filters" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2603, 2867 },
                column: "Url",
                value: "https://gitflic.ru/project/magnolia1234/bypass-paywalls-clean-filters/blob/raw?file=bpc-paywall-filter.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2603,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Filters for news sites (supports less sites than the extension/add-on)", "https://github.com/bpc-clone/bypass-paywalls-clean-filters" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2603, 2867 },
                column: "Url",
                value: "https://raw.githubusercontent.com/bpc-clone/bypass-paywalls-clean-filters/main/bpc-paywall-filter.txt");
        }
    }
}
