using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3114 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 566L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 569L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 570L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 573L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 574L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 575L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 583L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 585L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 586L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1799L, 5L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2125L, 5L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 566L, 2L },
                    { 566L, 10L },
                    { 569L, 2L },
                    { 570L, 2L },
                    { 573L, 2L },
                    { 574L, 2L },
                    { 575L, 2L },
                    { 583L, 2L },
                    { 585L, 2L },
                    { 586L, 2L },
                    { 1799L, 2L },
                    { 2125L, 2L },
                    { 2125L, 10L }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 566L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 569L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Chinese Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 570L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Czech Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 573L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - English Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 574L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - French Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 575L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - German Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 583L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Portuguese Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 585L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Russian Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 586L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Spanish Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1799L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters - Arabic Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2125L,
                columns: new[] { "description", "name" },
                values: new object[] { null, "ABP Filters (TPL)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2534L,
                column: "description",
                value: "This IP set combines IP and CIDR addresses from plentiful of major adblocker lists. It contains heavily altered content from Dandelion Sprout's Anti-Malware List, Dandelion Sprout's Nordic Filters, EasyList, uBlock Filters, uBlock Filters - Badware Risks, AdGuard Base Filter, AdGuard French Filter, EasyList Germany, RU AdList, Liste AR, and EasyList Spanish.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 566L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 566L, 10L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 569L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 570L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 573L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 574L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 575L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 583L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 585L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 586L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 1799L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2125L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2125L, 10L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[,]
                {
                    { 566L, 5L },
                    { 569L, 5L },
                    { 570L, 5L },
                    { 573L, 5L },
                    { 574L, 5L },
                    { 575L, 5L },
                    { 583L, 5L },
                    { 585L, 5L },
                    { 586L, 5L },
                    { 1799L, 5L },
                    { 2125L, 5L }
                });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 566L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 569L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Chinese Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 570L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Czech Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 573L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - English Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 574L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - French Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 575L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - German Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 583L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Portuguese Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 585L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Russian Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 586L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Spanish Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1799L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List - Arabic Only" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2125L,
                columns: new[] { "description", "name" },
                values: new object[] { "Filter list designed to fight circumvention ads in Adblock Plus", "ABP Anti-Circumvention Filter List (TPL)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2534L,
                column: "description",
                value: "This IP set combines IP and CIDR addresses from plentiful of major adblocker lists. It contains heavily altered content from Dandelion Sprout's Anti-Malware List, Dandelion Sprout's Nordic Filters, EasyList, uBlock Filters, uBlock Filters - Badware Risks, AdGuard Base Filter, AdGuard French Filter, EasyList Germany, ABP Anti-Circumvention Filters, RU AdList, Liste AR, and EasyList Spanish.");
        }
    }
}
