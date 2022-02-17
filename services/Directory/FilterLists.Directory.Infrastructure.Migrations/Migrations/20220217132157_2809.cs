using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2809 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 16L, 3L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 16L, 5L });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "description", "license_id" },
                values: new object[] { "Filter that enables removing of ads and anti-adblock scripts from websites with Korean content.", 4L });

            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "name", "url" },
                values: new object[] { "RAIDEN", "https://github.com/Raiden-Ei" });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 167L, "piquark6046@protonmail.com", true, "PiQuark6046", null, "https://github.com/piquark6046" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 16L, 167L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 16L, 167L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 16L, 5L });

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 167L);

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 16L, 3L });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "description", "license_id" },
                values: new object[] { "Filter that enables removing of ads, trackers, and various scripts from websites with Korean content.", 8L });

            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "name", "url" },
                values: new object[] { "SlowMemory", "https://github.com/SlowMemory" });
        }
    }
}
