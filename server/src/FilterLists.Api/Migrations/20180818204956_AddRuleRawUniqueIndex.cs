using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleRawUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(768)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8192)");

            migrationBuilder.CreateIndex(
                "IX_rules_Raw",
                "rules",
                "Raw",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_rules_Raw",
                "rules");

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(8192)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(768)");
        }
    }
}