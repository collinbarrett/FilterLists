using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class addFilterListMaintainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_filterlists_maintainers_MaintainerId",
                table: "filterlists");

            migrationBuilder.DropIndex(
                name: "IX_filterlists_MaintainerId",
                table: "filterlists");

            migrationBuilder.DropColumn(
                name: "MaintainerId",
                table: "filterlists");

            migrationBuilder.CreateTable(
                name: "filterlists_maintainers",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "int", nullable: false),
                    MaintainerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_maintainers", x => new { x.FilterListId, x.MaintainerId });
                    table.ForeignKey(
                        name: "FK_filterlists_maintainers_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filterlists_maintainers_maintainers_MaintainerId",
                        column: x => x.MaintainerId,
                        principalTable: "maintainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_maintainers_MaintainerId",
                table: "filterlists_maintainers",
                column: "MaintainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filterlists_maintainers");

            migrationBuilder.AddColumn<int>(
                name: "MaintainerId",
                table: "filterlists",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_MaintainerId",
                table: "filterlists",
                column: "MaintainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_filterlists_maintainers_MaintainerId",
                table: "filterlists",
                column: "MaintainerId",
                principalTable: "maintainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
