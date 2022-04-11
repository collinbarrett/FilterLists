using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2879 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 167L,
                column: "email_address",
                value: "piquark6046@proton.me");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 167L,
                column: "email_address",
                value: "piquark6046@protonmail.com");
        }
    }
}
