using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SplitUltimateHostsBlacklistDomainsIntoSegments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 694, 731 },
                column: "Url",
                value: "https://raw.githubusercontent.com/mitchellkrogza/Ultimate.Hosts.Blacklist/master/domains/domains0.list");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
                values: new object[,]
                {
                    { 694, 3083, (short)1, (short)2, "https://raw.githubusercontent.com/mitchellkrogza/Ultimate.Hosts.Blacklist/master/domains/domains1.list" },
                    { 694, 3084, (short)1, (short)3, "https://raw.githubusercontent.com/mitchellkrogza/Ultimate.Hosts.Blacklist/master/domains/domains2.list" },
                    { 694, 3085, (short)1, (short)4, "https://raw.githubusercontent.com/mitchellkrogza/Ultimate.Hosts.Blacklist/master/domains/domains3.list" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 694, 3083 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 694, 3084 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 694, 3085 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 694, 731 },
                column: "Url",
                value: "https://hosts.ubuntu101.co.za/domains.list");
        }
    }
}
