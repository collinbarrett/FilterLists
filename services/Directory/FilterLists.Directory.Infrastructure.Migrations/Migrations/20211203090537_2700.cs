using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2700 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "id", "filter_list_id", "primariness", "url" },
                values: new object[,]
                {
                    { 2798L, 2471L, (short)3, "https://combinatronics.io/BPower0036/AdBlockFilters/main/easydutch.txt" },
                    { 2799L, 2471L, (short)4, "https://cdn.statically.io/gh/BPower0036/AdBlockFilters/main/easydutch.txt" },
                    { 2800L, 2471L, (short)5, "https://cdn.statically.io/gl/BPower0036/AdBlockFilters/main/easydutch.txt" },
                    { 2801L, 2471L, (short)6, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockFilters@main/easydutch.txt" },
                    { 2802L, 2520L, (short)2, "https://gitlab.com/BPower0036/AdBlockFilters/-/raw/main/dynamic rules" },
                    { 2803L, 2520L, (short)3, "https://combinatronics.io/BPower0036/AdBlockfilters/main/dynamic rules" },
                    { 2804L, 2520L, (short)4, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules" },
                    { 2805L, 2520L, (short)5, "https://cdn.statically.io/gl/BPower0036/AdBlockFilters/main/dynamic rules" },
                    { 2806L, 2520L, (short)6, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules" },
                    { 2807L, 2521L, (short)2, "https://gitlab.com/BPower0036/AdBlockFilters/-/raw/main/my filters" },
                    { 2808L, 2521L, (short)3, "https://combinatronics.io/BPower0036/AdBlockfilters/main/my filters" },
                    { 2809L, 2521L, (short)4, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/my filters" },
                    { 2810L, 2521L, (short)5, "https://cdn.statically.io/gl/BPower0036/AdBlockFilters/main/my filters" },
                    { 2811L, 2521L, (short)6, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/my filters" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2798L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2799L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2800L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2801L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2802L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2803L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2804L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2805L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2806L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2807L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2808L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2809L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2810L);

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumn: "id",
                keyValue: 2811L);
        }
    }
}
