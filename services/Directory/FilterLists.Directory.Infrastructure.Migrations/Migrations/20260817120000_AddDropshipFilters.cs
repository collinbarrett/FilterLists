using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddDropshipFilters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2861, null, "An adblock filter list that removes sketchy Chinese dropship retailers (Temu, Shein, AliExpress, Wish, and a large constellation of associated networks) from search results, blocks their ad networks and trackers, and stops affiliate redirect chains — without blocking direct navigation to these sites.", null, null, null, "https://github.com/Lalaggi/dropship-filters", "https://github.com/Lalaggi/dropship-filters/issues", 8, "Dropship Filters", null, null, null });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 217, null, "Lalaggi", null, "https://github.com/Lalaggi" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[]
                {
                    42, "Blocks or hides dropshipping retailers and their storefronts", "dropshipping",
                    43, "Blocks trackers and other privacy-invasive resources from these retailers", "tracker",
                    44, "Blocks affiliate and redirect link chains", "affiliate",
                    45, "Targets Chinese-origin e-commerce and dropshipping retailers", "china"
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2861, 217 });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[]
                {
                    2861, (short)3,
                    2861, (short)4,
                    2861, (short)6,
                    2861, (short)1
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[]
                {
                    2861, 42,
                    2861, 43,
                    2861, 44,
                    2861, 45
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[] { 2861, 37 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[]
                {
                    2861, 3268, (short)1, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-full.txt",
                    2861, 3269, (short)2, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-ads.txt",
                    2861, 3270, (short)3, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-redirects.txt",
                    2861, 3271, (short)4, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-search.txt",
                    2861, 3272, (short)5, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-pihole.txt",
                    2861, 3273, (short)6, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-search-compat.txt",
                    2861, 3274, (short)7, "https://github.com/Lalaggi/dropship-filters/releases/latest/download/dropship_filters-full-compat.txt"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3268 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3269 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3270 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3271 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3272 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3273 });
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2861, 3274 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2861, 37 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2861, 45 });
            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2861, 44 });
            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2861, 43 });
            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2861, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2861, (short)1 });
            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2861, (short)6 });
            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2861, (short)4 });
            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2861, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2861, 217 });

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValues: new object[] { 42, 43, 44, 45 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2861);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 217);
        }
    }
}
