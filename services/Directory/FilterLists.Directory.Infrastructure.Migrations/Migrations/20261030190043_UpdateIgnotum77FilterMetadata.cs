using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIgnotum77FilterMetadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2471,
                column: "DonateUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2520,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { null, "https://github.com/Ignotum77/AdBlockFilters/", "https://github.com/Ignotum77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2521,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { null, "https://github.com/Ignotum77/AdBlockFilters/", "https://github.com/Ignotum77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2733 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Ignotum77/AdBlockFilters/main/dynamic rules.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2808 },
                column: "Url",
                value: "https://cdn.statically.io/gh/Ignotum77/AdBlockfilters/main/dynamic rules.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2809 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/Ignotum77/AdBlockfilters@main/dynamic rules.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2734 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Ignotum77/AdBlockFilters/main/my filters.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2810 },
                column: "Url",
                value: "https://cdn.statically.io/gh/Ignotum77/AdBlockfilters/main/my filters.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2811 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/Ignotum77/AdBlockfilters@main/my filters.txt");

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EmailAddress", "Name", "Url" },
                values: new object[] { "easydutch@tech-web.aleeas.com", "Ignotum77", "https://github.com/Ignotum77/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2471,
                column: "DonateUrl",
                value: "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2520,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC", "https://github.com/Nomes77/AdBlockFilters/", "https://github.com/Nomes77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2521,
                columns: new[] { "DonateUrl", "HomeUrl", "IssuesUrl" },
                values: new object[] { "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC", "https://github.com/Nomes77/AdBlockFilters/", "https://github.com/Nomes77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2733 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2808 },
                column: "Url",
                value: "https://cdn.statically.io/gh/Nomes77/AdBlockfilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2520, 2809 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockfilters@main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2734 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2810 },
                column: "Url",
                value: "https://cdn.statically.io/gh/Nomes77/AdBlockfilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2521, 2811 },
                column: "Url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockfilters@main/my filters");

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EmailAddress", "Name", "Url" },
                values: new object[] { "easydutch.adblock@gmail.com", "Nomes77", "https://github.com/Nomes77/" });
        }
    }
}
