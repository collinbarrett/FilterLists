using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2664 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2434, 165 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 380,
                column: "Primariness",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2002,
                column: "Url",
                value: "https://www.thedumbterminal.co.uk/files/services/squidblockedsites/blocked.txt");

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1814,
                column: "Name",
                value: "Remover for Mainstream Tabloid, Alt-Right and Antivaxx Sites");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2542, null, null, null, null, "https://forum.adguard.com/index.php?categories/filter-rules.66/", "https://github.com/AdguardTeam/AdguardFilters", "https://github.com/AdguardTeam/AdguardFilters/issues", 12, "AdGuard Annoyances Filter - Subscriptions and Newsletters Only", null, "https://kb.adguard.com/en/general/adguard-filter-policy", null },
                    { 2543, null, "HackerList is a RBL list of IP addresses that have attempted to hack my servers.", null, "soren@smallbusinesstech.net", null, "https://www.smallbusinesstech.net/pfblocker-lists/", null, 4, "HackerList", null, null, null },
                    { 2544, null, "SpamList is a RBL list of IP addresses that have sent my email server spam that made it through my other spam filtering. It works well when combined with SpamAssassin on the mail server.", null, "soren@smallbusinesstech.net", null, "https://www.smallbusinesstech.net/pfblocker-lists/", null, 4, "SpamList", null, null, null },
                    { 2545, null, "Whitelisted domains (and their subdomains) when enabling Privacy -> Allow Affiliate & Tracking Links.", null, null, null, "https://github.com/nextdns/metadata", "https://github.com/nextdns/metadata/issues", null, "NextDNS Affiliate Tracking Domains", null, null, null },
                    { 2546, null, "It turns out, if your device has bloated softwares (i.e. Apps that comes pre-installed and you can't remove them unless you root your device), you're forced into keeping those services running. Manufacturers like Huawei have stopped providing bootloader unlock codes thereby not allowing you to root your device. So, the best solution is to setup a local proxy server that blocks the connection.", null, "bhattdeep38@gmail.com", null, "https://github.com/deep-bhatt/huawei-block-list", null, 2, "Huawei Block List", null, null, null },
                    { 2547, null, "Throw away email addresses (burner emails) are great for single use signups where you would like the content but rather not give up your email. I'm okay with people using burner email addresses to get my free content, I just need to be able to filter them out of my list so it doesn't drive up bounces and hurt deliverability. Please send a PR with any new ones you find.", null, "wes@wesbos.com", null, "https://github.com/wesbos/burner-email-providers", "https://github.com/wesbos/burner-email-providers/issues", 2, "A list of burner email providers", null, null, null },
                    { 2548, null, "List of IoCs being utilized by Ransomwares.", null, null, null, "https://kriskintel.com/", null, null, "Krisk Intel - KTIP Ransomware Feeds", null, null, null },
                    { 2549, null, null, null, null, null, "https://github.com/brijrajparmar27/host-sources", null, null, "Hosts for DNS Level Blockers - Adult", null, null, null },
                    { 2550, null, null, null, "zelo72@dismail.de", null, "https://github.com/Zelo72/adguard", null, 11, "Zelo72's Referral Whitelist", null, null, null },
                    { 2551, null, null, null, null, null, "https://github.com/stamparm/maltrail", "https://github.com/stamparm/maltrail/issues", 2, "Maltrail - I2P", null, null, null },
                    { 2552, null, null, null, null, null, "https://github.com/stamparm/maltrail", "https://github.com/stamparm/maltrail/issues", 2, "Maltrail - IP info", null, null, null },
                    { 2553, null, null, null, null, null, "https://github.com/stamparm/maltrail", "https://github.com/stamparm/maltrail/issues", 2, "Maltrail - Parking sites", null, null, null },
                    { 2554, null, "In the early 2010's, it was common for Windows games to be hardcoded to require connections to first-party servers to work properly. To no one's surprise besides the game publishers, this began causing problems later on when the servers shut down, with games stuttering, freezing, or failing to start. This list implements community fixes to make those games playable and non-stuttering again.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "List for preventing games from freezing when pinging dead servers", null, null, null },
                    { 2555, null, "This list target international websites that clutter Mastodon public timelines and userfeeds with misinformation, unfounded articles, and/or contempt for humanity.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 35, "Remover for Mainstream Tabloid, Alt-Right and Antivaxx Sites - Mastodon", null, null, null },
                    { 2556, null, "This list target international websites that clutter Mastodon public timelines and userfeeds with misinformation, unfounded articles, and/or contempt for humanity.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/issues", 34, "ClearURLs for uBlock Origin", null, null, null },
                    { 2557, null, "Blocklist based on articles published by security research groups.", null, null, null, "https://github.com/scafroglia93/blocklists/", "https://github.com/scafroglia93/blocklists/issues", null, "scafroglia93's Hosts Blocklists - Malware traffic", null, null, null },
                    { 2558, null, "This is just a blocklist for Pi-Hole that I maintain for me personally. You can subscribe to it if you want, but I give no guarantee it doesn't break anything you need, indeed it does break some stuff, like Google Plus, but they are all things that I don't use anyway. Again, these are things I want to block on my own networks.", null, null, null, "https://github.com/Knuschberkeks/Knuschberblock/", null, 2, "Knuschberblock", null, null, null },
                    { 2559, null, null, null, "huzunluartemis@tuta.io", null, "https://github.com/HuzunluArtemis/TurkishAdblockList", null, 4, "HuzunluArtemis Turkish host adlist", null, null, null },
                    { 2560, null, null, null, "huzunluartemis@tuta.io", null, "https://github.com/HuzunluArtemis/TurkishAdblockList", null, 4, "HuzunluArtemis Turkish elemental adlist", null, null, null },
                    { 2561, null, null, null, "huzunluartemis@tuta.io", null, "https://github.com/HuzunluArtemis/TurkishAdblockList", null, 4, "HuzunluArtemis Turkish Bad IPlist", null, null, null },
                    { 2562, null, "Unofficial stores (Aptoide, Apkpure, GetJar...); Cracked & modded APK sources; Fake & unofficial websites; Malvertising & harmful websites; Closed source apps outside trusted stores (Lucky Patcher, YouTube Vanced...)", null, null, null, "https://github.com/furkun/AndroidSecurityHosts", null, 2, "Android Security Hosts (Hosts)", null, null, null },
                    { 2563, null, "Unofficial stores (Aptoide, Apkpure, GetJar...); Cracked & modded APK sources; Fake & unofficial websites; Malvertising & harmful websites; Closed source apps outside trusted stores (Lucky Patcher, YouTube Vanced...)", null, null, null, "https://github.com/furkun/AndroidSecurityHosts", null, 2, "Android Security Hosts (Domains)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 2559, "tr" },
                    { 2560, "tr" },
                    { 2561, "tr" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2542, 46 },
                    { 2554, 22 },
                    { 2555, 22 },
                    { 2556, 165 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2542, 6 },
                    { 2543, 9 },
                    { 2544, 9 },
                    { 2545, 50 },
                    { 2546, 2 },
                    { 2547, 2 },
                    { 2548, 2 },
                    { 2548, 9 },
                    { 2549, 1 },
                    { 2550, 47 },
                    { 2551, 2 },
                    { 2552, 2 },
                    { 2553, 9 },
                    { 2553, 34 },
                    { 2554, 6 },
                    { 2554, 47 },
                    { 2555, 2 },
                    { 2556, 4 },
                    { 2557, 2 },
                    { 2558, 2 },
                    { 2559, 1 },
                    { 2560, 3 },
                    { 2560, 4 },
                    { 2561, 9 },
                    { 2562, 1 },
                    { 2563, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2542, 28 },
                    { 2543, 20 },
                    { 2544, 20 },
                    { 2545, 10 },
                    { 2546, 3 },
                    { 2546, 19 },
                    { 2547, 20 },
                    { 2548, 6 },
                    { 2549, 11 },
                    { 2550, 10 },
                    { 2551, 12 },
                    { 2552, 15 },
                    { 2553, 6 },
                    { 2554, 15 },
                    { 2555, 25 },
                    { 2556, 3 },
                    { 2557, 6 },
                    { 2558, 3 },
                    { 2559, 3 },
                    { 2560, 3 },
                    { 2561, 3 },
                    { 2562, 15 },
                    { 2563, 15 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2762, 2542, (short)1, "https://raw.githubusercontent.com/AdguardTeam/AdguardFilters/master/AnnoyancesFilter/sections/subscriptions.txt" },
                    { 2763, 2543, (short)1, "https://pfblockerlists.smallbusinesstech.net/hackerlist.txt" },
                    { 2764, 2544, (short)1, "https://pfblockerlists.smallbusinesstech.net/spamlist.txt" },
                    { 2765, 2545, (short)1, "https://raw.githubusercontent.com/nextdns/metadata/master/privacy/affiliate-tracking-domains" },
                    { 2766, 2546, (short)1, "https://raw.githubusercontent.com/deep-bhatt/huawei-block-list/master/huawei-block-host.txt" },
                    { 2767, 2547, (short)1, "https://raw.githubusercontent.com/wesbos/burner-email-providers/master/emails.txt" },
                    { 2768, 2548, (short)1, "https://kriskintel.com/feeds/ktip_ransomware_feeds.txt" },
                    { 2769, 2549, (short)1, "https://raw.githubusercontent.com/brijrajparmar27/host-sources/master/Porn/hosts" },
                    { 2770, 2550, (short)1, "https://raw.githubusercontent.com/Zelo72/adguard/main/whitelist.referral.adguard" },
                    { 2771, 2551, (short)1, "https://github.com/stamparm/maltrail/blob/master/trails/static/suspicious/i2p.txt" },
                    { 2772, 2552, (short)1, "https://github.com/stamparm/maltrail/blob/master/trails/static/suspicious/ipinfo.txt" },
                    { 2773, 2553, (short)1, "https://github.com/stamparm/maltrail/blob/master/trails/static/suspicious/parking_site.txt" },
                    { 2774, 2554, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/DeadServerGamePingList.txt" },
                    { 2775, 2554, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/DeadServerGamePingList.txt" },
                    { 2776, 2555, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/Sensitive lists/TabloidRemover-MastodonCategoryForImports.csv" },
                    { 2777, 2555, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/Sensitive lists/TabloidRemover-MastodonCategoryForImports.csv" },
                    { 2778, 2556, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/ClearURLs for uBo/clear_urls_uboified.txt" },
                    { 2779, 2556, (short)2, "https://gitlab.com/DandelionSprout/adfilt/-/raw/master/ClearURLs for uBo/clear_urls_uboified.txt" },
                    { 2780, 2557, (short)1, "https://raw.githubusercontent.com/scafroglia93/blocklists/master/blocklists-malware-traffic.txt" },
                    { 2781, 2558, (short)1, "https://raw.githubusercontent.com/Knuschberkeks/Knuschberblock/main/Knuschberblock.txt" },
                    { 2782, 2559, (short)1, "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/HostsList.txt" },
                    { 2783, 2560, (short)1, "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/ElementalList.txt" },
                    { 2784, 2561, (short)1, "https://raw.githubusercontent.com/huzunluartemis/TurkishAdblockList/main/src/BadIpList.txt" },
                    { 2785, 2562, (short)1, "https://raw.githubusercontent.com/furkun/AndroidSecurityHosts/main/hosts" },
                    { 2786, 2563, (short)1, "https://raw.githubusercontent.com/furkun/AndroidSecurityHosts/main/domains.txt" },
                    { 2787, 2556, (short)3, "https://codeberg.org/rusty-snake/firefox-config/src/branch/main/assets/uBlockOrigin:queryprune.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2559, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2560, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 2561, "tr" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2434, 165 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2542, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2554, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2555, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2556, 165 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2542, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2543, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2544, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2545, 50 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2546, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2547, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2548, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2548, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2549, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2550, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2551, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2552, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2553, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2553, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2554, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2554, 47 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2555, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2556, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2557, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2558, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2559, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2560, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2560, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2561, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2562, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2563, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2542, 28 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2543, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2544, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2545, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2546, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2546, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2547, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2548, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2549, 11 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2550, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2551, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2552, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2553, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2554, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2555, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2556, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2557, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2558, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2559, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2560, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2561, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2562, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2563, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2764);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2766);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2767);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2768);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2769);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2770);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2771);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2772);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2773);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2774);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2775);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2776);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2777);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2778);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2779);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2780);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2781);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2782);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2783);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2784);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2786);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2787);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2563);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 380,
                column: "Primariness",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2002,
                column: "Url",
                value: "http://www.thedumbterminal.co.uk/files/services/squidblockedsites/blocked.txt");

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "SegmentNumber", "Url" },
                values: new object[] { 379, 251, (short)1, (short)0, "http://abp.mozilla-hispano.org/nauscopio/filtros.txt" });

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1814,
                column: "Name",
                value: "Remover for Mainstream Tabloid and Alt-Right Sites");
        }
    }
}
