using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2370 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2705,
                columns: new[] { "FilterListId", "Url" },
                values: new object[] { 2496, "https://raw.githubusercontent.com/troysjanda/MyBlockLists/master/UBOXPI" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2706,
                columns: new[] { "FilterListId", "Url" },
                values: new object[] { 2097, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/jp-annoyances-plus.txt" });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2707, 2098, (short)1, "https://raw.githubusercontent.com/Yuki2718/adblock/master/adguard/anti-antiadb.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2707);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2705,
                columns: new[] { "FilterListId", "Url" },
                values: new object[] { 2097, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/jp-annoyances-plus.txt" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2706,
                columns: new[] { "FilterListId", "Url" },
                values: new object[] { 2098, "https://raw.githubusercontent.com/Yuki2718/adblock/master/adguard/anti-antiadb.txt" });
        }
    }
}
