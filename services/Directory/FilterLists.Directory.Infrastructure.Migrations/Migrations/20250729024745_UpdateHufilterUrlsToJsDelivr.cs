using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHufilterUrlsToJsDelivr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 72, 96 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/hufilter/hufilter@gh-pages/hufilter.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2392, 2570 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/hufilter/hufilter@gh-pages/hufilter-dns.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 72, 96 },
                column: "Url",
                value: "https://raw.githubusercontent.com/hufilter/hufilter/master/hufilter.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2392, 2570 },
                column: "Url",
                value: "https://raw.githubusercontent.com/hufilter/hufilter/master/hufilter-dns.txt");
        }
    }
}
