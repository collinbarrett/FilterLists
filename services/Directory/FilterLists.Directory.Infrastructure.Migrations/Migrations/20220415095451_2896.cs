using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2896 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2800L },
                column: "url",
                value: "https://cdn.statically.io/gl/BPower0036/EasyDutch/raw/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2801L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutch@gh-pages/EasyDutch.txt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2800L },
                column: "url",
                value: "https://cdn.statically.io/gl/BPower0036/EasyDutch/-/raw/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2801L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutch/@gh-pages/EasyDutch.txt");
        }
    }
}
