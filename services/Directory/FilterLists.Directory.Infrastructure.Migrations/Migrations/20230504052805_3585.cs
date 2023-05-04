using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3585 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2806L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2807L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2809L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2732L },
                column: "url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2800L },
                column: "url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2801L },
                column: "url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2802L },
                column: "url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutchCDN/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2803L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutchCDN@main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2805L },
                column: "url",
                value: "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/EasyDutch.all.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2808L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)2, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2810L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)2, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/my filters" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2811L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)3, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/my filters" });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2471L, 2806L, (short)11, "https://cdn.statically.io/gh/BPower0036/AdBlockFilters/main/EasyDutch.all.txt" },
                    { 2471L, 2807L, (short)12, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockFilters@main/EasyDutch.all.txt" },
                    { 2520L, 2809L, (short)3, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2806L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2807L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2809L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2732L },
                column: "url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2800L },
                column: "url",
                value: "https://combinatronics.io/EasyDutch-uBO/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2801L },
                column: "url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutchCDN/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2802L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutchCDN@main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2803L },
                column: "url",
                value: "https://combinatronics.io/EasyDutch-uBO/EasyDutchCDN/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2805L },
                column: "url",
                value: "https://cdn.statically.io/gh/BPower0036/AdBlockFilters/main/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2808L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)4, "https://combinatronics.io/BPower0036/AdBlockfilters/main/dynamic rules" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2810L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)3, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/my filters" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2811L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)4, "https://combinatronics.io/BPower0036/AdBlockfilters/main/my filters" });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2520L, 2806L, (short)2, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules" },
                    { 2520L, 2807L, (short)3, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules" },
                    { 2521L, 2809L, (short)2, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/my filters" }
                });
        }
    }
}
