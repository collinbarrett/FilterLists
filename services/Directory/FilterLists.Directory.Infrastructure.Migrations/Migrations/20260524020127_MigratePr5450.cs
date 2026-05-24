using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class MigratePr5450 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2471, (short)48 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2471, 162 });

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

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2471,
                columns: new[] { "Description", "HomeUrl", "IssuesUrl" },
                values: new object[] { "Dutch filterlist to use with uBlock Origin", "https://github.com/EasyDutch-uBlockOrigin/EasyDutch/", "https://github.com/EasyDutch-uBlockOrigin/EasyDutch/issues" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2679 },
                column: "Url",
                value: "https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2732 },
                column: "Url",
                value: "https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2798 },
                column: "Url",
                value: "https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2799 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2800 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2801 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2802 },
                column: "Url",
                value: "https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2803 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2804 },
                column: "Url",
                value: "https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutch/gh-pages/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2805 },
                column: "Url",
                value: "https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutchCDN/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2806 },
                column: "Url",
                value: "https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2807 },
                column: "Url",
                value: "https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutchCDN/main/EasyDutch.txt");

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 211, "easydutch@tech-web.aleeas.com", "EasyDutch", null, "https://github.com/EasyDutch-uBlockOrigin" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2471, 211 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2471, 211 });

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2471,
                columns: new[] { "Description", "HomeUrl", "IssuesUrl" },
                values: new object[] { "Dutch supplement for the Easylist filters to use with uBlock Origin", "https://github.com/EasyDutch-uBO/EasyDutch/", "https://github.com/EasyDutch-uBO/EasyDutch/issues" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[] { 2471, (short)48 });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2471, 162 });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2679 },
                column: "Url",
                value: "https://easydutch-ubo.github.io/EasyDutch/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2732 },
                column: "Url",
                value: "https://easydutchcdn.pages.dev/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2798 },
                column: "Url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2799 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutchCDN@main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2800 },
                column: "Url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutchCDN/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2801 },
                column: "Url",
                value: "https://easydutch.pages.dev/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2802 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutch@gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2803 },
                column: "Url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2804 },
                column: "Url",
                value: "https://easydutchcdn.pages.dev/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2805 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutchCDN@main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2806 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2471, 2807 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockFilters@main/EasyDutch.txt");

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2717, 3046, (short)2, "https://raw.githubusercontent.com/celenityy/BadBlock/main/wildcards-no-%2A/personal.txt" },
                    { 2718, 3047, (short)1, "https://badblock.celenity.dev/abp/whitelist.txt" },
                    { 2718, 3048, (short)2, "https://raw.githubusercontent.com/celenityy/BadBlock/main/whitelist.txt" },
                    { 2719, 3049, (short)1, "https://divested.dev/hosts-domains-wildcards" },
                    { 2720, 3050, (short)1, "https://divested.dev/hosts-domains" },
                    { 2721, 3051, (short)1, "https://divested.dev/hosts" },
                    { 2722, 3052, (short)1, "https://divested.dev/hosts-dnsmasq" },
                    { 2723, 3053, (short)1, "https://divested.dev/blocklists/Fingerprinting.ubl" },
                    { 2723, 3054, (short)2, "https://codeberg.org/divested/dnsbl/raw/branch/master/Fingerprinting.ubl" },
                    { 2723, 3055, (short)3, "https://gitlab.com/divested/dnsbl/-/raw/master/Fingerprinting.ubl" }
                });
        }
    }
}
