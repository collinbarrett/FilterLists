using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class DropRuleRawUniqueIndexAndTrimming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_rules_Raw",
                "rules");

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "LONGTEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(768)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(768)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "LONGTEXT");

            migrationBuilder.CreateIndex(
                "IX_rules_Raw",
                "rules",
                "Raw",
                unique: true);
        }
    }
}