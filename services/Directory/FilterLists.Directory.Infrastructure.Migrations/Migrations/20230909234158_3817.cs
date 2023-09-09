using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3817 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2459L, 2664L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/data/combined_disguised_trackers.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2460L, 2665L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/data/combined_disguised_trackers_justdomains.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2461L, 2666L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/data/combined_original_trackers.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2459L, 2664L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_disguised_trackers.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2460L, 2665L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_disguised_trackers_justdomains.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2461L, 2666L },
                column: "url",
                value: "https://raw.githubusercontent.com/AdguardTeam/cname-trackers/master/combined_original_trackers.txt");
        }
    }
}
