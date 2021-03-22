using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2271 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2434, 55 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2434, 6 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2647,
                column: "Url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Alternate versions Anti-Malware List/AntiMalwareDomains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2648,
                column: "Url",
                value: "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Alternate versions Anti-Malware List/AntiMalwareDomains.txt");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 12,
                column: "IssuesUrl",
                value: "https://github.com/easylist/listefr/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 14,
                column: "IssuesUrl",
                value: "https://github.com/easylist/listear/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 131,
                column: "IssuesUrl",
                value: "https://github.com/easylist/ruadlist/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 246,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistspanish/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 289,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistitaly/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 295,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistdutch/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 300,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistchina");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 805,
                column: "IssuesUrl",
                value: "https://github.com/easylist/ruadlist/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 806,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistportuguese/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1529,
                column: "IssuesUrl",
                value: "https://github.com/easylist/KoreanList/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1543,
                column: "IssuesUrl",
                value: "https://github.com/easylist/KoreanList/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1544,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylistportuguese/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1547,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2470, null, "A filter to scrub sites and services related to Rupert Murdoch and News Corp from the web", null, null, null, "https://github.com/twcau/AdblockRules/", "https://github.com/twcau/AdblockRules/issues", 28, "MurdochList", null, null, null },
                    { 2468, null, "An adblocker ruleset for Taiwan.", "https://p.ecpay.com.tw/B32C0", null, "https://t.me/adguard_tw", "https://github.com/FutaGuard/FutaFilter", "https://github.com/FutaGuard/FutaFilter/issues", null, "FutaHosts Nofarm", null, null, null },
                    { 2467, null, "An adblocker ruleset for Taiwan.", "https://p.ecpay.com.tw/B32C0", null, "https://t.me/adguard_tw", "https://github.com/FutaGuard/FutaFilter", "https://github.com/FutaGuard/FutaFilter/issues", null, "FutaHosts", null, null, null },
                    { 2466, null, "An adblocker ruleset for Taiwan.", "https://p.ecpay.com.tw/B32C0", null, "https://t.me/adguard_tw", "https://github.com/FutaGuard/FutaFilter", "https://github.com/FutaGuard/FutaFilter/issues", null, "FutaFilter", null, null, null },
                    { 2465, null, "Blocks scam sites and remove them from search recommendations to increase the user's security.", null, null, null, "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/", "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/issues", null, "Anti-Scam Internet", null, null, null },
                    { 2464, null, "Eliminates trash content from old reddit, while not infringing the view of the user, so that the experience is more enjoyable.", null, null, null, "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/", "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/issues", null, "Anti-Trash Old Reddit", null, null, null },
                    { 2463, null, "Eliminates trash content from new reddit, while not infringing the view of the user, so that the experience is more enjoyable. ", null, null, null, "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/", "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/issues", null, "Anti-Trash New Reddit", null, null, null },
                    { 2462, null, "Eliminates trashy videos, channels, and features from the user's feeds, so that the experience is more enjoyable.", null, null, null, "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/", "https://github.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/issues", null, "Anti-Trash YouTube", null, null, null },
                    { 2461, null, "The list of trackers that are often disguised using CNAME. This list is supposed to be used only by Software capable of scanning CNAME records.", null, null, null, "https://github.com/AdguardTeam/cname-trackers", "https://github.com/AdguardTeam/cname-trackers/issues", 2, "AdGuard CNAME original trackers list", null, null, null },
                    { 2460, null, "The list of trackers that disguise the real trackers by using CNAME records.", null, null, null, "https://github.com/AdguardTeam/cname-trackers", "https://github.com/AdguardTeam/cname-trackers/issues", 2, "AdGuard CNAME disguised trackers list (Domains)", null, null, null },
                    { 2459, null, "The list of trackers that disguise the real trackers by using CNAME records.", null, null, null, "https://github.com/AdguardTeam/cname-trackers", "https://github.com/AdguardTeam/cname-trackers/issues", 2, "AdGuard CNAME disguised trackers list", null, null, null },
                    { 2458, null, "The default uBlock Origin lists block most ads and tracking. Web Annoyances Ultralist blocks most floating items. This list is for the few ads and annoyances that these two lists don't cover. Our goal is to block everything annoying. Anything that disrupts the normal reading flow of the page. Anything that tries to influence the reader to do something unnecessary.", null, null, null, "https://github.com/RedDragonWebDesign/block-everything", "https://github.com/RedDragonWebDesign/block-everything/issues", null, "Block Everything!", null, null, null },
                    { 2457, null, null, null, null, null, "https://github.com/catsxp/adblock-lists", "https://github.com/catsxp/adblock-lists/issues", null, "catsxp Unbreak", null, null, null },
                    { 2456, null, "The easiest way to get rid of annoying online consultants is to block access to them at the lowest level, i.e. via a hosts file. This keeps the browser free of extensions and ensures reliable blocking on all fronts.", null, "pafnuty10@gmail.com", null, "https://github.com/pafnuty/onlineConsultantBlocker", "https://github.com/pafnuty/onlineConsultantBlocker/issues", 2, "Online Consultant Blocker", null, null, null },
                    { 2469, null, null, "https://p.ecpay.com.tw/B32C0", null, "https://t.me/adguard_tw", "https://github.com/FutaGuard/FutaFilter", "https://github.com/FutaGuard/FutaFilter/issues", null, "FutaFilter removeparam", null, null, null },
                    { 2455, null, "After 1½ years of trial setups and tinkering until March 2021, I now offer my DNS server to be used by the public! That being said, there are a considerable number of drawbacks with it that means that it should NOT be used in setups where uptime, privacy, or impartiality is important; read the homepage Readme before using it.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt/blob/master/Dandelion Sprout's Official DNS Server/README.md", "https://github.com/DandelionSprout/adfilt/issues", 35, "Dandelion Sprout's Official DNS Server", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 2456, "ru" },
                    { 2466, "zh" },
                    { 2470, "en" },
                    { 2467, "zh" },
                    { 2468, "zh" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2459, 46 },
                    { 2460, 46 },
                    { 2461, 46 },
                    { 2455, 22 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2461, 47 },
                    { 2455, 22 },
                    { 2460, 2 },
                    { 2458, 4 },
                    { 2465, 2 },
                    { 2465, 4 },
                    { 2462, 4 },
                    { 2468, 47 },
                    { 2457, 4 },
                    { 2466, 6 },
                    { 2456, 28 },
                    { 2459, 47 },
                    { 2463, 4 },
                    { 2467, 47 },
                    { 2469, 6 },
                    { 2470, 47 },
                    { 2464, 4 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2463, 9 },
                    { 2463, 30 },
                    { 2462, 35 },
                    { 2465, 7 },
                    { 2464, 9 },
                    { 2464, 30 },
                    { 2464, 35 },
                    { 2466, 2 },
                    { 2467, 2 },
                    { 2468, 2 },
                    { 2469, 3 },
                    { 2470, 19 },
                    { 2463, 35 },
                    { 2462, 30 },
                    { 2462, 11 },
                    { 2462, 9 },
                    { 2455, 30 },
                    { 2470, 21 },
                    { 2456, 29 },
                    { 2455, 25 },
                    { 2455, 22 },
                    { 2457, 5 },
                    { 2457, 10 },
                    { 2455, 34 },
                    { 2458, 9 },
                    { 2455, 32 },
                    { 2455, 15 },
                    { 2459, 3 },
                    { 2455, 8 },
                    { 2460, 3 },
                    { 2455, 7 },
                    { 2461, 3 },
                    { 2455, 6 },
                    { 2455, 2 },
                    { 2458, 40 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2675, 2468, (short)1, "https://filter.futa.gg/nofarm_hosts.txt" },
                    { 2677, 2469, (short)1, "https://raw.githubusercontent.com/FutaGuard/FutaFilter/master/removeparam.txt" },
                    { 2674, 2467, (short)2, "https://filter.futa.app/hosts.txt" },
                    { 2673, 2467, (short)1, "https://filter.futa.gg/hosts.txt" },
                    { 2676, 2468, (short)2, "https://filter.futa.app/nofarm_hosts.txt" },
                    { 2660, 2455, (short)2, "tls://dandelionsprout.asuscomm.com:853/" },
                    { 2672, 2466, (short)2, "https://filter.futa.app/filter.txt" },
                    { 2671, 2466, (short)1, "https://filter.futa.gg/filter.txt" },
                    { 2661, 2456, (short)1, "https://raw.githubusercontent.com/pafnuty/onlineConsultantBlocker/master/online-consultant.txt" },
                    { 2670, 2465, (short)1, "https://raw.githubusercontent.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/master/anti_scam_internet.txt" },
                    { 2662, 2457, (short)1, "https://raw.githubusercontent.com/catsxp/adblock-lists/master/catsxp-unbreak.txt" },
                    { 2669, 2464, (short)1, "https://raw.githubusercontent.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/master/anti_trash_old_reddit.txt" },
                    { 2663, 2458, (short)1, "https://raw.githubusercontent.com/RedDragonWebDesign/block-everything/master/block-everything.txt" },
                    { 2668, 2463, (short)1, "https://raw.githubusercontent.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/master/anti_trash_new_reddit.txt" },
                    { 2664, 2459, (short)1, "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_disguised_trackers.txt" },
                    { 2665, 2460, (short)1, "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_disguised_trackers_justdomains.txt" },
                    { 2667, 2462, (short)1, "https://raw.githubusercontent.com/WhyIsEvery4thYearAlwaysBad/anti-cancer-filter-lists/master/anti_trash_youtube.txt" },
                    { 2666, 2461, (short)1, "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_original_trackers.txt" },
                    { 2659, 2455, (short)1, "https://dandelionsprout.asuscomm.com:2501/dns-query" },
                    { 2678, 2470, (short)1, "https://raw.githubusercontent.com/twcau/AdblockRules/master/MurdochList" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2456, "ru" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2466, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2467, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2468, "zh" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2470, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2455, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2459, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2460, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2461, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2434, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2455, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2456, 28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2457, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2458, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2459, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2460, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2461, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2462, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2463, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2464, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2465, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2465, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2466, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2467, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2468, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2469, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2470, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 8 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 32 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2455, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2456, 29 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2457, 5 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2457, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2458, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2458, 40 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2459, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2460, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2461, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2462, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2462, 11 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2462, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2462, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2463, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2463, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2463, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2464, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2464, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2464, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2465, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2466, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2467, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2468, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2469, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2470, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2470, 21 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2659);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2661);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2662);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2664);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2668);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2669);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2672);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2470);

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2434, 55 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2647,
                column: "Url",
                value: "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList alternate versions/DandelionSproutsNorskeFiltreDomains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2648,
                column: "Url",
                value: "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/NorwegianExperimentalList alternate versions/DandelionSproutsNorskeFiltreDomains.txt");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 12,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 14,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 131,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 246,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 289,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 295,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 300,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 805,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 806,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1529,
                column: "IssuesUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1543,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylist/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1544,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylist/issues");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1547,
                column: "IssuesUrl",
                value: "https://github.com/easylist/easylist/issues");
        }
    }
}
