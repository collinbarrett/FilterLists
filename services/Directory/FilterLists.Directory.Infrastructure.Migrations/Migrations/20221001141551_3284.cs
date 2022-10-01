using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3284 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2559L, 2782L },
                column: "url",
                value: "https://gitlab.com/huzunluartemis/TurkishAdblockList/-/raw/main/src/HostsList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2560L, 2783L },
                column: "url",
                value: "https://gitlab.com/huzunluartemis/TurkishAdblockList/-/raw/main/src/ElementalList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2561L, 2784L },
                column: "url",
                value: "https://gitlab.com/huzunluartemis/TurkishAdblockList/-/raw/main/src/BadIpList.txt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2559L, 2782L },
                column: "url",
                value: "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/HostsList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2560L, 2783L },
                column: "url",
                value: "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/ElementalList.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2561L, 2784L },
                column: "url",
                value: "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/BadIpList.txt");
        }
    }
}
