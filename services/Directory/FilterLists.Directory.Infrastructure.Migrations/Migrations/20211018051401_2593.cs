using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2593 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1528, "az" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1528, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1563, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1929, "no" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1961, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1962, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2249, "ar" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2259, "sk" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2391, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 90, 57 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 270, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 271, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 286, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 287, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 303, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 304, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 685, 88 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 820, 57 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 867, 38 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1476, 119 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1528, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1542, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1565, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1839, 144 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1929, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1966, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1997, 144 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2016, 154 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2042, 64 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2249, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2259, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2391, 144 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 138, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 270, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 270, 16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 271, 28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 286, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 287, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 303, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 304, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 685, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 716, 37 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 732, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 820, 51 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 867, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1476, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1481, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1528, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1542, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1563, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1565, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1726, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1823, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1839, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1929, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1936, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1961, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1962, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1966, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1997, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2016, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2033, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2042, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2076, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2249, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2259, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2296, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2312, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2391, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 138, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 270, 14 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 271, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 286, 14 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 287, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 303, 14 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 303, 23 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 304, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 685, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 716, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 732, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 820, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 867, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 867, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 867, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 867, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1476, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1476, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1481, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1481, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1528, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1542, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1563, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1565, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1726, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1823, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1839, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1929, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1936, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1961, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1962, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1966, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1966, 11 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1966, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1997, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2016, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2033, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2076, 8 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2249, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2259, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2296, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2312, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2391, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2391);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2318,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2179,
                columns: new[] { "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://repo.palemoon.org/Moonchild/lunarblocklist", "https://repo.palemoon.org/Moonchild/lunarblocklist/issues" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2318,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2317, 2179, (short)1, "https://raw.githubusercontent.com/wolfbeast/lunarblocklist/master/list/lunar-blocklist.txt" });

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2179,
                columns: new[] { "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://github.com/wolfbeast/lunarblocklist", "https://github.com/wolfbeast/lunarblocklist/issues" });

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2390, null, null, "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=L6CV86VX9V5QN", null, null, "https://www.ntop.org/", null, 5, "ntop Blacklists - IP Blacklist", null, null, null },
                    { 1935, null, "The list contains domains (FQDN) collected over the last seven days by the web application. From any of these domains has been downloaded and analyzed a suspicious binary file.", null, null, null, "https://infosec.cert-pa.it/", null, 5, "CERT-PA Domains", null, null, null },
                    { 1936, null, null, null, null, null, "https://hashdd.com/", null, 5, "VXVault (Domains)", null, null, null },
                    { 1960, null, "Darklist.de is an IP blacklist that uses multiple sensors to identify network attacks (e.g. SSH brute force) and spam incidents. All reports are evaluated and in case of too many incidents the responsible IP holder is informed to solve the problem. After reporting an incident as solved the IP is removed from the blacklist.", null, null, null, "https://www.darklist.de/", null, 5, "DarklistDE IP Blacklist", null, null, null },
                    { 1961, null, null, null, null, null, "https://github.com/xorcan/hosts/", null, 4, "xorcan Türk element-ad-list (Turkish)", null, null, null },
                    { 1962, null, null, null, null, null, "https://github.com/xorcan/hosts/", null, 4, "xorcan Türk harmful ip-list (Turkish)", null, null, null },
                    { 1966, null, "PornHub is a site full of distractions and things that you are quite literally not into. If you wish to focus on the things there that you really are into, you can use this list.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "PornHub: Pure Trail Mix Experience", null, null, null },
                    { 1997, null, null, null, null, null, "https://github.com/Cybo1927/Hosts", "https://github.com/Cybo1927/Hosts/issues", 11, "Cybo's Anti Third Party HTTP", null, null, null },
                    { 2015, null, null, null, null, null, "https://blocklist.site/", null, 11, "Block List Project: Phishing", null, null, null },
                    { 2391, null, null, null, null, null, "https://github.com/Cybo1927/Hosts", "https://github.com/Cybo1927/Hosts/issues", 11, "Cybo's Anti Nightcore", null, null, null },
                    { 2016, null, null, null, null, null, "https://blocklist.site/", null, 11, "Block List Project: Spam", null, null, null },
                    { 1929, null, "I have a pretty long resumé when it comes to translating programs, apps, and websites; but what could be done with websites that don't accept uncommisioned translations or even any translations at all? The solution is of course to create an ungodly nightmare of a CSS style list for uBO and AdGuard, that uses a meticulously surrealistic CSS workaround to replace parts of existing site objects with new objects!", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Dandelion Sprout's Norwegian Fan Translations for Untranslatable Websites", null, null, null },
                    { 2042, null, "A filter that blocks the thumbnails of users that upload junk or stuff in the wrong categories.", null, null, null, "https://github.com/lassekongo83/Frellwits-filter-lists", "https://github.com/lassekongo83/Frellwits-filter-lists/issues", 4, "deviantJUNKfilter", null, null, null },
                    { 2076, null, "This will remove cookie and privacy warnings.", "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WMGE9MAGGGMHW", "easylist@protonmail.com", "https://forums.lanik.us/", "https://easylist.to/", "https://github.com/easylist/easylist/issues", 16, "EasyList Cookie List (TPL)", null, null, null },
                    { 2178, null, "Sites engaged in Phishing", null, null, null, null, null, 5, "hpHosts PSH", null, null, null },
                    { 2249, null, "Liste AR is an EasyList affiliated filter list that specifically removes adverts on Arabic language websites. The Minified lists are part of an Adblock Plus-hosted unofficial project that was hardforked from their source lists in August 2019, and which have only seen sporadic updates since then.", null, null, null, "https://hg.adblockplus.org/customfilterlists/file/default", null, 6, "Liste AR (Minified)", null, null, null },
                    { 2259, null, "Official filter list file used for blocking ads on Czech and Slovak websites. The Minified lists are part of an Adblock Plus-hosted unofficial project that was hardforked from their source lists in August 2019, and which have only seen sporadic updates since then.", null, null, null, "https://hg.adblockplus.org/customfilterlists/file/default", null, 8, "EasyList Czech and Slovak (TPL Minified)", null, null, null },
                    { 2296, null, "For use with Adblock by Futuremind", null, null, null, "https://github.com/BlackJack8/iOSAdblockList/", "https://github.com/BlackJack8/iOSAdblockList/issues", null, "Host-List for iOS ad blockers (Hosts)", null, null, null },
                    { 2312, null, "REScure is an independent threat intelligence project which we undertook to enhance our understanding of distributed systems, their integration, the nature of threat intelligence and how to efficiently collect, store, consume, distribute it.", null, "hello@theprohack.com", null, "https://rescure.fruxlabs.com/", null, 5, "The REScure Cyber Threat Intelligence Feed Project (beta) Maze Ransomware", null, null, null },
                    { 2032, null, "The address block lists are aggregated by country. What this means is that if for instance IP address blocks 192.168.0.100/24 and 192.168.0.101/24 are allocated/assigned to the same country, we will merge them into a single 192.168.0.100/23. That's why our lists may appear smaller in size when compared to other IP address block lists when in fact they are just highly optimized to not waste memory in your router.", null, null, null, "http://ipverse.net/", null, 5, "IPverse IP address block lists - Romania IPv6", null, null, null },
                    { 2033, null, null, null, null, null, null, null, 5, "Blockzilla (Hosts)", null, null, null },
                    { 1839, null, "A blocklist of ads, trackers, malware, and IP grabbers", null, null, null, "https://github.com/Cybo1927/Hosts", "https://github.com/Cybo1927/Hosts/issues", 11, "Cybo's Anti Verizon", null, null, null },
                    { 1822, null, "The following list is individual IP Addresses that have attempted to attack our servers. These IP addresses are currently recommended as a DENY, REJECT or BLOCK on your firewalls.", "https://www.cruzit.com/hth.php", null, null, "https://www.cruzit.com/wbl.php", null, 5, "Cruzit Server Blocklist", null, null, null },
                    { 138, null, "Streaming services ads sources", null, null, null, "https://github.com/FadeMind/hosts.extras", "https://github.com/FadeMind/hosts.extras/issues", 2, "StreamingAds", null, null, null },
                    { 270, null, "This is a list of free/bulk domain registration services, who register 2nd level domains for free or almost free.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Bulk Registrars", null, null, null },
                    { 271, null, "This is a list of malware domains generated from malwaredomains.com data.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Adblock Plus Malware Domains Full", null, null, null },
                    { 286, null, "This is a list of free web hosting services.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Free Web Hosts", null, null, null },
                    { 287, null, "This is a list of malware domains.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Malware Domains", null, null, null },
                    { 303, null, "This is a list of URL shorteners.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH URL Shorteners", null, null, null },
                    { 304, null, "A list of Skype resolvers.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Skype Resolvers", null, null, null },
                    { 685, null, "This is a list of malware domains.", "https://www.malwaredomains.com/?page_id=675", "malwaredomains@gmail.com", null, "https://www.malwaredomains.com/", null, 5, "DNS-BH Malware Domains (Hosts)", null, null, null },
                    { 716, null, null, null, null, null, "https://github.com/lennylxx/ipv6-hosts", "https://github.com/lennylxx/ipv6-hosts/issues", 2, "lennylxx IPv6 Hosts", null, null, null },
                    { 1823, null, null, null, null, null, null, null, 5, "Unsubscore Blacklist", null, null, null },
                    { 732, null, "This is a blocklist (might not be ad specific) for ublock orgin and other blockers... Reason: Out of box nagware/pop up box less internet (also used by me)", "https://bads.team/ultrapage#donate", "hello@bads.team", null, "https://github.com/dariusworks/superblock", "https://github.com/dariusworks/superblock/issues", 2, "BADS.TM Cleaner Sites List All In One", null, null, null },
                    { 867, null, "This aim to block non-formal hosts that serve all Facebook contents and resources from alternative \"Free Basics\" servers that it happen when you're using on mobile data over the carrier that collaborate with Facebook to have THAT service! The static version will list related sites of Facebook under Free Baiscs (include internet.org) and regional CDN that begin with z-m- (scontent, static, video).", null, null, null, "https://github.com/kowith337/PersonalFilterListCollection", "https://github.com/kowith337/PersonalFilterListCollection/issues?q=label%3A\"Hosts+File\"", 13, "Facebook Zero Hosts Block (Static)", null, null, null },
                    { 1475, null, null, null, null, null, "https://hblock.molinero.dev/", null, 2, "hBlock Hosts", null, null, null },
                    { 1476, null, null, null, null, null, "https://hblock.molinero.dev/", null, 2, "hBlock Hosts for Android", null, null, null },
                    { 1481, null, null, null, null, null, "https://github.com/jawz101/MobileAdTrackers", "https://github.com/jawz101/MobileAdTrackers/issues", 5, "jawz101 MobileAdTrackers", null, null, null },
                    { 1528, null, "Filter that enables removing of the ads from websites with English content or content in languages that lack separate AdGuard lists.", null, null, "https://forum.adguard.com/index.php?categories/filter-rules.66/", "https://github.com/AdguardTeam/AdguardFilters", "https://github.com/AdguardTeam/AdguardFilters/issues", 40, "AdGuard Base Filter without EasyList (AdGuard for Chromium)", null, "https://kb.adguard.com/en/general/adguard-filter-policy", null },
                    { 1542, null, null, null, "easylist@protonmail.com", "https://forums.lanik.us/", "https://easylist.to/", "https://github.com/easylist/easylist/issues", 4, "Adware Filters (TPL)", null, null, null },
                    { 1563, null, "Hosts file for annoying ads", null, null, null, "https://github.com/xorcan/hosts", "https://github.com/xorcan/hosts/issues", 4, "xorcan Türk ad-list (Turkish)", null, null, null },
                    { 1565, null, "While it was admirable that places like GOG, Humble Bundle, and Steam began selling movies and books, their categories for such quickly became a dumping ground for useless indie filler. No one needs three book bundles a month about how to write JavaScript, nor do they need a cashgrab \"documentary\" about bronies. This list is for those who once again want to reclaim such stores in the name of videogames.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "List for removing movies and books from videogame storefronts", null, null, null },
                    { 1726, null, "This filter disables 'dodgy' sites My Way!", null, null, null, "https://github.com/callmenemo491/DodgySiteBlocker/", "https://github.com/callmenemo491/DodgySiteBlocker/issues", 2, "DodgySiteBlocker", null, null, null },
                    { 820, null, null, null, null, null, "https://github.com/uBlockOrigin/uAssets", "https://github.com/uBlockOrigin/uAssets/issues", 4, "uMatrix - Rulesets for English websites", null, null, null },
                    { 90, null, "These filters are experimental and may cause breakage. They are being evaluated/fine-tuned for inclusion in the default set of filters.", null, null, null, "https://github.com/uBlockOrigin/uAssets", "https://github.com/uBlockOrigin/uAssets/issues", 4, "uAssets Experimental", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 1563, "tr" },
                    { 2391, "ja" },
                    { 2259, "sk" },
                    { 2249, "ar" },
                    { 1528, "az" },
                    { 1528, "en" },
                    { 1962, "tr" },
                    { 1961, "tr" },
                    { 1929, "no" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 685, 88 },
                    { 820, 57 },
                    { 867, 38 },
                    { 1476, 119 },
                    { 1528, 46 },
                    { 1542, 7 },
                    { 1565, 22 },
                    { 1929, 22 },
                    { 304, 88 },
                    { 1966, 22 },
                    { 1997, 144 },
                    { 2016, 154 },
                    { 2042, 64 },
                    { 2249, 6 },
                    { 2259, 6 },
                    { 2391, 144 },
                    { 1839, 144 },
                    { 303, 88 },
                    { 90, 57 },
                    { 286, 88 },
                    { 270, 88 },
                    { 271, 88 },
                    { 287, 88 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 1542, 10 },
                    { 1476, 1 },
                    { 1481, 1 },
                    { 2259, 10 },
                    { 1528, 6 },
                    { 271, 28 },
                    { 1563, 1 },
                    { 1565, 3 },
                    { 2249, 3 },
                    { 1726, 3 },
                    { 138, 1 },
                    { 1839, 1 },
                    { 286, 2 },
                    { 2076, 3 },
                    { 270, 16 },
                    { 1929, 4 },
                    { 1936, 2 },
                    { 2042, 3 },
                    { 270, 4 },
                    { 1961, 3 },
                    { 1962, 9 },
                    { 1966, 3 },
                    { 2033, 1 },
                    { 1997, 4 },
                    { 1823, 9 },
                    { 2296, 1 },
                    { 2016, 2 },
                    { 716, 37 },
                    { 732, 3 },
                    { 2312, 2 },
                    { 685, 1 },
                    { 90, 4 },
                    { 820, 51 },
                    { 304, 2 },
                    { 2391, 4 },
                    { 287, 2 },
                    { 867, 1 },
                    { 303, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2033, 2 },
                    { 2076, 8 },
                    { 287, 6 },
                    { 1839, 19 },
                    { 90, 2 },
                    { 2016, 6 },
                    { 270, 14 },
                    { 685, 6 },
                    { 1929, 15 },
                    { 1966, 35 },
                    { 1936, 6 },
                    { 304, 3 },
                    { 1966, 11 },
                    { 1966, 9 },
                    { 1823, 6 },
                    { 1961, 2 },
                    { 138, 2 },
                    { 303, 23 },
                    { 1962, 6 },
                    { 303, 14 },
                    { 867, 35 },
                    { 867, 19 },
                    { 1726, 6 },
                    { 867, 4 },
                    { 867, 3 },
                    { 1476, 3 },
                    { 1476, 4 },
                    { 2259, 2 },
                    { 1481, 3 },
                    { 1481, 4 },
                    { 286, 14 },
                    { 2296, 2 },
                    { 271, 6 },
                    { 820, 3 },
                    { 716, 12 },
                    { 1997, 15 },
                    { 1528, 2 },
                    { 2249, 2 },
                    { 2312, 6 },
                    { 2391, 30 },
                    { 1563, 2 },
                    { 1542, 2 },
                    { 732, 9 },
                    { 1565, 30 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2399, 2259, (short)1, "https://easylist-downloads.adblockplus.org/easylistczechandslovak-minified.tpl" },
                    { 2112, 2016, (short)1, "https://raw.githubusercontent.com/blocklistproject/Lists/master/spam.txt" },
                    { 2183, 2076, (short)1, "https://easylist-downloads.adblockplus.org/easylist-cookie.tpl" },
                    { 136, 90, (short)3, "https://rawcdn.githack.com/uBlockOrigin/uAssets/master/filters/experimental.txt" },
                    { 2459, 2312, (short)1, "https://kriskintel.com/ktip_maze.txt" },
                    { 2389, 2249, (short)1, "https://hg.adblockplus.org/customfilterlists/raw-file/default/liste_ar-minified.txt" },
                    { 2441, 2296, (short)1, "https://raw.githubusercontent.com/BlackJack8/iOSAdblockList/master/iPv4Hosts.txt" },
                    { 134, 90, (short)1, "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/filters/experimental.txt" },
                    { 2136, 2042, (short)2, "https://repo.or.cz/Adblock-list-backups-Frellwits-filter-lists.git/blob_plain/refs/heads/master:/deviantJUNKfilter.txt" },
                    { 2135, 2042, (short)1, "https://raw.githubusercontent.com/lassekongo83/Frellwits-filter-lists/master/deviantJUNKfilter.txt" },
                    { 135, 90, (short)2, "https://gitcdn.xyz/repo/uBlockOrigin/uAssets/master/filters/experimental.txt" },
                    { 2126, 2033, (short)1, "https://block.energized.pro/assets/sources/filter/blockzilla.txt" },
                    { 421, 287, (short)2, "https://mirror.cedia.org.ec/malwaredomains/justdomains" },
                    { 1889, 1823, (short)1, "http://www.unsubscore.com/blacklist.txt" },
                    { 2094, 1997, (short)1, "https://raw.githubusercontent.com/Cybo1927/Hosts/master/Anti/Anti Third-Party HTTP" },
                    { 440, 303, (short)1, "https://mirror1.malwaredomains.com/files/url_shorteners.txt" },
                    { 441, 304, (short)1, "https://mirror1.malwaredomains.com/files/Skype-resolvers.txt" },
                    { 722, 685, (short)1, "https://mirror1.malwaredomains.com/files/domains.hosts" },
                    { 723, 685, (short)2, "https://mirror.cedia.org.ec/malwaredomains/domains.hosts" },
                    { 749, 716, (short)1, "https://raw.githubusercontent.com/lennylxx/ipv6-hosts/master/hosts" },
                    { 768, 732, (short)1, "https://raw.githubusercontent.com/dariusworks/superblock/master/cleanersitesAiO.txt" },
                    { 419, 286, (short)1, "https://mirror1.malwaredomains.com/files/freewebhosts.txt" },
                    { 853, 820, (short)1, "https://raw.githubusercontent.com/uBlockOrigin/uAssets/master/recipes/recipes_en.txt" },
                    { 916, 867, (short)1, "https://raw.githubusercontent.com/kowith337/PersonalFilterListCollection/master/hosts/static/hosts_facebook0_noregionsv.txt" },
                    { 917, 867, (short)2, "https://gitlab.com/kowith337/PersonalFilterListCollection/raw/master/hosts/static/hosts_facebook0_noregionsv.txt" },
                    { 1485, 1476, (short)1, "https://hblock.molinero.dev/hosts_android.zip" },
                    { 1490, 1481, (short)1, "https://raw.githubusercontent.com/jawz101/MobileAdTrackers/master/hosts" },
                    { 402, 271, (short)1, "https://easylist-downloads.adblockplus.org/malwaredomains_full.txt" },
                    { 1526, 1528, (short)1, "https://filters.adtidy.org/extension/chromium/filters/2_without_easylist.txt" },
                    { 1541, 1542, (short)1, "https://easylist-downloads.adblockplus.org/adwarefilters.tpl" },
                    { 1565, 1563, (short)1, "https://raw.githubusercontent.com/xorcan/hosts/master/xhosts.txt" },
                    { 1568, 1565, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/GamestoreMovieRemover.txt" },
                    { 219, 138, (short)2, "https://gitcdn.xyz/repo/FadeMind/hosts.extras/master/StreamingAds/hosts" },
                    { 2042, 1966, (short)2, "https://gitlab.com/DandelionSprout/adfilt/raw/master/PornHubPureTrailMixExperience.txt" },
                    { 2041, 1966, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/PornHubPureTrailMixExperience.txt" },
                    { 220, 138, (short)3, "https://gitcdn.link/repo/FadeMind/hosts.extras/master/StreamingAds/hosts" },
                    { 2035, 1962, (short)1, "https://raw.githubusercontent.com/xorcan/hosts/master/xips.txt" },
                    { 2034, 1961, (short)1, "https://raw.githubusercontent.com/xorcan/hosts/master/xelement.txt" },
                    { 218, 138, (short)1, "https://raw.githubusercontent.com/FadeMind/hosts.extras/master/StreamingAds/hosts" },
                    { 2007, 1936, (short)1, "https://lists.hashdd.com/hashdd/vxvault-urllist/hosts" },
                    { 1998, 1929, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianFanTranslations.txt" },
                    { 1906, 1839, (short)1, "https://raw.githubusercontent.com/Cybo1927/Hosts/master/Anti/Anti Verizon" },
                    { 401, 270, (short)1, "https://mirror1.malwaredomains.com/files/bulk_registrars.txt" },
                    { 420, 287, (short)1, "https://mirror1.malwaredomains.com/files/justdomains" },
                    { 1786, 1726, (short)1, "https://raw.githubusercontent.com/callmenemo491/DodgySiteBlocker/master/DodgySiteBlocker.txt" },
                    { 1569, 1565, (short)2, "https://gitlab.com/DandelionSprout/adfilt/raw/master/GamestoreMovieRemover.txt" },
                    { 1999, 1929, (short)2, "https://gitlab.com/DandelionSprout/adfilt/raw/master/NorwegianFanTranslations.txt" },
                    { 2569, 2391, (short)1, "https://raw.githubusercontent.com/Cybo1927/Hosts/master/Anti/Anti Nightcore" }
                });
        }
    }
}
