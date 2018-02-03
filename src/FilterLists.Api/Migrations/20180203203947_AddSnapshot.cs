using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class AddSnapshot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filterlists_rules");

            migrationBuilder.DropTable(
                name: "scrapes");

            migrationBuilder.CreateTable(
                name: "snapshots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "MEDIUMINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FilterListId = table.Column<int>(nullable: false),
                    HttpStatusCode = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_snapshots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_snapshots_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "snapshots_rules",
                columns: table => new
                {
                    SnapshotId = table.Column<int>(nullable: false),
                    RuleId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_snapshots_rules", x => new { x.SnapshotId, x.RuleId });
                    table.ForeignKey(
                        name: "FK_snapshots_rules_rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_snapshots_rules_snapshots_SnapshotId",
                        column: x => x.SnapshotId,
                        principalTable: "snapshots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_snapshots_FilterListId",
                table: "snapshots",
                column: "FilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_snapshots_rules_RuleId",
                table: "snapshots_rules",
                column: "RuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "snapshots_rules");

            migrationBuilder.DropTable(
                name: "snapshots");

            migrationBuilder.CreateTable(
                name: "filterlists_rules",
                columns: table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    RuleId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_rules", x => new { x.FilterListId, x.RuleId });
                    table.ForeignKey(
                        name: "FK_filterlists_rules_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filterlists_rules_rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scrapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FilterListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scrapes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scrapes_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_rules_RuleId",
                table: "filterlists_rules",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_scrapes_FilterListId",
                table: "scrapes",
                column: "FilterListId");
        }
    }
}
