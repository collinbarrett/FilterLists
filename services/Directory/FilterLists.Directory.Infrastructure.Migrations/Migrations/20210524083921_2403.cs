using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2403 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2434,
                column: "IssuesUrl",
                value: "https://github.com/DandelionSprout/adfilt/discussions/163");

            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2498, null, null, null, null, null, "https://www.joinhoney.com/", null, null, "Honey Smart Shopping", null, null, null },
                    { 2499, null, "Protect your IP address and some personal data with the hosts file.", null, null, null, "https://github.com/furkun/ProtectorHosts", null, null, "Anti-IP-Grabber-Hosts", null, null, null },
                    { 2500, null, "This list is a fork of DandelionSprout's AntiKpopSpammersTwitter updated with more K-pop artists, bands and related stuff.", null, null, null, "https://github.com/Cinnamon-Unltd/Anti-Kpop-Spammers-Filterlist-for-Twitter", null, 35, "Anti-K-pop spammers on Twitter Fork List", null, null, null },
                    { 2501, null, "A list of free, public, forward proxy servers. UPDATED DAILY!", null, null, null, "https://github.com/clarketm/proxy-list/", null, 2, "proxy-list", null, null, null },
                    { 2502, null, "A regularly maintained blocklist to filter out spam and junk domains from search engines results.", null, null, null, "https://github.com/no-cmyk/Search-Engine-Spam-Blocklist", null, null, "Search Engine Spam Blocklist", null, null, null },
                    { 2503, null, "An IP Addresses list of Tor Nodes", "https://paypal.me/secopssolutions", null, null, "https://amisafe.secops.in/", null, null, "Tor IP Addresses - All nodes", null, null, null },
                    { 2504, null, "An IP Addresses list of Tor Exit Nodes", "https://paypal.me/secopssolutions", null, null, "https://amisafe.secops.in/", null, null, "Tor IP Addresses - Exit nodes", null, null, null },
                    { 2505, null, "The DROP list will not include any IP address space under the control of any legitimate network - even if being used by \"the spammers from hell\". DROP will only include netblocks allocated directly by an established Regional Internet Registry (RIR) or National Internet Registry (NIR) such as ARIN, RIPE, AFRINIC, APNIC, LACNIC or KRNIC or direct RIR allocations.", "https://paypal.me/secopssolutions", null, null, "https://www.spamhaus.org/drop/", null, 7, "Spamhaus Don't Route Or Peer List (DROP)", null, null, null },
                    { 2506, null, "The DROPv6 list includes IPv6 ranges allocated to spammers or cyber criminals. DROPv6 will only include IPv6 netblocks allocated directly by an established Regional Internet Registry (RIR) or National Internet Registry (NIR) such as ARIN, RIPE, AFRINIC, APNIC, LACNIC or KRNIC or direct RIR allocations.", "https://paypal.me/secopssolutions", null, null, "https://www.spamhaus.org/drop/", null, 7, "Spamhaus IPv6 DROP List (DROPv6)", null, null, null },
                    { 2507, null, "EDROP is an extension of the DROP list that includes suballocated netblocks controlled by spammers or cyber criminals. EDROP is meant to be used in addition to the direct allocations on the DROP list.", "https://paypal.me/secopssolutions", null, null, "https://www.spamhaus.org/drop/", null, 7, "Spamhaus Extended DROP List (EDROP)", null, null, null },
                    { 2508, null, null, null, null, null, "http://ipverse.net/", null, null, "IPverse IP address block lists - Netherlands IPv4", null, null, null },
                    { 2509, null, null, null, null, null, "http://ipverse.net/", null, null, "IPverse IP address block lists - Netherlands IPv6", null, null, null },
                    { 2510, null, "This file blocks all connections to sites which are from Axel Springer Verlag or have a connection with them.", null, null, null, "https://github.com/autinerd/anti-axelspringer-hosts/", null, null, "Anti Axel Springer hosts file (Domains)", null, null, null },
                    { 2511, null, "This file blocks all connections to sites which are from Axel Springer Verlag or have a connection with them.", null, null, null, "https://github.com/autinerd/anti-axelspringer-hosts/", null, null, "Anti Axel Springer hosts file", null, null, null },
                    { 2512, null, "Opt-in allowlist for users of «Actually Legitimate URL Shortener Tool», to at least attempt to re-allow monetary affiliate support tags.", "https://sproutsluckycorner.wordpress.com/2017/11/14/my-work-and-contact-resume/#donations", "imreeil42@gmail.com", null, "https://github.com/DandelionSprout/adfilt", "https://github.com/DandelionSprout/adfilt/discussions/163", 35, "Actually Legitimate URL Shortener Tool - Affiliate tag allowlist", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2512, 22 });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2498, 28 },
                    { 2512, 4 },
                    { 2511, 1 },
                    { 2510, 2 },
                    { 2509, 41 },
                    { 2508, 34 },
                    { 2507, 34 },
                    { 2506, 41 },
                    { 2504, 39 },
                    { 2504, 9 },
                    { 2503, 39 },
                    { 2503, 9 },
                    { 2505, 34 },
                    { 2502, 2 },
                    { 2499, 1 },
                    { 2501, 9 },
                    { 2500, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2502, 9 },
                    { 2512, 10 },
                    { 2498, 10 },
                    { 2511, 19 },
                    { 2510, 19 },
                    { 2499, 3 },
                    { 2509, 20 },
                    { 2508, 20 },
                    { 2502, 6 },
                    { 2500, 30 },
                    { 2507, 6 },
                    { 2504, 12 },
                    { 2505, 6 },
                    { 2503, 12 },
                    { 2501, 12 },
                    { 2506, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2713, 2502, (short)1, "https://raw.githubusercontent.com/no-cmyk/Search-Engine-Spam-Domains-Blocklist/master/blocklist.txt" },
                    { 2712, 2501, (short)1, "https://raw.githubusercontent.com/clarketm/proxy-list/master/proxy-list-raw.txt" },
                    { 2709, 2498, (short)1, "https://www.joinhoney.com/whitelist/honey-smart-shopping.txt" },
                    { 2722, 2511, (short)1, "https://raw.githubusercontent.com/autinerd/anti-axelspringer-hosts/master/axelspringer-hosts" },
                    { 2714, 2503, (short)1, "https://raw.githubusercontent.com/SecOps-Institute/Tor-IP-Addresses/master/tor-nodes.lst" },
                    { 2721, 2510, (short)1, "https://raw.githubusercontent.com/autinerd/anti-axelspringer-hosts/master/ios-adguard.txt" },
                    { 2717, 2506, (short)1, "https://raw.githubusercontent.com/SecOps-Institute/SpamhausIPLists/master/drop_ipv6.txt" },
                    { 2715, 2504, (short)1, "https://raw.githubusercontent.com/SecOps-Institute/Tor-IP-Addresses/master/tor-exit-nodes.lst" },
                    { 2710, 2499, (short)1, "https://raw.githubusercontent.com/furkun/Anti-IP-Grabber-Hosts/main/hosts" },
                    { 2719, 2508, (short)1, "http://ipverse.net/ipblocks/data/countries/nl.zone" },
                    { 2723, 2512, (short)1, "https://raw.githubusercontent.com/DandelionSprout/adfilt/master/LegitimateURLShortener-AffiliateTagAllowlist.txt" },
                    { 2718, 2507, (short)1, "https://raw.githubusercontent.com/SecOps-Institute/SpamhausIPLists/master/edrop.txt" },
                    { 2716, 2505, (short)1, "https://raw.githubusercontent.com/SecOps-Institute/SpamhausIPLists/master/drop.txt" },
                    { 2711, 2500, (short)1, "https://raw.githubusercontent.com/Cinnamon-Unltd/Anti-Kpop-Spammers-Filterlist-for-Twitter/main/AntiKPopSpammersFilterlistTwitter.txt" },
                    { 2720, 2509, (short)1, "http://ipverse.net/ipblocks/data/countries/nl-ipv6.zone" },
                    { 2724, 2512, (short)2, "https://gitlab.com/DandelionSprout/adfilt/raw/master/LegitimateURLShortener-AffiliateTagAllowlist.txt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2512, 22 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2498, 28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2499, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2500, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2501, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2502, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2503, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2503, 39 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2504, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2504, 39 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2505, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2506, 41 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2507, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2508, 34 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2509, 41 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2510, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2511, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2512, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2498, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2499, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2500, 30 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2501, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2502, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2502, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2503, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2504, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2505, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2506, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2507, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2508, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2509, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2510, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2511, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2512, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2715);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2716);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2717);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2718);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2719);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2720);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2721);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.UpdateData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2434,
                column: "IssuesUrl",
                value: "https://github.com/DandelionSprout/adfilt/issues");
        }
    }
}
