using FilterLists.Api.Migrations.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddRuleRawIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                "IX_rules_Raw",
                "rules",
                "Raw",
                10); //191);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                "IX_rules_Raw",
                "rules");
        }
    }
}