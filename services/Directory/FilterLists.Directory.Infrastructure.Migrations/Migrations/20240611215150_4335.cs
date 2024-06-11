using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4335 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 238, 362 },
                column: "Url",
                value: "https://www.rakuten.ca/static/cashback-shopping-whitelist?title=Rakuten Cash Back Shopping");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 1, null, "This complements AdGuard Japanese filter and mainly consists of 1) additional generic rules to counter circumvention ads and anti-adblock, and 2) specific rules to address sites not addresed in the Japanese filters.", null, null, null, "https://github.com/Yuki2718/adblock2", "https://github.com/Yuki2718/adblock2/issues", 4, "AdGuard Japanese filter Plus", null, null, null });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 238, 362 },
                column: "Url",
                value: "https://www.ebates.com/whitelist/ebates-cash-back-shopping.txt");
        }
    }
}
