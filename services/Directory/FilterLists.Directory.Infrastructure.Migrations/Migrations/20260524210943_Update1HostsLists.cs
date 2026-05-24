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
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1734, 1794 });

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
                keyValues: new object[] { 1735, 1795 });

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
                keyValues: new object[] { 1955, 2028 });

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
                keyValues: new object[] { 2003, 2099 });

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
                keyValues: new object[] { 2281, 2423 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2281, 2424 });

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

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1734,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1735,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1955,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2003,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2281,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2759,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2760,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2761,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2762,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2763,
                column: "Description",
                value: "Discontinued. Replaced by 1Hosts (Xtra).");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1953, 3250, (short)2, "https://badmojr.github.io/1Hosts/Lite/adblock.txt" },
                    { 1953, 3251, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/adblock.txt" },
                    { 2001, 3252, (short)2, "https://badmojr.github.io/1Hosts/Lite/dnsmasq.conf" },
                    { 2001, 3253, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/dnsmasq.conf" },
                    { 2279, 3254, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Lite/wildcards.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1953, 3250 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1953, 3251 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2001, 3252 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2001, 3253 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2279, 3254 });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1734,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1735,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1955,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2003,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2281,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2759,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2760,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2761,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2762,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2763,
                column: "Description",
                value: "Moderately strict - may introduce sporadic minor breaks, privacy-focused.");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1734, 1794, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/hosts.txt" },
                    { 1734, 3090, (short)2, "https://badmojr.github.io/1Hosts/Pro/hosts.txt" },
                    { 1734, 3091, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/hosts.txt" },
                    { 1735, 1795, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/domains.txt" },
                    { 1735, 3152, (short)2, "https://badmojr.github.io/1Hosts/Pro/domains.txt" },
                    { 1735, 3153, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/domains.txt" },
                    { 1955, 2028, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/adblock.txt" },
                    { 1955, 3154, (short)2, "https://badmojr.github.io/1Hosts/Pro/adblock.txt" },
                    { 1955, 3155, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/adblock.txt" },
                    { 2003, 2099, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/dnsmasq.conf" },
                    { 2003, 3156, (short)2, "https://badmojr.github.io/1Hosts/Pro/dnsmasq.conf" },
                    { 2003, 3157, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/dnsmasq.conf" },
                    { 2281, 2423, (short)1, "https://badmojr.github.io/1Hosts/Pro/wildcards.txt" },
                    { 2281, 2424, (short)2, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Pro/wildcards.txt" },
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
                    { 2763, 3130, (short)3, "https://cdn.jsdelivr.net/gh/badmojr/1Hosts@master/Pro/snitch.rules" }
                });
        }
    }
}
