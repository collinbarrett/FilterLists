using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2538 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2150, 3 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2150, 10 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[] { 2750, 301, (short)4, "https://downloads.vivaldi.com/easylist/easylist-current.txt" });

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2522, null, null, null, null, null, "https://git.bubblev.org/bubblev/bubble-filter-lists/", null, null, "Bubble Filter Lists - Ads and Trackers", null, null, null },
                    { 2523, null, null, null, null, null, "https://git.bubblev.org/bubblev/bubble-filter-lists/", null, null, "Bubble Filter Lists - US News", null, null, null },
                    { 2524, null, "Block lists for the Minecraft community.", null, null, null, "https://github.com/jamiemansfield/minecraft-hosts/", null, 28, "Minecraft Hosts - Tracking", null, null, null },
                    { 2525, null, "Malware, phishing and scam domain block list. This is a bleeding-edge list fed by the tens of scam emails coming to my inbox every day, and will serve as a temporary countermeasure until these domains are added to Safe Browsing.", null, "marcos@orca.pet", null, "https://orca.pet/notonmyshift/", null, 14, "Not on my shift (Hosts)", null, null, null },
                    { 2526, null, "Malware, phishing and scam domain block list. This is a bleeding-edge list fed by the tens of scam emails coming to my inbox every day, and will serve as a temporary countermeasure until these domains are added to Safe Browsing.", null, "marcos@orca.pet", null, "https://orca.pet/notonmyshift/", null, 14, "Not on my shift (Adblock Plus)", null, null, null },
                    { 2527, null, "Eliminate Spotify Advertisements + Complete Server List", null, null, null, "https://gist.github.com/opus-x/3e673a9d5db2a214df05929a4eee6a57", null, null, "Eliminate Spotify Ads", null, null, null },
                    { 2528, null, null, null, null, null, "https://github.com/dibdot/DoH-IP-blocklists", null, 4, "DoH-IP-blocklists - DoH Domains", null, null, null },
                    { 2529, null, "This repository contains indicators of compromise extracted from some of Amnesty International's technical investigations in targeted threats against human rights defenders.", null, null, null, "https://github.com/AmnestyTech/investigations", null, null, "AmnestyTech Investigations - NSO 18th of July 2021", null, null, null },
                    { 2530, null, "Over my time of using Pi-hole, I’ve cloned and developed some blocklists for use with Pi-hole. The list below is short, but I hope you can find some use for these block lists. Enjoy!", null, null, null, "https://wp.owenthe.dev/pi-hole-block-pages/", null, 8, "Pi-hole Block Pages - Fortnite", null, null, null },
                    { 2531, null, "Over my time of using Pi-hole, I’ve cloned and developed some blocklists for use with Pi-hole. The list below is short, but I hope you can find some use for these block lists. Enjoy!", null, null, null, "https://wp.owenthe.dev/pi-hole-block-pages/", null, 8, "Pi-hole Block Pages - Redshell", null, null, null },
                    { 2532, null, "This is a list of domains who track, analyse and show banners.", null, null, null, "https://github.com/allendema/noplaylist", null, 2, "Web Beautifier by Allen", null, null, null },
                    { 2533, null, "The Owl House is yet another schoolhouse crush drama disguised as yet another Harry Potter clone for tweens. This list will help you stick to more inventive media instead.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Anti-'The Owl House' List", null, null, null },
                    { 2534, null, "This IP set combines IP and CIDR addresses from plentiful of major adblocker lists. It contains heavily altered content from Dandelion Sprout's Anti-Malware List, Dandelion Sprout's Nordic Filters, EasyList, uBlock Filters, uBlock Filters - Badware Risks, AdGuard Base Filter, AdGuard French Filter, EasyList Germany, ABP Anti-Circumvention Filters, RU AdList, Liste AR, and EasyList Spanish.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Dandelion Sprout's and other adblocker lists' IPs", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2534, 22 },
                    { 2533, 22 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2522, 2 },
                    { 2534, 39 },
                    { 2534, 34 },
                    { 2534, 9 },
                    { 2533, 3 },
                    { 2532, 2 },
                    { 2531, 1 },
                    { 2530, 1 },
                    { 2528, 2 },
                    { 2527, 1 },
                    { 2526, 47 },
                    { 2526, 4 },
                    { 2529, 2 },
                    { 2523, 3 },
                    { 2525, 2 },
                    { 2524, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2525, 7 },
                    { 2534, 7 },
                    { 2534, 2 },
                    { 2522, 2 },
                    { 2522, 3 },
                    { 2533, 30 },
                    { 2523, 25 },
                    { 2532, 3 },
                    { 2532, 2 },
                    { 2531, 3 },
                    { 2530, 30 },
                    { 2524, 3 },
                    { 2529, 6 },
                    { 2526, 2 },
                    { 2526, 5 },
                    { 2529, 3 },
                    { 2526, 7 },
                    { 2528, 12 },
                    { 2525, 2 },
                    { 2527, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2737, 2524, (short)1, "https://raw.githubusercontent.com/jamiemansfield/minecraft-hosts/master/lists/tracking.txt" },
                    { 2739, 2526, (short)1, "https://orca.pet/notonmyshift/abp.txt" },
                    { 2735, 2522, (short)1, "https://git.bubblev.org/bubblev/bubble-filter-lists/raw/branch/master/ads_and_trackers1.txt" },
                    { 2747, 2533, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/AntiOwlHouseList.txt" },
                    { 2746, 2533, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/AntiOwlHouseList.txt" },
                    { 2740, 2527, (short)1, "https://gist.githubusercontent.com/opus-x/3e673a9d5db2a214df05929a4eee6a57/raw" },
                    { 2736, 2523, (short)1, "https://git.bubblev.org/bubblev/bubble-filter-lists/raw/branch/master/sites_us_news.txt" },
                    { 2745, 2532, (short)1, "https://raw.githubusercontent.com/allendema/noplaylist/main/NoPlayList.txt" },
                    { 2741, 2528, (short)1, "https://raw.githubusercontent.com/dibdot/DoH-IP-blocklists/master/doh-domains.txt" },
                    { 2748, 2534, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Alternate versions Anti-Malware List/Dandelion Sprout's and other adblocker lists' IPs.ipset" },
                    { 2744, 2531, (short)1, "https://wp.owenthe.dev/redshell.txt" },
                    { 2738, 2525, (short)1, "https://orca.pet/notonmyshift/hosts.txt" },
                    { 2743, 2530, (short)1, "https://wp.owenthe.dev/fortnite.txt" },
                    { 2742, 2529, (short)1, "https://raw.githubusercontent.com/AmnestyTech/investigations/master/2021-07-18_nso/domains.txt" },
                    { 2749, 2534, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Alternate versions Anti-Malware List/Dandelion Sprout's and other adblocker lists' IPs.ipset" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2533, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2534, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2150, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2522, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2523, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2524, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2525, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2526, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2526, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2527, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2528, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2529, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2530, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2531, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2532, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2533, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2534, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2534, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2534, 39 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2522, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2522, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2523, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2524, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2525, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2525, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2526, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2526, 5 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2526, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2527, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2528, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2529, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2529, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2530, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2531, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2532, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2532, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2533, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2534, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2534, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2735);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2736);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2737);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2738);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2739);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2741);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2742);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2743);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2744);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2745);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2746);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2747);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2748);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2749);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2750);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2534);

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2150, 3 });
        }
    }
}
