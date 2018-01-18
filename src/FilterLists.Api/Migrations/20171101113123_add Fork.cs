using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class addFork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "forks",
                columns: table => new
                {
                    ForkFilterListId = table.Column<int>(type: "int", nullable: false),
                    UpstreamFilterListId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forks", x => new { x.ForkFilterListId, x.UpstreamFilterListId });
                    table.ForeignKey(
                        name: "FK_forks_filterlists_ForkFilterListId",
                        column: x => x.ForkFilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_forks_filterlists_UpstreamFilterListId",
                        column: x => x.UpstreamFilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_forks_UpstreamFilterListId",
                table: "forks",
                column: "UpstreamFilterListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "forks");
        }
    }
}
