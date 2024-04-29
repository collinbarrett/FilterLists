using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4264 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 430L, 558L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList alternate versions/NordicHosts.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 430L, 559L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/raw/master/NorwegianExperimentalList alternate versions/NordicHosts.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1564L, 1566L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiCelebBirthList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1564L, 1567L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/raw/master/AntiCelebBirthList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2533L, 2746L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Sensitive lists/AntiOWDList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2533L, 2747L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Sensitive lists/AntiOWDList.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 430L, 558L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList alternate versions/AdawayHosts");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 430L, 559L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/raw/master/NorwegianExperimentalList alternate versions/AdawayHosts");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1564L, 1566L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiCelebBirthList");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1564L, 1567L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/raw/master/AntiCelebBirthList");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2533L, 2746L },
                column: "url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiOwlHouseList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2533L, 2747L },
                column: "url",
                value: "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiOwlHouseList.txt");
        }
    }
}
