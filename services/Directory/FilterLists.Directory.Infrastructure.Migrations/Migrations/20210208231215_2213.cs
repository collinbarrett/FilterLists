using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2443, null, "The article at https://www.ghacks.net/2021/01/22/favicons-may-be-used-to-track-users/ probably explains this list better than anything I could've written myself.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Anti-Favicon List", null, null, null },
                    { 2444, null, "There's also additional categories that cover unusual malware and phishing domains that very few other lists seem to cover.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Dandelion Sprout's Anti-Malware List (Domains)", null, null, null },
                    { 2445, null, "A proof of concept that no media paywall is impenetrable, and some of the existing content protection solutions are hopelessly inadequate.", null, "asparuh@unleaslab.com", null, "https://github.com/acnapyx/paywall-remover", "https://github.com/acnapyx/paywall-remover/issues", 8, "Paywall Remover", null, null, null },
                    { 2446, null, "We also offer an endpoint that blocks a crowdsourced list (https://dns.hostux.net/en/adslist.txt) of known advertisement and tracking domains.", null, "contact@hostux.net", null, "https://dns.hostux.net/en/", null, null, "Hostux - Blocking Ads and Trackers", null, null, null },
                    { 2447, null, "Block Apple advertising on Apple devices.", null, null, null, "https://github.com/arman68/noappleads", "https://github.com/arman68/noappleads/issues", null, "No Apple ads", null, null, null },
                    { 2448, null, null, null, null, null, "https://github.com/vavavr00m/lists", "https://github.com/vavavr00m/lists/issues", 11, "vavavr00m's lists - Google Translate", null, null, null },
                    { 2449, null, null, null, null, null, "https://github.com/vavavr00m/lists", "https://github.com/vavavr00m/lists/issues", 11, "vavavr00m's lists - Phorm", null, null, null },
                    { 2450, null, "I created this project as a way to optimize adware protection of my router TPLINK 1043 with Openwrt. It's an excellent router, but has very little available memory (8MB) and a median processor (400MHz). I noticed that the articles and tutorials on ad-blocking does not take into account the optimization of hosts and domains. (…) But these lists are variations of websites that create random subdomains, interfering with the blocking efficiency. Only one domain, 302br.net has +17,000 registered subdomains in lists. So I first tried to treat (sub)domains within the router, (…) and impacted the performance of the navigation here at home, (…). This takes ~2Mb on the router. After grouping, my list has about 27,000 hosts. (…)", null, null, null, "https://github.com/jmhenrique/adblock", "https://github.com/jmhenrique/adblock/issues", 11, "Adblock by Jm (Hosts)", null, null, null },
                    { 2452, null, null, null, null, null, "https://github.com/jbunner/adblock", "https://github.com/jbunner/adblock/issues", 4, "jbunner's Adblock - Roblox", null, null, null },
                    { 2453, null, null, null, null, null, "https://github.com/jbunner/adblock", "https://github.com/jbunner/adblock/issues", 4, "jbunner's Adblock - Microsoft Teams", null, null, null },
                    { 2454, null, null, null, null, null, "https://github.com/jbunner/adblock", "https://github.com/jbunner/adblock/issues", 4, "jbunner's Adblock - ScratchMit", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2443, 22 },
                    { 2444, 22 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2452, 3 },
                    { 2449, 1 },
                    { 2448, 1 },
                    { 2447, 47 },
                    { 2450, 1 },
                    { 2445, 3 },
                    { 2453, 3 },
                    { 2446, 22 },
                    { 2443, 28 },
                    { 2444, 2 },
                    { 2454, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2444, 7 },
                    { 2449, 6 },
                    { 2449, 3 },
                    { 2443, 3 },
                    { 2452, 19 },
                    { 2448, 19 },
                    { 2454, 30 },
                    { 2447, 2 },
                    { 2452, 30 },
                    { 2446, 3 },
                    { 2446, 2 },
                    { 2445, 40 },
                    { 2444, 6 },
                    { 2453, 19 },
                    { 2450, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2657, 2453, (short)1, "https://raw.githubusercontent.com/jbunner/adblock/master/a-msteams.txt" },
                    { 2656, 2452, (short)1, "https://raw.githubusercontent.com/jbunner/adblock/master/a-roblox.txt" },
                    { 2651, 2447, (short)1, "https://raw.githubusercontent.com/arman68/noappleads/main/adguard-blocklist.txt" },
                    { 2653, 2449, (short)1, "https://raw.githubusercontent.com/vavavr00m/lists/main/hosts/phorm" },
                    { 2652, 2448, (short)1, "https://raw.githubusercontent.com/vavavr00m/lists/main/hosts/googletranslate" },
                    { 2650, 2446, (short)1, "https://dns.hostux.net/ads" },
                    { 2649, 2445, (short)1, "https://raw.githubusercontent.com/acnapyx/paywall-remover/master/paywall-remover-list.txt" },
                    { 2648, 2444, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/NorwegianExperimentalList alternate versions/DandelionSproutsNorskeFiltreDomains.txt" },
                    { 2647, 2444, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/NorwegianExperimentalList alternate versions/DandelionSproutsNorskeFiltreDomains.txt" },
                    { 2646, 2443, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Special security lists/AntiFaviconList.txt" },
                    { 2645, 2443, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Special security lists/AntiFaviconList.txt" },
                    { 2654, 2450, (short)1, "https://raw.githubusercontent.com/jmhenrique/adblock/master/etc/adblock_hosts" },
                    { 2658, 2454, (short)1, "https://raw.githubusercontent.com/jbunner/adblock/master/a-scratch.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2443, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2444, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2443, 28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2444, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2445, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2446, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2447, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2448, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2449, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2450, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2452, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2453, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2454, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2443, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2444, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2444, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2445, 40 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2446, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2446, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2447, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2448, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2449, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2449, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2450, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2452, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2452, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2453, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2454, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2645);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2646);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2647);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2648);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2649);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2651);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2652);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2654);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2656);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2658);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2454);
        }
    }
}
