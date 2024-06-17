using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4366 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2673, null, "Block the bad! BadBlock's premier block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock (ABP)", null, null, null },
                    { 2674, null, "Block the bad! BadBlock's premier block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock (Wildcard Domains)", null, null, null },
                    { 2675, null, "Block the bad! BadBlock's premier block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock (Domains)", null, null, null },
                    { 2676, null, "BadBlock, but slimmer! BadBlock's lite block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock Lite (ABP)", null, null, null },
                    { 2677, null, "BadBlock, but slimmer! BadBlock's lite block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock Lite (Wildcard Domains)", null, null, null },
                    { 2678, null, "BadBlock, but slimmer! BadBlock's lite block list - Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock Lite (Domains)", null, null, null },
                    { 2679, null, "Complete coverage! Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware & toxic domains.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock+ (ABP)", null, null, null },
                    { 2680, null, "Complete coverage! Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware & toxic domains.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock+ (Wildcard Domains)", null, null, null },
                    { 2681, null, "Complete coverage! Blocks domains used for advertising, promotions, sponsorships, tracking, analytics, telemetry, annoyances, & more, as well as stalkerware & toxic domains.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock+ (Domains)", null, null, null },
                    { 2682, null, "Block Apple advertising, telemetry, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Apple (ABP)", null, null, null },
                    { 2683, null, "Block Apple advertising, telemetry, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Apple (Wildcard Domains)", null, null, null },
                    { 2684, null, "Block Apple advertising, telemetry, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Apple (Domains)", null, null, null },
                    { 2685, null, "Block Brave telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Brave (ABP)", null, null, null },
                    { 2686, null, "Block Brave telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Brave (Wildcard Domains)", null, null, null },
                    { 2687, null, "Block Brave telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Brave (Domains)", null, null, null },
                    { 2688, null, "Block toxic domains!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Crap (ABP)", null, null, null },
                    { 2689, null, "Block toxic domains!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Crap (Wildcard Domains)", null, null, null },
                    { 2690, null, "Block toxic domains!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Crap (Domains)", null, null, null },
                    { 2691, null, "Stop the people search!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Data Brokers (ABP)", null, null, null },
                    { 2692, null, "Stop the people search!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Data Brokers (Wildcard Domains)", null, null, null },
                    { 2693, null, "Stop the people search!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Data Brokers (Domains)", null, null, null },
                    { 2694, null, "Stop Digital Restrictions Management!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - DRM (ABP)", null, null, null },
                    { 2695, null, "Stop Digital Restrictions Management!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - DRM (Wildcard Domains)", null, null, null },
                    { 2696, null, "Stop Digital Restrictions Management!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - DRM (Domains)", null, null, null },
                    { 2697, null, "Block Google advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Google (ABP)", null, null, null },
                    { 2698, null, "Block Google advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Google (Wildcard Domains)", null, null, null },
                    { 2699, null, "Block Google advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Google (Domains)", null, null, null },
                    { 2700, null, "Close the Windows! Block Microsoft advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Microsoft (ABP)", null, null, null },
                    { 2701, null, "Close the Windows! Block Microsoft advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Microsoft (Wildcard Domains)", null, null, null },
                    { 2702, null, "Close the Windows! Block Microsoft advertising, tracking, promotions, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Microsoft (Domains)", null, null, null },
                    { 2703, null, "Block Mozilla telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Mozilla (ABP)", null, null, null },
                    { 2704, null, "Block Mozilla telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Mozilla (Wildcard Domains)", null, null, null },
                    { 2705, null, "Block Mozilla telemetry, analytics, advertising, sponsored content, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Mozilla (Domains)", null, null, null },
                    { 2706, null, "Block Big Brother!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "NSA Blocklist - Next Generation (ABP)", null, null, null },
                    { 2707, null, "Block Big Brother!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "NSA Blocklist - Next Generation (Wildcard Domains)", null, null, null },
                    { 2708, null, "Block Big Brother!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "NSA Blocklist - Next Generation (Domains)", null, null, null },
                    { 2709, null, "Block Roblox telemetry, analytics, advertising, tracking, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Roblox (ABP)", null, null, null },
                    { 2710, null, "Block Roblox telemetry, analytics, advertising, tracking, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Roblox (Wildcard Domains)", null, null, null },
                    { 2711, null, "Block Roblox telemetry, analytics, advertising, tracking, & more!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Roblox (Domains)", null, null, null },
                    { 2712, null, "Stop the spy!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Stalkerware (ABP)", null, null, null },
                    { 2713, null, "Stop the spy!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Stalkerware (Wildcard Domains)", null, null, null },
                    { 2714, null, "Stop the spy!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Stalkerware (Domains)", null, null, null },
                    { 2715, null, "BadBlock Personal Blocklist! Further improves privacy & reduces annoyances.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Personal (ABP)", null, null, null },
                    { 2716, null, "BadBlock Personal Blocklist! Further improves privacy & reduces annoyances.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Personal (Wildcard Domains)", null, null, null },
                    { 2717, null, "BadBlock Personal Blocklist! Further improves privacy & reduces annoyances.", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Personal (Domains)", null, null, null },
                    { 2718, null, "Allow the legitimate domains!", null, null, null, "https://codeberg.org/Magnesium1062/BadBlock", "https://codeberg.org/Magnesium1062/BadBlock/issues", 4, "BadBlock - Whitelist", null, null, null },
                    { 2719, null, "Supercharge your content blocker to increase privacy and security.", "https://divested.dev/pages/donate", null, null, "https://divested.dev/pages/dnsbl", "https://codeberg.org/divested/dnsbl/issues", 4, "Divested Combined Blocklist (Wildcard Domains)", null, null, null },
                    { 2720, null, "Supercharge your content blocker to increase privacy and security.", "https://divested.dev/pages/donate", null, null, "https://divested.dev/pages/dnsbl", "https://codeberg.org/divested/dnsbl/issues", 4, "Divested Combined Blocklist (Domains)", null, null, null },
                    { 2721, null, "Supercharge your content blocker to increase privacy and security.", "https://divested.dev/pages/donate", null, null, "https://divested.dev/pages/dnsbl", "https://codeberg.org/divested/dnsbl/issues", 4, "Divested Combined Blocklist (HOSTS)", null, null, null },
                    { 2722, null, "Supercharge your content blocker to increase privacy and security.", "https://divested.dev/pages/donate", null, null, "https://divested.dev/pages/dnsbl", "https://codeberg.org/divested/dnsbl/issues", 4, "Divested Combined Blocklist (dnsmasq)", null, null, null },
                    { 2723, null, "Supercharge your content blocker to increase privacy and security.", "https://divested.dev/pages/donate", null, null, "https://divested.dev/pages/dnsbl", "https://codeberg.org/divested/dnsbl/issues", 28, "Divested - Fingerprinting", null, null, null },
                    { 2724, null, "Blocklist of analytics and annoyances found by our own research (either discovery or found by collecting sources).", null, null, null, "https://github.com/ph00lt0/blocklist", "https://github.com/ph00lt0/blocklist/issues", 9, "Ph00lt0's Blocklist (ABP)", null, null, null },
                    { 2725, null, "Blocklist of analytics and annoyances found by our own research (either discovery or found by collecting sources).", null, null, null, "https://github.com/ph00lt0/blocklist", "https://github.com/ph00lt0/blocklist/issues", 9, "Ph00lt0's Blocklist (Little Snitch)", null, null, null },
                    { 2726, null, "Blocklist of analytics and annoyances found by our own research (either discovery or found by collecting sources).", null, null, null, "https://github.com/ph00lt0/blocklist", "https://github.com/ph00lt0/blocklist/issues", 9, "Ph00lt0's Blocklist (Unbound)", null, null, null },
                    { 2727, null, "Blocklist of analytics and annoyances found by our own research (either discovery or found by collecting sources).", null, null, null, "https://github.com/ph00lt0/blocklist", "https://github.com/ph00lt0/blocklist/issues", 9, "Ph00lt0's Blocklist (HOSTS)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[,]
                {
                    { 193, null, "BadBlock", null, "https://codeberg.org/Magnesium1062/BadBlock" },
                    { 194, null, "Divested Computing Group", null, "https://divested.dev/" },
                    { 195, null, "ph00lt0", null, "https://github.com/ph00lt0" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2673, 193 },
                    { 2674, 193 },
                    { 2675, 193 },
                    { 2676, 193 },
                    { 2677, 193 },
                    { 2678, 193 },
                    { 2679, 193 },
                    { 2680, 193 },
                    { 2681, 193 },
                    { 2682, 193 },
                    { 2683, 193 },
                    { 2684, 193 },
                    { 2685, 193 },
                    { 2686, 193 },
                    { 2687, 193 },
                    { 2688, 193 },
                    { 2689, 193 },
                    { 2690, 193 },
                    { 2691, 193 },
                    { 2692, 193 },
                    { 2693, 193 },
                    { 2694, 193 },
                    { 2695, 193 },
                    { 2696, 193 },
                    { 2697, 193 },
                    { 2698, 193 },
                    { 2699, 193 },
                    { 2700, 193 },
                    { 2701, 193 },
                    { 2702, 193 },
                    { 2703, 193 },
                    { 2704, 193 },
                    { 2705, 193 },
                    { 2706, 193 },
                    { 2707, 193 },
                    { 2708, 193 },
                    { 2709, 193 },
                    { 2710, 193 },
                    { 2711, 193 },
                    { 2712, 193 },
                    { 2713, 193 },
                    { 2714, 193 },
                    { 2715, 193 },
                    { 2716, 193 },
                    { 2717, 193 },
                    { 2718, 193 },
                    { 2719, 194 },
                    { 2720, 194 },
                    { 2721, 194 },
                    { 2722, 194 },
                    { 2723, 194 },
                    { 2724, 195 },
                    { 2725, 195 },
                    { 2726, 195 },
                    { 2727, 195 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2673, (short)3 },
                    { 2673, (short)6 },
                    { 2674, (short)16 },
                    { 2675, (short)2 },
                    { 2676, (short)3 },
                    { 2676, (short)6 },
                    { 2677, (short)16 },
                    { 2678, (short)2 },
                    { 2679, (short)3 },
                    { 2679, (short)6 },
                    { 2680, (short)16 },
                    { 2681, (short)2 },
                    { 2682, (short)3 },
                    { 2682, (short)6 },
                    { 2683, (short)16 },
                    { 2684, (short)2 },
                    { 2685, (short)3 },
                    { 2685, (short)6 },
                    { 2686, (short)16 },
                    { 2687, (short)2 },
                    { 2688, (short)3 },
                    { 2688, (short)6 },
                    { 2689, (short)16 },
                    { 2690, (short)2 },
                    { 2691, (short)3 },
                    { 2691, (short)6 },
                    { 2692, (short)16 },
                    { 2693, (short)2 },
                    { 2694, (short)3 },
                    { 2694, (short)6 },
                    { 2695, (short)16 },
                    { 2696, (short)2 },
                    { 2697, (short)3 },
                    { 2697, (short)6 },
                    { 2698, (short)16 },
                    { 2699, (short)2 },
                    { 2700, (short)3 },
                    { 2700, (short)6 },
                    { 2701, (short)16 },
                    { 2702, (short)2 },
                    { 2703, (short)3 },
                    { 2703, (short)6 },
                    { 2704, (short)16 },
                    { 2705, (short)2 },
                    { 2706, (short)3 },
                    { 2706, (short)6 },
                    { 2707, (short)16 },
                    { 2708, (short)2 },
                    { 2709, (short)3 },
                    { 2709, (short)6 },
                    { 2710, (short)16 },
                    { 2711, (short)2 },
                    { 2712, (short)3 },
                    { 2712, (short)6 },
                    { 2713, (short)16 },
                    { 2714, (short)2 },
                    { 2715, (short)3 },
                    { 2715, (short)6 },
                    { 2716, (short)16 },
                    { 2717, (short)2 },
                    { 2718, (short)3 },
                    { 2718, (short)6 },
                    { 2719, (short)16 },
                    { 2720, (short)2 },
                    { 2721, (short)1 },
                    { 2722, (short)20 },
                    { 2723, (short)3 },
                    { 2723, (short)6 },
                    { 2724, (short)3 },
                    { 2724, (short)6 },
                    { 2725, (short)18 },
                    { 2726, (short)24 },
                    { 2727, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2673, 3 },
                    { 2674, 3 },
                    { 2675, 3 },
                    { 2676, 3 },
                    { 2677, 3 },
                    { 2678, 3 },
                    { 2679, 3 },
                    { 2680, 3 },
                    { 2681, 3 },
                    { 2682, 3 },
                    { 2683, 3 },
                    { 2684, 3 },
                    { 2685, 3 },
                    { 2686, 3 },
                    { 2687, 3 },
                    { 2688, 15 },
                    { 2689, 15 },
                    { 2690, 15 },
                    { 2691, 3 },
                    { 2692, 3 },
                    { 2693, 3 },
                    { 2694, 15 },
                    { 2695, 15 },
                    { 2696, 15 },
                    { 2697, 3 },
                    { 2698, 3 },
                    { 2699, 3 },
                    { 2700, 3 },
                    { 2701, 3 },
                    { 2702, 3 },
                    { 2703, 3 },
                    { 2704, 3 },
                    { 2705, 3 },
                    { 2706, 3 },
                    { 2707, 3 },
                    { 2708, 3 },
                    { 2709, 3 },
                    { 2710, 3 },
                    { 2711, 3 },
                    { 2712, 3 },
                    { 2713, 3 },
                    { 2714, 3 },
                    { 2715, 3 },
                    { 2716, 3 },
                    { 2717, 3 },
                    { 2718, 10 },
                    { 2719, 3 },
                    { 2720, 3 },
                    { 2721, 3 },
                    { 2722, 3 },
                    { 2723, 3 },
                    { 2724, 3 },
                    { 2725, 3 },
                    { 2726, 3 },
                    { 2727, 3 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2673, 2957, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock.txt" },
                    { 2673, 2958, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock.txt" },
                    { 2674, 2959, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock.txt" },
                    { 2674, 2960, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock.txt" },
                    { 2675, 2961, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock.txt" },
                    { 2675, 2962, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock.txt" },
                    { 2676, 2963, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock_lite.txt" },
                    { 2676, 2964, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock_lite.txt" },
                    { 2677, 2965, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock_lite.txt" },
                    { 2677, 2966, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock_lite.txt" },
                    { 2678, 2967, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock_lite.txt" },
                    { 2678, 2968, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock_lite.txt" },
                    { 2679, 2969, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock_plus.txt" },
                    { 2679, 2970, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock_plus.txt" },
                    { 2680, 2971, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock_plus.txt" },
                    { 2680, 2972, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock_plus.txt" },
                    { 2681, 2973, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock_plus.txt" },
                    { 2681, 2974, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock_plus.txt" },
                    { 2682, 2975, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/apple.txt" },
                    { 2682, 2976, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/apple.txt" },
                    { 2683, 2977, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/apple.txt" },
                    { 2683, 2978, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/apple.txt" },
                    { 2684, 2979, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/apple.txt" },
                    { 2684, 2980, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/apple.txt" },
                    { 2685, 2981, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/brave.txt" },
                    { 2685, 2982, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/brave.txt" },
                    { 2686, 2983, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/brave.txt" },
                    { 2686, 2984, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/brave.txt" },
                    { 2687, 2985, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/brave.txt" },
                    { 2687, 2986, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/brave.txt" },
                    { 2688, 2987, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/crap.txt" },
                    { 2688, 2988, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/crap.txt" },
                    { 2689, 2989, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/crap.txt" },
                    { 2689, 2990, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/crap.txt" },
                    { 2690, 2991, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/crap.txt" },
                    { 2690, 2992, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/crap.txt" },
                    { 2691, 2993, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/data-brokers.txt" },
                    { 2691, 2994, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/data-brokers.txt" },
                    { 2692, 2995, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/data-brokers.txt" },
                    { 2692, 2996, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/data-brokers.txt" },
                    { 2693, 2997, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/data-brokers.txt" },
                    { 2693, 2998, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/data-brokers.txt" },
                    { 2694, 2999, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/drm.txt" },
                    { 2694, 3000, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/drm.txt" },
                    { 2695, 3001, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/drm.txt" },
                    { 2695, 3002, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/drm.txt" },
                    { 2696, 3003, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/drm.txt" },
                    { 2696, 3004, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/drm.txt" },
                    { 2697, 3005, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/google.txt" },
                    { 2697, 3006, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/google.txt" },
                    { 2698, 3007, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/google.txt" },
                    { 2698, 3008, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/google.txt" },
                    { 2699, 3009, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/google.txt" },
                    { 2699, 3010, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/google.txt" },
                    { 2700, 3011, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/microsoft.txt" },
                    { 2700, 3012, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/microsoft.txt" },
                    { 2701, 3013, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/microsoft.txt" },
                    { 2701, 3014, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/microsoft.txt" },
                    { 2702, 3015, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/microsoft.txt" },
                    { 2702, 3016, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/microsoft.txt" },
                    { 2703, 3017, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/mozilla.txt" },
                    { 2703, 3018, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/mozilla.txt" },
                    { 2704, 3019, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/mozilla.txt" },
                    { 2704, 3020, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/mozilla.txt" },
                    { 2705, 3021, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/mozilla.txt" },
                    { 2705, 3022, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/mozilla.txt" },
                    { 2706, 3023, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/nsa-blocklist-ng.txt" },
                    { 2706, 3024, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/nsa-blocklist-ng.txt" },
                    { 2707, 3025, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/nsa-blocklist-ng.txt" },
                    { 2707, 3026, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/nsa-blocklist-ng.txt" },
                    { 2708, 3027, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/nsa-blocklist-ng.txt" },
                    { 2708, 3028, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/nsa-blocklist-ng.txt" },
                    { 2709, 3029, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/roblox.txt" },
                    { 2709, 3030, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/roblox.txt" },
                    { 2710, 3031, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/roblox.txt" },
                    { 2710, 3032, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/roblox.txt" },
                    { 2711, 3033, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/roblox.txt" },
                    { 2711, 3034, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/roblox.txt" },
                    { 2712, 3035, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/stalkerware.txt" },
                    { 2712, 3036, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/stalkerware.txt" },
                    { 2713, 3037, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/stalkerware.txt" },
                    { 2713, 3038, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/stalkerware.txt" },
                    { 2714, 3039, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/stalkerware.txt" },
                    { 2714, 3040, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/stalkerware.txt" },
                    { 2715, 3041, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/personal.txt" },
                    { 2715, 3042, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/personal.txt" },
                    { 2716, 3043, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/personal.txt" },
                    { 2716, 3044, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-%2A/personal.txt" },
                    { 2717, 3045, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/personal.txt" },
                    { 2717, 3046, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-%2A/personal.txt" },
                    { 2718, 3047, (short)1, "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/whitelist.txt" },
                    { 2718, 3048, (short)2, "https://raw.githubusercontent.com/Retold3202/BadBlock/main/whitelist.txt" },
                    { 2719, 3049, (short)1, "https://divested.dev/hosts-domains-wildcards" },
                    { 2720, 3050, (short)1, "https://divested.dev/hosts-domains" },
                    { 2721, 3051, (short)1, "https://divested.dev/hosts" },
                    { 2722, 3052, (short)1, "https://divested.dev/hosts-dnsmasq" },
                    { 2723, 3053, (short)1, "https://divested.dev/blocklists/Fingerprinting.ubl" },
                    { 2723, 3054, (short)2, "https://codeberg.org/divested/dnsbl/raw/branch/master/Fingerprinting.ubl" },
                    { 2723, 3055, (short)3, "https://gitlab.com/divested/dnsbl/-/raw/master/Fingerprinting.ubl" },
                    { 2723, 3056, (short)4, "https://raw.githubusercontent.com/divestedcg/dnsbl/master/Fingerprinting.ubl" },
                    { 2724, 3057, (short)1, "https://raw.githubusercontent.com/ph00lt0/blocklists/master/blocklist.txt" },
                    { 2725, 3058, (short)1, "https://raw.githubusercontent.com/ph00lt0/blocklist/master/little-snitch-blocklist.lsrules" },
                    { 2726, 3059, (short)1, "https://raw.githubusercontent.com/ph00lt0/blocklists/master/unbound-blocklist.txt" },
                    { 2727, 3060, (short)1, "https://raw.githubusercontent.com/ph00lt0/blocklists/master/pihole-blocklist.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2673, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2674, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2675, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2676, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2677, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2678, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2679, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2680, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2681, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2682, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2683, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2684, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2685, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2686, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2687, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2688, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2689, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2690, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2691, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2692, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2693, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2694, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2695, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2696, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2697, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2698, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2699, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2700, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2701, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2702, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2703, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2704, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2705, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2706, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2707, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2708, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2709, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2710, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2711, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2712, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2713, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2714, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2715, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2716, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2717, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2718, 193 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2719, 194 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2720, 194 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2721, 194 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2722, 194 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2723, 194 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2724, 195 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2725, 195 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2726, 195 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2727, 195 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2673, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2673, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2674, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2675, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2676, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2676, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2677, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2678, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2679, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2679, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2680, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2681, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2682, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2682, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2683, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2684, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2685, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2685, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2686, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2687, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2688, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2688, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2689, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2690, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2691, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2691, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2692, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2693, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2694, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2694, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2695, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2696, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2697, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2697, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2698, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2699, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2700, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2700, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2701, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2702, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2703, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2703, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2704, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2705, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2706, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2706, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2707, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2708, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2709, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2709, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2710, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2711, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2712, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2712, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2713, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2714, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2715, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2715, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2716, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2717, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2718, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2718, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2719, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2720, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2721, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2722, (short)20 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2723, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2723, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2724, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2724, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2725, (short)18 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2726, (short)24 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2727, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2673, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2674, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2675, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2676, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2677, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2678, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2679, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2680, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2681, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2682, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2683, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2684, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2685, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2686, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2687, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2688, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2689, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2690, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2691, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2692, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2693, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2694, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2695, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2696, 15 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2697, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2698, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2699, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2700, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2701, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2702, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2703, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2704, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2705, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2706, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2707, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2708, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2709, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2710, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2711, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2712, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2713, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2714, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2715, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2716, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2717, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2718, 10 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2719, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2720, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2721, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2722, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2723, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2724, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2725, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2726, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2727, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2957 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2958 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2959 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2960 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2961 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2962 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2963 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2964 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2965 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2966 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2967 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2968 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2969 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2970 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2971 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2972 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2973 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2974 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2975 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2976 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2977 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2978 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2979 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2980 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2981 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2982 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2983 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2984 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2985 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2986 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2987 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2988 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2989 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2990 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2991 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2992 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2993 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2994 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2995 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2996 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2997 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2998 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 2999 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 3000 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3001 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3002 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3003 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3004 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3005 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3006 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3007 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3008 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3009 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3010 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3011 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3012 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3013 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3014 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3015 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3016 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3017 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3018 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3019 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3020 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3021 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3022 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3023 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3024 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3025 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3026 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3027 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3028 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3029 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3030 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3031 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3032 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3033 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3034 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3035 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3036 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3037 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3038 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3039 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3040 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3041 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3042 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3043 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3044 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3045 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3046 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3047 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3048 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2719, 3049 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2720, 3050 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2721, 3051 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2722, 3052 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2723, 3053 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2723, 3054 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2723, 3055 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2723, 3056 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2724, 3057 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2725, 3058 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2726, 3059 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2727, 3060 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2682);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2707);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2715);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2716);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2717);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2718);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2719);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2720);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2721);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2725);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2727);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 195);
        }
    }
}
