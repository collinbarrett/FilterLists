using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddCantSnapshot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                "IsCompleted",
                "snapshots",
                "WasSuccessful");

            migrationBuilder.AddColumn<bool>(
                "CantSnapshot",
                "filterlists",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "CantSnapshot",
                "filterlists");

            migrationBuilder.RenameColumn(
                "WasSuccessful",
                "snapshots",
                "IsCompleted");
        }
    }
}