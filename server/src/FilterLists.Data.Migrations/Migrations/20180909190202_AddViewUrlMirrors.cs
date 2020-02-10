using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddViewUrlMirrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ViewUrlMirror1",
                "filterlists",
                "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "ViewUrlMirror2",
                "filterlists",
                "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ViewUrlMirror1",
                "filterlists");

            migrationBuilder.DropColumn(
                "ViewUrlMirror2",
                "filterlists");
        }
    }
}