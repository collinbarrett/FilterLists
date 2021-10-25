using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2606 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2752,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2753,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2756, 2537, (short)2, "https://iam-py-test.github.io/my_filters_001/antimalware.txt" },
                    { 2757, 2538, (short)2, "https://iam-py-test.github.io/my_filters_001/Alternative list formats/antimalware_hosts.txt" }
                });

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2538,
                column: "IssuesUrl",
                value: "https://github.com/iam-py-test/my_filters_001/issues/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2756);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2757);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2752,
                column: "Primariness",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2753,
                column: "Primariness",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2538,
                column: "IssuesUrl",
                value: null);
        }
    }
}
