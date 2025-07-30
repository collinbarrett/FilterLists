using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class FixBadBlockUrlsConstraintViolation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2957 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2958 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2959 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2960 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2961 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2962 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2963 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2964 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2965 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2966 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2967 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2968 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2969 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2970 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2971 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2972 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2973 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2974 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2975 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2976 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2977 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2978 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2979 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2980 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2981 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2982 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2983 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2984 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2985 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2986 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2987 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2988 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2989 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2990 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2991 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2992 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2993 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2994 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2995 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2996 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2997 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2998 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 2999 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 3000 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3001 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3002 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3003 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3004 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3005 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3006 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3007 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3008 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3009 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3010 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3011 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3012 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3013 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3014 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3015 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3016 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3017 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3018 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3019 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3020 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3021 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3022 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3023 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3024 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3025 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3026 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3027 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3028 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3029 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3030 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3031 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3032 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3033 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3034 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3035 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/monitoring.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3036 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3037 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/monitoring.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3038 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-*/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3039 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/monitoring.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3040 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-*/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3041 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3042 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/abp/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3043 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-star/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3044 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3045 },
                column: "Url",
                value: "https://badblock.celenity.dev/wildcards-no-star/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3046 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3047 },
                column: "Url",
                value: "https://badblock.celenity.dev/abp/whitelist.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3048 },
                column: "Url",
                value: "https://raw.githubusercontent.com/celenityy/BadBlock/main/whitelist.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2957 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2673, 2958 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2959 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2674, 2960 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2961 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2675, 2962 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2963 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2676, 2964 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2965 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2677, 2966 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2967 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2678, 2968 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock_lite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2969 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2679, 2970 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2971 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2680, 2972 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2973 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2681, 2974 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/badblock_plus.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2975 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2682, 2976 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2977 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2683, 2978 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2979 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2684, 2980 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/apple.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2981 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2685, 2982 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2983 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2686, 2984 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2985 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2687, 2986 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/brave.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2987 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2688, 2988 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2989 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2689, 2990 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2991 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2690, 2992 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/crap.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2993 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2691, 2994 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2995 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2692, 2996 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2997 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2693, 2998 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/data-brokers.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 2999 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2694, 3000 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3001 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2695, 3002 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3003 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2696, 3004 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/drm.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3005 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2697, 3006 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3007 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2698, 3008 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3009 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2699, 3010 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/google.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3011 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2700, 3012 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3013 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2701, 3014 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3015 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2702, 3016 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/microsoft.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3017 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2703, 3018 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3019 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2704, 3020 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3021 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2705, 3022 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/mozilla.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3023 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2706, 3024 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3025 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2707, 3026 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3027 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2708, 3028 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/nsa-blocklist-ng.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3029 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2709, 3030 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3031 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2710, 3032 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3033 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2711, 3034 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/roblox.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3035 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2712, 3036 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3037 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2713, 3038 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-*/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3039 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2714, 3040 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-*/stalkerware.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3041 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/abp/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2715, 3042 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/abp/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3043 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2716, 3044 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3045 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/wildcards-no-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2717, 3046 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/wildcards-no-%2A/personal.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3047 },
                column: "Url",
                value: "https://codeberg.org/Magnesium1062/BadBlock/raw/branch/main/whitelist.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2718, 3048 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Retold3202/BadBlock/main/whitelist.txt");
        }
    }
}
