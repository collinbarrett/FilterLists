using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2608 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1804, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1805, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1947, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 514, 77 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1125, 109 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2221, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2222, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2223, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2224, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2225, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2226, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2227, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2228, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2229, 149 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 514, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 838, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1125, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1662, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1663, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1802, 29 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1804, 29 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1805, 29 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1894, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1895, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1923, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1924, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1925, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1947, 31 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2221, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2222, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2223, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2224, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2225, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2226, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2227, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2228, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2229, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 514, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 514, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 838, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1125, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1512, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1662, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1663, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1802, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1804, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1805, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1805, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1894, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1894, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1894, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1895, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1895, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1895, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1923, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1924, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1925, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1947, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2221, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2222, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2223, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2224, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2225, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2226, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2227, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2228, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2229, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://hg.adblockplus.org/facebookfilters/file/tip/message_seen_remover_for_facebook.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 151,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 153,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 253,
                column: "Url",
                value: "https://hg.adblockplus.org/adwarefilters/raw-file/tip/adwarefilters.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 351,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 354,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 358,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 360,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 417,
                column: "Url",
                value: "http://malwaredomains.lehigh.edu/files/dynamic_dns.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 422,
                column: "Url",
                value: "http://malwaredomains.lehigh.edu/files/immortal_domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 444,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 610,
                column: "Url",
                value: "https://raw.githubusercontent.com/StevenBlack/hosts/master/extensions/porn/clefspeare13/hosts");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1776,
                column: "Url",
                value: "https://raw.githubusercontent.com/XionKzn/PiHole-Lists/master/PiHole/PiHole_HOSTS_Spyware_HOSTS.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1778,
                column: "Url",
                value: "https://raw.githubusercontent.com/XionKzn/PiHole-Lists/master/PiHole/Blocklist_HOSTS.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1874,
                column: "Url",
                value: "https://danger.rulez.sk/projects/bruteforceblocker/blist.php");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1933,
                column: "Url",
                value: "https://raw.githubusercontent.com/zonprox/adblock/master/abpadv.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2093,
                column: "Url",
                value: "https://raw.githubusercontent.com/Cybo1927/Hosts/master/Extensions/Anti Obfuscation");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2434,
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID-Adult/master/AdBlockID_Adult.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2458,
                column: "Url",
                value: "https://kriskintel.com/feeds/ktip_covid_domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2460,
                column: "Url",
                value: "https://kriskintel.com/feeds/ktip_malicious_domains.txt");

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2755, 2434, (short)3, "https://iam-py-test.github.io/mirrors/LegitimateURLShortener.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2755);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://easylist-downloads.adblockplus.org/message_seen_remover_for_facebook.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 151,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 153,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 253,
                column: "Url",
                value: "https://easylist-downloads.adblockplus.org/adwarefilters.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 351,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 354,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 358,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 360,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 417,
                column: "Url",
                value: "https://mirror1.malwaredomains.com/files/dynamic_dns.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 422,
                column: "Url",
                value: "https://mirror1.malwaredomains.com/files/immortal_domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 444,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 610,
                column: "Url",
                value: "https://raw.githubusercontent.com/Clefspeare13/pornhosts/master/0.0.0.0/hosts");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1776,
                column: "Url",
                value: "https://raw.githubusercontent.com/XionKzn/PiHole-Lists/master/PiHole/PiHole_HOSTS_Spyware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1778,
                column: "Url",
                value: "https://raw.githubusercontent.com/XionKzn/PiHole-Lists/master/PiHole/Blocklist.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1874,
                column: "Url",
                value: "http://danger.rulez.sk/projects/bruteforceblocker/blist.php");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1933,
                column: "Url",
                value: "https://raw.githubusercontent.com/zonprox/adblock/master/abpvnplus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2093,
                column: "Url",
                value: "https://raw.githubusercontent.com/Cybo1927/Hosts/master/Anti/Anti g00");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2434,
                column: "Url",
                value: "https://raw.githubusercontent.com/realodix/AdBlockID/master/output/adblockid-plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2458,
                column: "Url",
                value: "https://kriskintel.com/ktip_corona.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2460,
                column: "Url",
                value: "https://kriskintel.com/feeds/ktip_domain_blacklist.txt");

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 443, 306, (short)1, "https://easylist-downloads.adblockplus.org/yt_annoyances_suggestions.txt" },
                    { 423, 288, (short)2, "https://mirror.cedia.org.ec/malwaredomains/immortal_domains.txt" },
                    { 418, 285, (short)2, "https://mirror.cedia.org.ec/malwaredomains/dynamic_dns.txt" },
                    { 359, 236, (short)1, "https://easylist-downloads.adblockplus.org/fb_annoyances_full.txt" },
                    { 357, 235, (short)1, "https://easylist-downloads.adblockplus.org/fb_annoyances_newsfeed.txt" },
                    { 353, 233, (short)1, "https://easylist-downloads.adblockplus.org/fb_annoyances_sidebar.txt" },
                    { 350, 229, (short)1, "https://easylist-downloads.adblockplus.org/yt_annoyances_comments.txt" },
                    { 150, 97, (short)1, "https://easylist-downloads.adblockplus.org/yt_annoyances_full.txt" },
                    { 152, 98, (short)1, "https://easylist-downloads.adblockplus.org/yt_annoyances_other.txt" }
                });

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 838, null, "VBlocker is made by a normal person that surfs the web to see all of the ads that should be blocked and added to VBlocker.", null, null, null, "https://github.com/SG-Nebula/vblocker_adblockplus-filterlist", "https://github.com/SG-Nebula/vblocker_adblockplus-filterlist/issues", 7, "VBlocker", null, null, null },
                    { 1125, null, null, null, null, null, "https://github.com/deathbybandaid/piholeparser", "https://github.com/deathbybandaid/piholeparser/issues", 14, "Bad JAV Sites (Domains)", null, null, null },
                    { 1512, null, "This is a community list with a blacklist of IP addresses.", null, null, null, "https://www.badips.com/", "https://www.badips.com/documentation#3", 2, "BadIPs", null, null, null },
                    { 1662, null, "Blocks annoyances on web pages including cookie notices, modals and other useless elements", null, null, null, "https://github.com/Strappazzon/filterlists", "https://github.com/Strappazzon/filterlists/issues", 2, "Strappazzon's Annoyances filter list", null, null, null },
                    { 1663, null, "Fixes what my current subscriptions broke", null, null, null, "https://github.com/Strappazzon/filterlists", "https://github.com/Strappazzon/filterlists/issues", 2, "Strappazzon's Unbreak", null, null, null },
                    { 1802, null, null, null, null, null, "https://github.com/HParis/SSEncrypt/", "https://github.com/HParis/SSEncrypt/issues", 5, "SSEncrypt Adblock", null, null, null },
                    { 1804, null, null, null, null, null, "https://github.com/ConnersHua/Profiles/tree/master", "https://github.com/ConnersHua/Profiles/tree/master/issues", 2, "ConnersHua Advertising Ruleset", null, null, null },
                    { 1805, null, null, null, null, null, "https://github.com/ConnersHua/Profiles/tree/master", "https://github.com/ConnersHua/Profiles/tree/master/issues", 2, "ConnersHua Pro Ruleset", null, null, null },
                    { 1894, null, "This is the \"SAFE LIST\" tested to not break legitimate functionality for commonly used software", null, null, null, "https://github.com/dex4k/dex4kblocklist", "https://github.com/dex4k/dex4kblocklist/issues", 5, "dex4k Blocklist", null, null, null },
                    { 1895, null, "This is a secondary blocklist created as, although I believe the blocking to be legitimate, blocking these domains can break popular apps", null, null, null, "https://github.com/dex4k/dex4kblocklist", "https://github.com/dex4k/dex4kblocklist/issues", 5, "dex4k Blocklist Extras", null, null, null },
                    { 1923, null, null, null, null, null, "https://github.com/chimbori/lite-apps", "https://github.com/chimbori/lite-apps/issues", 5, "Lite App Manifests - Coin Miners", null, null, null },
                    { 1924, null, null, null, null, null, "https://github.com/chimbori/lite-apps", "https://github.com/chimbori/lite-apps/issues", 5, "Lite App Manifests - Paid Content Links", null, null, null },
                    { 1947, null, "Personal rules for URLRedirector.", null, null, null, "https://github.com/ivysrono/URLRedirectorRules/", null, 5, "Ivysrono's URLRedirector Rules", null, null, null },
                    { 2221, null, "Includes a list of rules to prevent ad and tracking servers from compromising your privacy or bypassing Adguard Adblocker Extension.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "AdGuard Adblocker Extension Bypass Mitigation List", null, null, null },
                    { 2222, null, "Includes a list of rules to prevent ad and tracking servers from compromising your privacy or bypassing Adguard software for iOS, Android, and Windows.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "AdGuard for iOS, Android, and Windows Bypass Mitigation List", null, null, null },
                    { 2223, null, "Includes a list of rules to prevent ad and tracking servers from compromising your privacy or bypassing uBlock Origin or Nano Adblocker.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "uBlock Origin Bypass Mitigation List", null, null, null },
                    { 2224, null, "Behind-the-scene network requests are network requests which uBlock or uMatrix cannot associate with a specific tab in your browser. These can be abused by extensions in your web browser or made by web pages using navigator.sendBeacon(), hyperlink auditing, etc. ", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Behind-the-Scene Mitigation for uBlock Origin", null, null, null },
                    { 2225, null, "Behind-the-scene network requests are network requests which uBlock or uMatrix cannot associate with a specific tab in your browser. These can be abused by extensions in your web browser or made by web pages using navigator.sendBeacon(), hyperlink auditing, etc. Block CSP reports and pings in uMatrix.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Behind-the-Scene and Bypass Mitigation for uMatrix", null, null, null },
                    { 2226, null, "Block dangerous Android file extensions from HTTP-only traffic to increase security against potential exploits, download cradles, drive-by-download attacks, and malicious code. Intended for Adguard.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Android File Types Firewall HTTP-Only for Adguard", null, null, null },
                    { 2227, null, "Block dangerous Android file extensions from HTTP-only traffic to increase security against potential exploits, download cradles, drive-by-download attacks, and malicious code. Intended for uBlock Origin or Nano Defender.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Android File Types Firewall HTTP-Only for uBlock Origin", null, null, null },
                    { 2228, null, "Block dangerous Windows file extensions from HTTP-only traffic to increase security against potential exploits, download cradles, drive-by-download attacks, and malicious code. Intended for Adguard.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Windows Files Types Firewall HTTP-Only for Adguard", null, null, null },
                    { 2229, null, "Block dangerous Windows file extensions from HTTP-Only traffic to increase security against potential exploits, download cradles, drive-by-download attacks, and malicious code. Intended for uBlock Origin or Nano Defender.", null, null, null, "https://github.com/InnoScorpio/Public_Adblock_Filters", "https://github.com/InnoScorpio/Public_Adblock_Filters/issues", 11, "Windows File Types Firewall HTTP-Only for uBlock Origin", null, null, null },
                    { 1925, null, null, null, null, null, "https://github.com/chimbori/lite-apps", "https://github.com/chimbori/lite-apps/issues", 5, "Lite App Manifests - User Suggested Adware and Malware", null, null, null },
                    { 514, null, "A filter list that blocks ads, trackers, and more.", null, null, null, "https://github.com/SkeletalDemise/Skeletal-Blocker", "https://github.com/SkeletalDemise/Skeletal-Blocker/issues", 4, "Skeletal Blocker", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 1804, "zh" },
                    { 1805, "zh" },
                    { 1947, "zh" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2221, 149 },
                    { 2228, 149 },
                    { 2222, 149 },
                    { 2226, 149 },
                    { 2227, 149 },
                    { 2223, 149 },
                    { 2229, 149 },
                    { 2225, 149 },
                    { 2224, 149 },
                    { 1125, 109 },
                    { 514, 77 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 1895, 2 },
                    { 2221, 6 },
                    { 2224, 7 },
                    { 1947, 31 },
                    { 1894, 2 },
                    { 2227, 4 },
                    { 2226, 6 },
                    { 1805, 29 },
                    { 1925, 2 },
                    { 1923, 2 },
                    { 1924, 2 },
                    { 2225, 7 },
                    { 514, 4 },
                    { 1802, 29 },
                    { 1663, 4 },
                    { 2228, 6 },
                    { 2222, 6 },
                    { 1662, 4 },
                    { 2229, 4 },
                    { 1804, 29 },
                    { 2223, 4 },
                    { 1125, 2 },
                    { 838, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2226, 7 },
                    { 1925, 2 },
                    { 1924, 2 },
                    { 2222, 3 },
                    { 1947, 12 },
                    { 2225, 3 },
                    { 2223, 3 },
                    { 2221, 3 },
                    { 1894, 3 },
                    { 1923, 1 },
                    { 514, 2 },
                    { 514, 3 },
                    { 838, 2 },
                    { 1125, 2 },
                    { 1512, 3 },
                    { 2228, 7 },
                    { 1662, 9 },
                    { 1663, 10 },
                    { 1802, 2 },
                    { 2229, 7 },
                    { 2224, 3 },
                    { 2227, 7 },
                    { 1805, 2 },
                    { 1805, 12 },
                    { 1894, 2 },
                    { 1894, 6 },
                    { 1895, 2 },
                    { 1895, 3 },
                    { 1895, 6 },
                    { 1804, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2368, 2228, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/File_Types_Firewall/Windows/Adguard/AG_WIN-HTTP_Only.txt" },
                    { 2366, 2226, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/File_Types_Firewall/Android/Adguard/AG_AND-HTTP_Only.txt" },
                    { 2367, 2227, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/File_Types_Firewall/Android/uBlock Origin/uBO_AND-HTTP-Only.txt" },
                    { 1992, 1923, (short)1, "https://raw.githubusercontent.com/chimbori/lite-apps/master/src/blocklists/Coin Miners/UserSuggested.txt" },
                    { 2363, 2223, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/Enforcement/uBlock Origin/Attribute Tracking %26 Bypass_Mitigation.txt" },
                    { 627, 514, (short)1, "https://raw.githubusercontent.com/SkeletalDemise/Skeletal-Blocker/master/Skeletal Blocker List" },
                    { 871, 838, (short)1, "https://raw.githubusercontent.com/SG-Nebula/vblocker_adblockplus-filterlist/master/vblocker" },
                    { 1172, 1125, (short)1, "https://raw.githubusercontent.com/deathbybandaid/piholeparser/master/Subscribable-Lists/ParsedBlacklists/Bad-JAV-Sites.txt" },
                    { 1517, 1512, (short)1, "https://www.badips.com/info" },
                    { 1694, 1662, (short)1, "https://raw.githubusercontent.com/Strappazzon/filterlists/master/Filterlists/Annoyances.txt" },
                    { 1695, 1663, (short)1, "https://raw.githubusercontent.com/Strappazzon/filterlists/master/Filterlists/Unbreak.txt" },
                    { 1869, 1802, (short)1, "https://raw.githubusercontent.com/HParis/SSEncrypt/master/full-reject.list" },
                    { 2364, 2224, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/Enforcement/uBlock Origin/Behind-The-Scene_Mitigation.txt" },
                    { 1871, 1804, (short)1, "https://raw.githubusercontent.com/ConnersHua/Profiles/master/Surge/Ruleset/Advertising.list" },
                    { 1963, 1894, (short)1, "https://raw.githubusercontent.com/dex4k/dex4kblocklist/master/dex4kblocklist.txt" },
                    { 1964, 1895, (short)1, "https://raw.githubusercontent.com/dex4k/dex4kblocklist/master/dex4kblocklistextras.txt" },
                    { 1993, 1924, (short)1, "https://raw.githubusercontent.com/chimbori/lite-apps/master/src/blocklists/Adware and Malware/PaidContentLinks.txt" },
                    { 1994, 1925, (short)1, "https://raw.githubusercontent.com/chimbori/lite-apps/master/src/blocklists/Adware and Malware/UserSuggested.txt" },
                    { 2018, 1947, (short)1, "https://raw.githubusercontent.com/ivysrono/URLRedirectorRules/master/Directly.json" },
                    { 2361, 2221, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/Enforcement/Adguard/Adblocker_Extension_Bypass_Mitigation.txt" },
                    { 2362, 2222, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/Enforcement/Adguard/iOS_AND_WIN_Bypass_Mitigation.txt" },
                    { 1872, 1805, (short)1, "https://raw.githubusercontent.com/ConnersHua/Profiles/master/Shadow/Pro.conf" },
                    { 2369, 2229, (short)1, "https://raw.githubusercontent.com/InnoScorpio/Public_Adblock_Filters/master/File_Types_Firewall/Windows/uBlock Origin/uBO_WIN-HTTP-Only.txt" }
                });
        }
    }
}
