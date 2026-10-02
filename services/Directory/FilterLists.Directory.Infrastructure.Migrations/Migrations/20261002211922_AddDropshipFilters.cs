using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                values: new object[,]
                {
                    { 2867, null, "An adblock filter list that removes sketchy Chinese dropship retailers (Temu, Shein, AliExpress, Wish, and a large constellation of associated networks) from search results, blocks their ad networks and trackers, and stops affiliate redirect chains — without blocking direct navigation to these sites.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters", null, null, null },
                    { 2868, null, "The ad and tracker-blocking subset of Dropship Filters.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Ads)", null, null, null },
                    { 2869, null, "The affiliate and redirect-blocking subset of Dropship Filters.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Redirects)", null, null, null },
                    { 2870, null, "The search-result hiding subset of Dropship Filters.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Search)", null, null, null },
                    { 2871, null, "A DNS-safe bare-domain version of Dropship Filters for Pi-hole.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Pi-hole)", null, null, null },
                    { 2872, null, "An expanded maximum-compatibility version of the search subset of Dropship Filters.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Search Compat)", null, null, null },
                    { 2873, null, "An expanded maximum-compatibility version of Dropship Filters.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Full Compat)", null, null, null },
                    { 2874, null, "A 0.0.0.0 hosts-file version of the DNS-safe Dropship Filters list.", null, null, null, "https://gitlab.com/Lalaggi/dropship-filters", "https://gitlab.com/Lalaggi/dropship-filters/-/issues", 8, "Dropship Filters (Hosts)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 220, null, "Lalaggi", null, "https://github.com/Lalaggi" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 42, "Blocks or hides dropshipping retailers and their storefronts", "dropshipping" },
                    { 44, "Blocks affiliate and redirect link chains", "affiliate" },
                    { 45, "Targets Chinese-origin e-commerce and dropshipping retailers", "china" }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2867, (short)37 },
                    { 2868, (short)37 },
                    { 2869, (short)37 },
                    { 2870, (short)37 },
                    { 2871, (short)37 },
                    { 2872, (short)37 },
                    { 2873, (short)37 },
                    { 2874, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2867, 220 },
                    { 2868, 220 },
                    { 2869, 220 },
                    { 2870, 220 },
                    { 2871, 220 },
                    { 2872, 220 },
                    { 2873, 220 },
                    { 2874, 220 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2867, (short)3 },
                    { 2867, (short)4 },
                    { 2867, (short)6 },
                    { 2868, (short)3 },
                    { 2868, (short)4 },
                    { 2868, (short)6 },
                    { 2869, (short)3 },
                    { 2869, (short)4 },
                    { 2869, (short)6 },
                    { 2870, (short)3 },
                    { 2870, (short)4 },
                    { 2870, (short)6 },
                    { 2871, (short)2 },
                    { 2872, (short)3 },
                    { 2872, (short)4 },
                    { 2872, (short)6 },
                    { 2873, (short)3 },
                    { 2873, (short)4 },
                    { 2873, (short)6 },
                    { 2874, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2867, 3 },
                    { 2867, 42 },
                    { 2867, 44 },
                    { 2867, 45 },
                    { 2868, 3 },
                    { 2868, 42 },
                    { 2868, 45 },
                    { 2869, 42 },
                    { 2869, 44 },
                    { 2869, 45 },
                    { 2870, 42 },
                    { 2870, 45 },
                    { 2871, 3 },
                    { 2871, 42 },
                    { 2871, 44 },
                    { 2871, 45 },
                    { 2872, 42 },
                    { 2872, 45 },
                    { 2873, 3 },
                    { 2873, 42 },
                    { 2873, 44 },
                    { 2873, 45 },
                    { 2874, 3 },
                    { 2874, 42 },
                    { 2874, 44 },
                    { 2874, 45 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
                values: new object[,]
                {
                    { 2867, 3275, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-full.txt" },
                    { 2868, 3276, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-ads.txt" },
                    { 2869, 3277, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-redirects.txt" },
                    { 2870, 3278, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-search.txt" },
                    { 2871, 3279, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-pihole.txt" },
                    { 2872, 3280, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-search-compat.txt" },
                    { 2873, 3281, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-full-compat.txt" },
                    { 2874, 3282, (short)1, (short)1, "https://gitlab.com/Lalaggi/dropship-filters/-/raw/lists/dropship_filters-hosts.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2867, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2868, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2869, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2870, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2871, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2872, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2873, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2874, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2867, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2868, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2869, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2870, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2871, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2872, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2873, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2874, 220 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2867, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2867, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2867, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2868, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2868, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2868, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2869, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2869, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2869, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2870, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2870, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2870, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2871, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2872, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2872, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2872, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2873, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2873, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2873, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2874, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2867, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2867, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2867, 44 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2867, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2868, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2868, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2868, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2869, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2869, 44 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2869, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2870, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2870, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2871, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2871, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2871, 44 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2871, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2872, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2872, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2873, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2873, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2873, 44 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2873, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2874, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2874, 42 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2874, 44 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2874, 45 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2867, 3275 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2868, 3276 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2869, 3277 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2870, 3278 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2871, 3279 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2872, 3280 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2873, 3281 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2874, 3282 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2867);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2868);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2869);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2870);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2871);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2872);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2873);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2874);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 45);
        }
    }
}
