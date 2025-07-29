using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddShadowWhispererFilterLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2754, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Wildcards for dnscrypt-proxy)", null, null, null },
                    { 2755, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Response Policy Zone)", null, null, null },
                    { 2756, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Unbound)", null, null, null },
                    { 2757, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Windows)", null, null, null },
                    { 2758, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Little Snitch)", null, null, null },
                    { 2759, null, "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Wildcards for dnscrypt-proxy)", null, null, null },
                    { 2760, null, "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Response Policy Zone)", null, null, null },
                    { 2761, null, "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Unbound)", null, null, null },
                    { 2762, null, "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Windows)", null, null, null },
                    { 2763, null, "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Little Snitch)", null, null, null },
                    { 2764, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Domains with wildcards)", null, null, null },
                    { 2765, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (dnsmasq)", null, null, null },
                    { 2766, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Wildcards for dnscrypt-proxy)", null, null, null },
                    { 2767, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Response Policy Zone)", null, null, null },
                    { 2768, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Unbound)", null, null, null },
                    { 2769, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Windows)", null, null, null },
                    { 2770, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Little Snitch)", null, null, null },
                    { 2771, null, "DNS blocklist for blocking advertisements from various sources", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Ads", null, null, null },
                    { 2772, null, "DNS blocklist for blocking adult content and NSFW websites", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Adult", null, null, null },
                    { 2773, null, "DNS blocklist for blocking Apple telemetry and tracking domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Apple", null, null, null },
                    { 2774, null, "DNS blocklist for blocking bloatware and unnecessary software connections", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Bloat", null, null, null },
                    { 2775, null, "DNS blocklist for blocking chat and messaging platform trackers", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Chat", null, null, null },
                    { 2776, null, "DNS blocklist for blocking cryptocurrency mining and related services", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Cryptocurrency", null, null, null },
                    { 2777, null, "DNS blocklist for blocking dating websites and services", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Dating", null, null, null },
                    { 2778, null, "DNS blocklist for blocking dynamic DNS and frequently changing domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Dynamic", null, null, null },
                    { 2779, null, "DNS blocklist for blocking free hosting and potentially suspicious domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Free", null, null, null },
                    { 2780, null, "DNS blocklist for blocking junk mail and spam-related domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Junk", null, null, null },
                    { 2781, null, "DNS blocklist for blocking malware hosting and distribution sites", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Malware", null, null, null },
                    { 2782, null, "DNS blocklist for blocking marketing and promotional domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Marketing", null, null, null },
                    { 2783, null, "DNS blocklist for blocking email marketing and newsletter domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Marketing-Email", null, null, null },
                    { 2784, null, "DNS blocklist for blocking Microsoft telemetry and tracking domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Microsoft", null, null, null },
                    { 2785, null, "DNS blocklist for blocking remote access and control software", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Remote", null, null, null },
                    { 2786, null, "DNS blocklist for blocking risky and potentially harmful domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Risk", null, null, null },
                    { 2787, null, "DNS blocklist for blocking scam and fraudulent websites", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Scam", null, null, null },
                    { 2788, null, "DNS blocklist for blocking shock sites and disturbing content", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Shock", null, null, null },
                    { 2789, null, "DNS blocklist for blocking top-level domains associated with abuse", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Top_Level", null, null, null },
                    { 2790, null, "DNS blocklist for blocking tracking and analytics domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Tracking", null, null, null },
                    { 2791, null, "DNS blocklist for blocking VPN tunnels and proxy services", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Tunnels", null, null, null },
                    { 2792, null, "DNS blocklist for blocking typosquatting and misspelled domains", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Typo", null, null, null },
                    { 2793, null, "DNS blocklist for blocking URL shortening services", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - UrlShortener", null, null, null },
                    { 2794, null, "DNS allowlist for popular cloud services and CDNs", null, null, null, "https://github.com/ShadowWhisperer/BlockLists", "https://github.com/ShadowWhisperer/BlockLists/issues", 7, "ShadowWhisperer - Whitelist", null, null, null },
                    { 2795, null, "IP blocklist for extreme brute force attack sources from honeypot data", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - BruteForce Extreme", null, null, null },
                    { 2796, null, "IP blocklist for high-level brute force attack sources from honeypot data", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - BruteForce High", null, null, null },
                    { 2797, null, "IP blocklist for low-level brute force attack sources from honeypot data", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - BruteForce Low", null, null, null },
                    { 2798, null, "IP blocklist for medium-level brute force attack sources from honeypot data", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - BruteForce Medium", null, null, null },
                    { 2799, null, "IP blocklist for malware-infected browsers and compromised systems", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Malware Browser", null, null, null },
                    { 2800, null, "IP blocklist for known hacker and attacker IP addresses", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Malware Hackers", null, null, null },
                    { 2801, null, "IP blocklist for old hacker and attacker IP addresses (archived)", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Malware Hackers_Old", null, null, null },
                    { 2802, null, "IP blocklist for malicious hosting providers and bulletproof hosting", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Malware Hosting", null, null, null },
                    { 2803, null, "IP blocklist for advertising and promotional IP addresses", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Other Ads", null, null, null },
                    { 2804, null, "IP blocklist for tracking and analytics IP addresses", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Other Trackers", null, null, null },
                    { 2805, null, "IP blocklist for tunnel and proxy service IP addresses", null, null, null, "https://github.com/ShadowWhisperer/IPs", "https://github.com/ShadowWhisperer/IPs/issues", 7, "ShadowWhisperer - Other Tunnel", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1735, 3152, (short)2, "https://badmojr.github.io/1Hosts/Pro/domains.txt" },
                    { 1735, 3153, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/domains.txt" },
                    { 1955, 3154, (short)2, "https://badmojr.github.io/1Hosts/Pro/adblock.txt" },
                    { 1955, 3155, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/adblock.txt" },
                    { 2003, 3156, (short)2, "https://badmojr.github.io/1Hosts/Pro/dnsmasq.conf" },
                    { 2003, 3157, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/dnsmasq.conf" }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 204, null, "ShadowWhisperer", null, "https://github.com/ShadowWhisperer" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2771, 204 },
                    { 2772, 204 },
                    { 2773, 204 },
                    { 2774, 204 },
                    { 2775, 204 },
                    { 2776, 204 },
                    { 2777, 204 },
                    { 2778, 204 },
                    { 2779, 204 },
                    { 2780, 204 },
                    { 2781, 204 },
                    { 2782, 204 },
                    { 2783, 204 },
                    { 2784, 204 },
                    { 2785, 204 },
                    { 2786, 204 },
                    { 2787, 204 },
                    { 2788, 204 },
                    { 2789, 204 },
                    { 2790, 204 },
                    { 2791, 204 },
                    { 2792, 204 },
                    { 2793, 204 },
                    { 2794, 204 },
                    { 2795, 204 },
                    { 2796, 204 },
                    { 2797, 204 },
                    { 2798, 204 },
                    { 2799, 204 },
                    { 2800, 204 },
                    { 2801, 204 },
                    { 2802, 204 },
                    { 2803, 204 },
                    { 2804, 204 },
                    { 2805, 204 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2771, (short)2 },
                    { 2772, (short)2 },
                    { 2773, (short)2 },
                    { 2774, (short)2 },
                    { 2775, (short)2 },
                    { 2776, (short)2 },
                    { 2777, (short)2 },
                    { 2778, (short)2 },
                    { 2779, (short)2 },
                    { 2780, (short)2 },
                    { 2781, (short)2 },
                    { 2782, (short)2 },
                    { 2783, (short)2 },
                    { 2784, (short)2 },
                    { 2785, (short)2 },
                    { 2786, (short)2 },
                    { 2787, (short)2 },
                    { 2788, (short)2 },
                    { 2789, (short)2 },
                    { 2790, (short)2 },
                    { 2791, (short)2 },
                    { 2792, (short)2 },
                    { 2793, (short)2 },
                    { 2794, (short)2 },
                    { 2795, (short)9 },
                    { 2796, (short)9 },
                    { 2797, (short)9 },
                    { 2798, (short)9 },
                    { 2799, (short)9 },
                    { 2800, (short)9 },
                    { 2801, (short)9 },
                    { 2802, (short)9 },
                    { 2803, (short)9 },
                    { 2804, (short)9 },
                    { 2805, (short)9 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2771, 2 },
                    { 2772, 11 },
                    { 2773, 19 },
                    { 2774, 15 },
                    { 2775, 4 },
                    { 2776, 1 },
                    { 2777, 15 },
                    { 2778, 37 },
                    { 2779, 15 },
                    { 2780, 15 },
                    { 2781, 6 },
                    { 2782, 2 },
                    { 2783, 2 },
                    { 2784, 19 },
                    { 2785, 12 },
                    { 2786, 15 },
                    { 2787, 7 },
                    { 2788, 15 },
                    { 2789, 15 },
                    { 2790, 3 },
                    { 2791, 12 },
                    { 2792, 15 },
                    { 2793, 23 },
                    { 2794, 10 },
                    { 2795, 20 },
                    { 2796, 20 },
                    { 2797, 20 },
                    { 2798, 20 },
                    { 2799, 6 },
                    { 2800, 6 },
                    { 2801, 6 },
                    { 2802, 6 },
                    { 2803, 2 },
                    { 2804, 3 },
                    { 2805, 12 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2754, 3101, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/domains.wildcards" },
                    { 2754, 3102, (short)2, "https://badmojr.github.io/1Hosts/Lite/domains.wildcards" },
                    { 2754, 3103, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/domains.wildcards" },
                    { 2755, 3104, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/rpz.txt" },
                    { 2755, 3105, (short)2, "https://badmojr.github.io/1Hosts/Lite/rpz.txt" },
                    { 2755, 3106, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/rpz.txt" },
                    { 2756, 3107, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/unbound.conf" },
                    { 2756, 3108, (short)2, "https://badmojr.github.io/1Hosts/Lite/unbound.conf" },
                    { 2756, 3109, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/unbound.conf" },
                    { 2757, 3110, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/hosts.win" },
                    { 2757, 3111, (short)2, "https://badmojr.github.io/1Hosts/Lite/hosts.win" },
                    { 2757, 3112, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/hosts.win" },
                    { 2758, 3113, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/snitch.rules" },
                    { 2758, 3114, (short)2, "https://badmojr.github.io/1Hosts/Lite/snitch.rules" },
                    { 2758, 3115, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/snitch.rules" },
                    { 2759, 3116, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/domains.wildcards" },
                    { 2759, 3117, (short)2, "https://badmojr.github.io/1Hosts/Pro/domains.wildcards" },
                    { 2759, 3118, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/domains.wildcards" },
                    { 2760, 3119, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/rpz.txt" },
                    { 2760, 3120, (short)2, "https://badmojr.github.io/1Hosts/Pro/rpz.txt" },
                    { 2760, 3121, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/rpz.txt" },
                    { 2761, 3122, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/unbound.conf" },
                    { 2761, 3123, (short)2, "https://badmojr.github.io/1Hosts/Pro/unbound.conf" },
                    { 2761, 3124, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/unbound.conf" },
                    { 2762, 3125, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/hosts.win" },
                    { 2762, 3126, (short)2, "https://badmojr.github.io/1Hosts/Pro/hosts.win" },
                    { 2762, 3127, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/hosts.win" },
                    { 2763, 3128, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/snitch.rules" },
                    { 2763, 3129, (short)2, "https://badmojr.github.io/1Hosts/Pro/snitch.rules" },
                    { 2763, 3130, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/snitch.rules" },
                    { 2764, 3131, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/wildcards.txt" },
                    { 2764, 3132, (short)2, "https://badmojr.github.io/1Hosts/Xtra/wildcards.txt" },
                    { 2764, 3133, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/wildcards.txt" },
                    { 2765, 3134, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/dnsmasq.conf" },
                    { 2765, 3135, (short)2, "https://badmojr.github.io/1Hosts/Xtra/dnsmasq.conf" },
                    { 2765, 3136, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/dnsmasq.conf" },
                    { 2766, 3137, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/domains.wildcards" },
                    { 2766, 3138, (short)2, "https://badmojr.github.io/1Hosts/Xtra/domains.wildcards" },
                    { 2766, 3139, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/domains.wildcards" },
                    { 2767, 3140, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/rpz.txt" },
                    { 2767, 3141, (short)2, "https://badmojr.github.io/1Hosts/Xtra/rpz.txt" },
                    { 2767, 3142, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/rpz.txt" },
                    { 2768, 3143, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/unbound.conf" },
                    { 2768, 3144, (short)2, "https://badmojr.github.io/1Hosts/Xtra/unbound.conf" },
                    { 2768, 3145, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/unbound.conf" },
                    { 2769, 3146, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/hosts.win" },
                    { 2769, 3147, (short)2, "https://badmojr.github.io/1Hosts/Xtra/hosts.win" },
                    { 2769, 3148, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/hosts.win" },
                    { 2770, 3149, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/snitch.rules" },
                    { 2770, 3150, (short)2, "https://badmojr.github.io/1Hosts/Xtra/snitch.rules" },
                    { 2770, 3151, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/snitch.rules" },
                    { 2771, 3158, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Ads" },
                    { 2772, 3159, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Adult" },
                    { 2773, 3160, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Apple" },
                    { 2774, 3161, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Bloat" },
                    { 2775, 3162, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Chat" },
                    { 2776, 3163, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Cryptocurrency" },
                    { 2777, 3164, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Dating" },
                    { 2778, 3165, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Dynamic" },
                    { 2779, 3166, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Free" },
                    { 2780, 3167, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Junk" },
                    { 2781, 3168, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Malware" },
                    { 2782, 3169, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Marketing" },
                    { 2783, 3170, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Marketing-Email" },
                    { 2784, 3171, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Microsoft" },
                    { 2785, 3172, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Remote" },
                    { 2786, 3173, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Risk" },
                    { 2787, 3174, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Scam" },
                    { 2788, 3175, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Shock" },
                    { 2789, 3176, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Top_Level" },
                    { 2790, 3177, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Tracking" },
                    { 2791, 3178, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Tunnels" },
                    { 2792, 3179, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/Typo" },
                    { 2793, 3180, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Lists/UrlShortener" },
                    { 2794, 3181, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/BlockLists/master/Whitelists/Whitelist" },
                    { 2795, 3182, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/BruteForce/Extreme" },
                    { 2796, 3183, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/BruteForce/High" },
                    { 2797, 3184, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/BruteForce/Low" },
                    { 2798, 3185, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/BruteForce/Medium" },
                    { 2799, 3186, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Malware/Browser" },
                    { 2800, 3187, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Malware/Hackers" },
                    { 2801, 3188, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Malware/Hackers_Old" },
                    { 2802, 3189, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Malware/Hosting" },
                    { 2803, 3190, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Other/Ads" },
                    { 2804, 3191, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Other/Trackers" },
                    { 2805, 3192, (short)1, "https://raw.githubusercontent.com/ShadowWhisperer/IPs/master/Other/Tunnel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2771, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2772, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2773, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2774, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2775, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2776, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2777, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2778, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2779, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2780, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2781, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2782, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2783, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2784, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2785, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2786, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2787, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2788, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2789, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2790, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2791, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2792, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2793, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2794, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2795, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2796, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2797, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2798, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2799, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2800, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2801, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2802, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2803, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2804, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2805, 204 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2771, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2772, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2773, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2774, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2775, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2776, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2777, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2778, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2779, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2780, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2781, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2782, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2783, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2784, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2785, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2786, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2787, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2788, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2789, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2790, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2791, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2792, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2793, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2794, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2795, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2796, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2797, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2798, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2799, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2800, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2801, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2802, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2803, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2804, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2805, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2771, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2772, 11 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2773, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2774, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2775, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2776, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2777, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2778, 37 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2779, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2780, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2781, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2782, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2783, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2784, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2785, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2786, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2787, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2788, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2789, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2790, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2791, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2792, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2793, 23 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2794, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2795, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2796, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2797, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2798, 20 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2799, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2800, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2801, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2802, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2803, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2804, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2805, 12 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1735, 3152 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1735, 3153 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1955, 3154 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1955, 3155 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2003, 3156 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2003, 3157 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2754, 3101 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2754, 3102 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2754, 3103 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2755, 3104 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2755, 3105 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2755, 3106 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2756, 3107 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2756, 3108 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2756, 3109 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2757, 3110 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2757, 3111 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2757, 3112 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2758, 3113 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2758, 3114 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2758, 3115 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2759, 3116 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2759, 3117 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2759, 3118 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2760, 3119 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2760, 3120 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2760, 3121 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2761, 3122 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2761, 3123 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2761, 3124 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2762, 3125 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2762, 3126 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2762, 3127 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2763, 3128 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2763, 3129 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2763, 3130 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2764, 3131 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2764, 3132 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2764, 3133 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2765, 3134 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2765, 3135 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2765, 3136 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2766, 3137 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2766, 3138 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2766, 3139 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2767, 3140 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2767, 3141 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2767, 3142 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2768, 3143 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2768, 3144 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2768, 3145 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2769, 3146 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2769, 3147 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2769, 3148 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2770, 3149 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2770, 3150 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2770, 3151 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2771, 3158 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2772, 3159 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2773, 3160 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2774, 3161 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2775, 3162 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2776, 3163 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2777, 3164 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2778, 3165 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2779, 3166 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2780, 3167 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2781, 3168 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2782, 3169 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2783, 3170 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2784, 3171 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2785, 3172 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2786, 3173 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2787, 3174 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2788, 3175 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2789, 3176 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2790, 3177 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2791, 3178 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2792, 3179 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2793, 3180 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2794, 3181 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2795, 3182 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2796, 3183 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2797, 3184 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2798, 3185 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2799, 3186 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2800, 3187 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2801, 3188 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2802, 3189 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2803, 3190 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2804, 3191 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2805, 3192 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2754);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2755);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2756);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2757);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2758);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2764);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2766);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2767);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2768);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2769);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2770);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2771);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2772);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2773);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2774);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2775);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2776);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2777);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2778);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2779);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2780);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2781);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2782);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2783);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2784);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2786);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2787);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2788);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2789);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2790);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2791);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2793);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2795);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2796);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2797);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2798);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2799);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 204);
        }
    }
}
