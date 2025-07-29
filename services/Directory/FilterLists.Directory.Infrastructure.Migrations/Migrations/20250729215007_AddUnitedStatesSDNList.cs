using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddUnitedStatesSDNList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2742, null, "Machine-readable blocklist of websites belonging to entities listed under the United States Specially Designated Nationals List (SDN List). Contains domains of sanctioned entities.", null, null, null, "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites", "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites/issues", 10, "United States SDN List (Domains)", null, null, null },
                    { 2743, null, "Machine-readable blocklist of websites belonging to entities listed under the United States Specially Designated Nationals List (SDN List). Contains domains in Adblock Plus format.", null, null, null, "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites", "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites/issues", 10, "United States SDN List (Adblock Plus)", null, null, null },
                    { 2744, null, "Machine-readable blocklist of websites belonging to entities listed under the United States Specially Designated Nationals List (SDN List). Contains domains in uBlock Origin format.", null, null, null, "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites", "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites/issues", 10, "United States SDN List (uBlock Origin)", null, null, null },
                    { 2745, null, "Machine-readable blocklist of websites belonging to entities listed under the United States Specially Designated Nationals List (SDN List). Contains domains in uBlock Origin list format.", null, null, null, "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites", "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites/issues", 10, "United States SDN List (uBlock Origin List)", null, null, null },
                    { 2746, null, "Machine-readable blocklist of websites belonging to entities listed under the United States Specially Designated Nationals List (SDN List). Contains domains in Pi-hole format.", null, null, null, "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites", "https://github.com/elliotwutingfeng/United-States-SDN-List-Websites/issues", 10, "United States SDN List (Pi-hole)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2741, (short)1 });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2742, 174 },
                    { 2743, 174 },
                    { 2744, 174 },
                    { 2745, 174 },
                    { 2746, 174 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2742, (short)2 },
                    { 2743, (short)3 },
                    { 2744, (short)4 },
                    { 2745, (short)4 },
                    { 2746, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2742, 15 },
                    { 2742, 20 },
                    { 2743, 15 },
                    { 2743, 20 },
                    { 2744, 15 },
                    { 2744, 20 },
                    { 2745, 15 },
                    { 2745, 20 },
                    { 2746, 15 },
                    { 2746, 20 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2742, 3074, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/United-States-SDN-List-Websites/main/urls.txt" },
                    { 2743, 3075, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/United-States-SDN-List-Websites/main/urls-ABP.txt" },
                    { 2744, 3076, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/United-States-SDN-List-Websites/main/urls-UBO.txt" },
                    { 2745, 3077, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/United-States-SDN-List-Websites/main/urls-UBL.txt" },
                    { 2746, 3078, (short)1, "https://raw.githubusercontent.com/elliotwutingfeng/United-States-SDN-List-Websites/main/urls-pihole.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2742, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2743, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2744, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2745, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2746, 174 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2741, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2742, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2743, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2744, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2745, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2746, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2742, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2742, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2743, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2743, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2744, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2744, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2745, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2745, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2746, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2746, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2742, 3074 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2743, 3075 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2744, 3076 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2745, 3077 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2746, 3078 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2742);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2743);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2744);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2745);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2746);
        }
    }
}
