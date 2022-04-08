using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2873 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { null, "https://github.com/cjx82630/cjxlist/" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 281L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { null, "https://github.com/cjx82630/cjxlist/" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 300L,
                columns: new[] { "forum_url", "home_url", "issues_url" },
                values: new object[] { null, "https://github.com/easylist/easylistchina", "https://github.com/easylist/easylistchina/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2111L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { null, "https://github.com/cjx82630/cjxlist" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { "https://abpchina.org/forum/forum.php", "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 281L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { "https://abpchina.org/forum/forum.php", "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 300L,
                columns: new[] { "forum_url", "home_url", "issues_url" },
                values: new object[] { "https://abpchina.org/forum/forum.php", "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667", "https://github.com/easylist/easylistchina" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2111L,
                columns: new[] { "forum_url", "home_url" },
                values: new object[] { "https://abpchina.org/forum/forum.php", "https://abpchina.org/forum/forum.php?mod=viewthread&tid=29667" });
        }
    }
}
