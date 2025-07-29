using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGameIndustryHostsToEuDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1706,
                columns: new[] { "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "https://hosts.gameindustry.eu/", "https://github.com/KodoPengin/GameIndustry-hosts-Template/issues", "GameIndustry.eu Hosts" });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 1706, 19 },
                    { 1706, 20 }
                });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 1766 },
                column: "Url",
                value: "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Main-Template/hosts");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1706, 3072, (short)2, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Gaming-Full-Template/hosts" },
                    { 1706, 3073, (short)3, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Android-Mini-Template/hosts" }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 201, null, "KodoPengin", null, "https://github.com/KodoPengin" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 1706, 201 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1706, 201 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1706, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1706, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 3072 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 3073 });

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1706,
                columns: new[] { "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "https://gameindustry.de/", null, "GameIndustryDE Hosts" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 1766 },
                column: "Url",
                value: "https://www.gameindustry.eu/files/hosts.txt");
        }
    }
}
