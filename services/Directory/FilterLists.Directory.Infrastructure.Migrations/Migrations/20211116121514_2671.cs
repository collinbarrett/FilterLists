using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2671 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2556,
                column: "Description",
                value: "Want to use ClearURLs without installing another extension? This list is a (unofficial) version of the ClearURLs rules, designed for use in uBlock Origin and AdGuard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2556,
                column: "Description",
                value: "This list target international websites that clutter Mastodon public timelines and userfeeds with misinformation, unfounded articles, and/or contempt for humanity.");
        }
    }
}
