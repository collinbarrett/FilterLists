using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2696 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                columns: new[] { "description", "name" },
                values: new object[] { "Medium mode for uBlock Origin when blocking 3p-frames and 3p-scripts", "Dynamic rules for uBo's medium mode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                columns: new[] { "description", "name" },
                values: new object[] { "Dynamic rules for uBlock Origin for 3p-frame unblocking only", "Dynamic rules (uBo)" });
        }
    }
}
