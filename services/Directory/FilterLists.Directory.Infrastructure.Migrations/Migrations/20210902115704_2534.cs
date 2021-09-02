using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2534 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1483, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1857, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1858, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1859, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1860, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1861, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1862, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1863, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2095, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2282, "ja" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1483, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1483, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1857, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1858, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1859, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1860, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1861, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1862, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1863, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2095, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2282, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1483, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1483, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1483, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1857, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1858, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1859, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1860, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1861, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1862, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1863, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2095, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2282, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2282, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2282, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2282);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 1, null, "A filter list that blocks mobile advertisements and trackers on Japanese properties", null, null, null, "https://280blocker.net/", null, 1, "280blocker for japanese mobile site", null, null, "https://docs.google.com/forms/d/e/1FAIpQLScNeZhFrFZt9GhIVGdThGz7oyepcNRKuOi5PJDnsC-awxTeOQ/viewform" },
                    { 1483, null, "A filter list that blocks mobile advertisements and trackers on Japanese properties", null, null, null, "https://280blocker.net/", null, 1, "280blocker adblock domain lists", null, null, "https://docs.google.com/forms/d/e/1FAIpQLScNeZhFrFZt9GhIVGdThGz7oyepcNRKuOi5PJDnsC-awxTeOQ/viewform" },
                    { 1857, null, "This is a filter to complement 280blocker by finding advertisements that are not blocked by 280blocker.", null, null, null, "https://github.com/nanj-adguard2/nanj-kakuchou-filter", null, 20, "Nanj Kakuchou Filter - Supplement Rules", null, null, null },
                    { 1858, null, "DNS rule filters to strengthen ad blocking.", null, null, null, "https://github.com/nanj-adguard2/nanj-kakuchou-filter", null, 20, "Nanj Kakuchou Filter - DNS Rules", null, null, null },
                    { 1859, null, "This is a filter that eradicates what 280blocker will not support in the future.", null, null, null, "https://github.com/nanj-adguard2/nanj-kakuchou-filter", null, 20, "Nanj Kakuchou Filter - Paranoid Rules", null, null, null },
                    { 1860, null, "This is a filter to fix bugs in AdGuard for Android when using Japanese websites / Japanese apps / 280blocker.", null, null, null, "https://github.com/nanj-adguard2/nanj-kaishuu-filter", null, 20, "Nanj Kaishuu Filter", null, null, null },
                    { 1861, null, "This is a filter to fix bugs in AdGuard for Android when using Japanese websites / Japanese apps / 280blocker.", null, null, null, "https://github.com/nanj-adguard2/nanj-kaishuu-filter", null, 20, "Nanj Kaishuu DNS Filter", null, null, null },
                    { 1862, null, "This is a filter to fix bugs in AdGuard for Android when using Japanese websites / Japanese apps / 280blocker.", null, null, null, "https://github.com/nanj-adguard2/nanj-kaishuu-filter", null, 1, "280blocker + Nanj Kakuchou", null, null, null },
                    { 1863, null, "This is a filter to fix bugs in AdGuard for Android when using Japanese websites / Japanese apps / 280blocker.", null, null, null, "https://github.com/nanj-adguard2/nanj-kaishuu-filter", null, 1, "280blocker + Nanj Kakuchou - Supplement Rules", null, null, null },
                    { 2095, null, "Enhance anti-scam capability of 280blocker adblock filter by utilizing advanced capability of AdGuard/uBlock Origin.", null, null, null, "https://github.com/Yuki2718/adblock", "https://github.com/Yuki2718/adblock/issues", 28, "Anti-scam enhancer for 280blocker adblock filter", null, null, null },
                    { 2282, null, "A filter list that blocks mobile advertisements and trackers on Japanese properties", null, null, null, "https://280blocker.net/", null, 1, "280blocker adblock domain lists (AdGuard)", null, null, "https://docs.google.com/forms/d/e/1FAIpQLScNeZhFrFZt9GhIVGdThGz7oyepcNRKuOi5PJDnsC-awxTeOQ/viewform" }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 1, "ja" },
                    { 2282, "ja" },
                    { 2095, "ja" },
                    { 1863, "ja" },
                    { 1862, "ja" },
                    { 1861, "ja" },
                    { 1859, "ja" },
                    { 1858, "ja" },
                    { 1857, "ja" },
                    { 1860, "ja" },
                    { 1483, "ja" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1483, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 1861, 3 },
                    { 1860, 6 },
                    { 1863, 3 },
                    { 1, 3 },
                    { 1859, 3 },
                    { 1862, 3 },
                    { 2095, 4 },
                    { 1858, 47 },
                    { 2282, 47 },
                    { 1857, 3 },
                    { 1483, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 1863, 2 },
                    { 2282, 3 },
                    { 2282, 4 },
                    { 1, 2 },
                    { 1862, 2 },
                    { 2095, 7 },
                    { 1, 3 },
                    { 1483, 4 },
                    { 1859, 9 },
                    { 1483, 3 },
                    { 1483, 10 },
                    { 1857, 2 },
                    { 1860, 10 },
                    { 2282, 10 },
                    { 1861, 10 },
                    { 1858, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1491, 1483, (short)1, "https://280blocker.net/files/280blocker_domain.txt" },
                    { 1925, 1857, (short)1, "https://raw.githubusercontent.com/nanj-adguard2/nanj-kakuchou-filter/master/supplement-rules.txt" },
                    { 2202, 2095, (short)1, "https://raw.githubusercontent.com/Yuki2718/adblock/master/japanese/280-patch.txt" },
                    { 1929, 1861, (short)1, "https://raw.githubusercontent.com/nanj-adguard2/nanj-kaishuu-filter/master/nanj-kaishuu-dns-filter.txt" },
                    { 1931, 1863, (short)1, "https://280blocker.net/files/280blocker_adblock_nanj_supp.txt" },
                    { 1927, 1859, (short)1, "https://raw.githubusercontent.com/nanj-adguard2/nanj-kakuchou-filter/master/paranoid-rules.txt" },
                    { 1930, 1862, (short)1, "https://280blocker.net/files/280blocker_adblock_nanj.txt" },
                    { 1928, 1860, (short)1, "https://raw.githubusercontent.com/nanj-adguard2/nanj-kaishuu-filter/master/nanj-kaishuu-filter.txt" },
                    { 1, 1, (short)1, "https://280blocker.net/files/280blocker_adblock.txt" },
                    { 1926, 1858, (short)1, "https://raw.githubusercontent.com/nanj-adguard2/nanj-kakuchou-filter/master/DNS-rules.txt" },
                    { 2425, 2282, (short)1, "https://280blocker.net/files/280blocker_domain_ag.txt" }
                });
        }
    }
}
