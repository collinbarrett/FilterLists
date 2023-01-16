using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _3389 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2802L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2803L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2804L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2805L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2807L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2808L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2732L },
                column: "url",
                value: "https://easydutch-ubo.github.io/EasyDutchCDN/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2798L },
                column: "url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2799L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutch@gh-pages/EasyDutch.txt");

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
                keyValues: new object[] { 2520L, 2806L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)2, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2809L },
                column: "primariness",
                value: (short)2);

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
                    { 2471L, 2802L, (short)7, "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutchCDN@main/EasyDutch.txt" },
                    { 2471L, 2803L, (short)8, "https://combinatronics.io/EasyDutch-uBO/EasyDutchCDN/main/EasyDutch.txt" },
                    { 2471L, 2804L, (short)9, "https://raw.githubusercontent.com/BPower0036/AdBlockFilters/main/EasyDutch.txt" },
                    { 2471L, 2805L, (short)10, "https://cdn.statically.io/gh/BPower0036/AdBlockFilters/main/EasyDutch.txt" },
                    { 2520L, 2807L, (short)3, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules" },
                    { 2520L, 2808L, (short)4, "https://combinatronics.io/BPower0036/AdBlockfilters/main/dynamic rules" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2802L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2803L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2804L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2805L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2807L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2808L });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2732L },
                column: "url",
                value: "https://gitlab.com/BPower0036/EasyDutch/-/raw/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2798L },
                column: "url",
                value: "https://combinatronics.io/EasyDutch-uBO/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2799L },
                column: "url",
                value: "https://cdn.statically.io/gh/EasyDutch-uBO/EasyDutch/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2800L },
                column: "url",
                value: "https://cdn.statically.io/gl/BPower0036/EasyDutch/raw/gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2471L, 2801L },
                column: "url",
                value: "https://cdn.jsdelivr.net/gh/EasyDutch-uBO/EasyDutch@gh-pages/EasyDutch.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2520L, 2806L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)6, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/dynamic rules" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2809L },
                column: "primariness",
                value: (short)4);

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2810L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)5, "https://cdn.statically.io/gl/BPower0036/AdBlockFilters/main/my filters" });

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2521L, 2811L },
                columns: new[] { "primariness", "url" },
                values: new object[] { (short)6, "https://cdn.jsdelivr.net/gh/BPower0036/AdBlockfilters@main/my filters" });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "segment_number", "url" },
                values: new object[,]
                {
                    { 2520L, 2802L, (short)2, (short)0, "https://gitlab.com/BPower0036/AdBlockFilters/-/raw/main/dynamic rules" },
                    { 2520L, 2803L, (short)3, (short)0, "https://combinatronics.io/BPower0036/AdBlockfilters/main/dynamic rules" },
                    { 2520L, 2804L, (short)4, (short)0, "https://cdn.statically.io/gh/BPower0036/AdBlockfilters/main/dynamic rules" },
                    { 2520L, 2805L, (short)5, (short)0, "https://cdn.statically.io/gl/BPower0036/AdBlockFilters/main/dynamic rules" },
                    { 2521L, 2807L, (short)2, (short)0, "https://gitlab.com/BPower0036/AdBlockFilters/-/raw/main/my filters" },
                    { 2521L, 2808L, (short)3, (short)0, "https://combinatronics.io/BPower0036/AdBlockfilters/main/my filters" }
                });
        }
    }
}
