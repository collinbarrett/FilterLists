using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddScrapes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "rules");

            migrationBuilder.DropColumn(
                "ScrapedDateUtc",
                "filterlists");

            migrationBuilder.DropColumn(
                "UpdatedDateUtc",
                "filterlists");

            migrationBuilder.AlterColumn<string>(
                "ViewUrl",
                "filterlists",
                "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT NOT NULL",
                oldNullable: true);

            migrationBuilder.CreateTable(
                "scrapes",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FilterListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scrapes", x => x.Id);
                    table.ForeignKey(
                        "FK_scrapes_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_scrapes_FilterListId",
                "scrapes",
                "FilterListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "scrapes");

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "rules",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                "ViewUrl",
                "filterlists",
                "TEXT NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                "ScrapedDateUtc",
                "filterlists",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                "UpdatedDateUtc",
                "filterlists",
                nullable: true);
        }
    }
}