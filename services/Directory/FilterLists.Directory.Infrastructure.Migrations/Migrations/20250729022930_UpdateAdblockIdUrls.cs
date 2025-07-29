using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdblockIdUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 728, 760 },
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID/main/dist/adblockid.adfl.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2289, 2434 },
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID/main/dist/adblockid_plus.adfl.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 728, 760 },
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID/master/output/adblockid.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2289, 2434 },
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID-Adult/master/AdBlockID_Adult.txt");
        }
    }
}
