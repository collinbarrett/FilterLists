using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SplitGameIndustryHostsIntoSeparateEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 3072 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1706, 3073 });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1706,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Main template hosts file for blocking spyware, ads, analytics and tracking on German websites and domains.", "GameIndustry.eu Hosts Main Template" });

            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2740, null, "Gaming-focused hosts file for blocking spyware, ads, analytics and tracking with comprehensive gaming industry coverage.", null, null, null, "https://hosts.gameindustry.eu/", "https://github.com/KodoPengin/GameIndustry-hosts-Template/issues", 9, "GameIndustry.eu Hosts Gaming Full Template", null, null, null },
                    { 2741, null, "Minimalist hosts file optimized for Android and mobile devices, blocking essential spyware, ads, and tracking.", null, null, null, "https://hosts.gameindustry.eu/", "https://github.com/KodoPengin/GameIndustry-hosts-Template/issues", 9, "GameIndustry.eu Hosts Android Mini Template", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2740, 201 },
                    { 2741, 201 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2740, 2 },
                    { 2740, 3 },
                    { 2740, 6 },
                    { 2740, 19 },
                    { 2740, 20 },
                    { 2741, 2 },
                    { 2741, 3 },
                    { 2741, 6 },
                    { 2741, 19 },
                    { 2741, 20 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2740, 3072, (short)1, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Gaming-Full-Template/hosts" },
                    { 2741, 3073, (short)1, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Android-Mini-Template/hosts" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2740, 201 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2741, 201 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2740, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2740, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2740, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2740, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2740, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2741, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2741, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2741, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2741, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2741, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2740, 3072 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2741, 3073 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2741);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1706,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Hosts file for blocking spyware, ads, analytics and tracking on German websites and domains.", "GameIndustry.eu Hosts" });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1706, 3072, (short)2, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Gaming-Full-Template/hosts" },
                    { 1706, 3073, (short)3, "https://raw.githubusercontent.com/KodoPengin/GameIndustry-hosts-Template/master/Android-Mini-Template/hosts" }
                });
        }
    }
}
