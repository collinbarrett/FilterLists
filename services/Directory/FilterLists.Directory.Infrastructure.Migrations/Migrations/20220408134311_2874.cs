using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2874 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 98L,
                column: "url",
                value: "https://github.com/easylist/easylistchina");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 98L,
                column: "url",
                value: "https://abpchina.org/forum/");
        }
    }
}
