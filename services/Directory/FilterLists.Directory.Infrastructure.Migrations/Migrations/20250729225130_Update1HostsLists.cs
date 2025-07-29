using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Update1HostsLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Domains)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Domains)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1734,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", "https://github.com/badmojr/1Hosts" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1735,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", "https://github.com/badmojr/1Hosts" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1953,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Adblockers)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1954,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Adblockers)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1955,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", "https://github.com/badmojr/1Hosts" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (dnsmasq)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (dnsmasq)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", "https://github.com/badmojr/1Hosts" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2279,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Domains with wildcards)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2280,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", "https://github.com/badmojr/1Hosts", "1Hosts Lite (Domains with wildcards)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2281,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "Moderately strict - may introduce sporadic minor breaks, privacy-focused.", "https://github.com/badmojr/1Hosts" });

            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2751, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra", null, null, null },
                    { 2752, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Domains)", null, null, null },
                    { 2753, null, "Aggressive - stops emerging privacy threats dead! For power users who prioritize security above all.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Xtra (Adblockers)", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 309, 447 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 810, 840 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 811, 841 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 812, 842 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1953, 2026 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1954, 2027 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2001, 2097 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2002, 2098 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2279, 2419 },
                column: "Url",
                value: "https://badmojr.github.io/1Hosts/Lite/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2279, 2420 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2421 },
                column: "Url",
                value: "https://badmojr.github.io/1Hosts/Lite/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2422 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/wildcards.txt");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 309, 3086, (short)2, "https://badmojr.github.io/1Hosts/Lite/hosts.txt" },
                    { 309, 3087, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/hosts.txt" },
                    { 810, 3088, (short)2, "https://badmojr.github.io/1Hosts/Lite/domains.txt" },
                    { 810, 3089, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/domains.txt" },
                    { 1734, 3090, (short)2, "https://badmojr.github.io/1Hosts/Pro/hosts.txt" },
                    { 1734, 3091, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/hosts.txt" },
                    { 2751, 3092, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/hosts.txt" },
                    { 2751, 3093, (short)2, "https://badmojr.github.io/1Hosts/Xtra/hosts.txt" },
                    { 2751, 3094, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/hosts.txt" },
                    { 2752, 3095, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/domains.txt" },
                    { 2752, 3096, (short)2, "https://badmojr.github.io/1Hosts/Xtra/domains.txt" },
                    { 2752, 3097, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/domains.txt" },
                    { 2753, 3098, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Xtra/adblock.txt" },
                    { 2753, 3099, (short)2, "https://badmojr.github.io/1Hosts/Xtra/adblock.txt" },
                    { 2753, 3100, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Xtra/adblock.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 309, 3086 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 309, 3087 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 810, 3088 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 810, 3089 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1734, 3090 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1734, 3091 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2751, 3092 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2751, 3093 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2751, 3094 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2752, 3095 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2752, 3096 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2752, 3097 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2753, 3098 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2753, 3099 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2753, 3100 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2751);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2752);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2753);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Complete" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Complete (Domains)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Mini" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Mini (Domains)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1734,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1735,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1953,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Complete (Adblockers)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1954,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Mini (Adblockers)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1955,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Complete (dnsmasq)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Mini (dnsmasq)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2279,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Complete (Domains with wildcards)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2280,
                columns: new[] { "Description", "HomeUrl", "Name" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "1Hosts Mini (Domains with wildcards)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2281,
                columns: new[] { "Description", "HomeUrl" },
                values: new object[] { "A merged hosts file from a variety of other lists.", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 309, 447 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/complete/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 810, 840 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/complete/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 811, 841 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/mini/hosts.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 812, 842 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/mini/domains.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1953, 2026 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/complete/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1954, 2027 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/mini/adblock.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2001, 2097 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/complete/dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2002, 2098 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/mini/dnsmasq.conf");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2279, 2419 },
                column: "Url",
                value: "https://badmojr.github.io/1Hosts/complete/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2279, 2420 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/complete/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2421 },
                column: "Url",
                value: "https://badmojr.github.io/1Hosts/mini/wildcards.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2422 },
                column: "Url",
                value: "https://raw.githubusercontent.com/badmojr/1Hosts/master/mini/wildcards.txt");
        }
    }
}
