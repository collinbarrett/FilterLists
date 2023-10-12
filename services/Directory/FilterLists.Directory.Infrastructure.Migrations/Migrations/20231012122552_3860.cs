using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3860 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2804L },
                column: "url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2805L },
                column: "url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2806L },
                column: "url",
                value: "https://cdn.statically.io/gh/Nomes77/AdBlockFilters/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2807L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockFilters@main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2733L },
                column: "url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2808L },
                column: "url",
                value: "https://cdn.statically.io/gh/Nomes77/AdBlockfilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2809L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockfilters@main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2734L },
                column: "url",
                value: "https://raw.githubusercontent.com/Nomes77/AdBlockFilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2810L },
                column: "url",
                value: "https://cdn.statically.io/gh/Nomes77/AdBlockfilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2811L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/Nomes77/AdBlockfilters@main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/Nomes77/AdBlockFilters/", "https://github.com/Nomes77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2521L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/Nomes77/AdBlockFilters/", "https://github.com/Nomes77/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "name", "url" },
                values: new object[] { "Nomes77", "https://github.com/Nomes77/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2804L },
                column: "url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2805L },
                column: "url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2806L },
                column: "url",
                value: "https://cdn.statically.io/gh/BPower0036/AdBlockFilters/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2807L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockFilters@main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2733L },
                column: "url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2808L },
                column: "url",
                value: "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2809L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2734L },
                column: "url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2810L },
                column: "url",
                value: "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2811L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/my filters");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2521L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "name", "url" },
                values: new object[] { "BPower0036", "https://github.com/BPower0036/" });
        }
    }
}
