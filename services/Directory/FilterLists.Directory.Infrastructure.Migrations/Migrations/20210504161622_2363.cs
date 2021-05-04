using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2363 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2705,
                column: "Url",
                value: "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/jp-annoyances-plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2097,
                column: "Name",
                value: "Yuki's uBlock Japanese filters - Annoyances Plus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2705,
                column: "Url",
                value: "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/jp-annoyances+.txt");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2097,
                column: "Name",
                value: "Yuki's uBlock Japanese filters - Annoyances+");
        }
    }
}
