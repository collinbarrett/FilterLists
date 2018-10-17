using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    [UsedImplicitly]
    // ReSharper disable once InconsistentNaming
    public partial class addChatUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ChatUrl",
                "filterlists",
                "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ChatUrl",
                "filterlists");
        }
    }
}