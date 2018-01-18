using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class addSyntaxentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SyntaxId",
                table: "filterlists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "syntaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefinitionUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_syntaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "software_syntaxes",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    SyntaxId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software_syntaxes", x => new { x.SoftwareId, x.SyntaxId });
                    table.ForeignKey(
                        name: "FK_software_syntaxes_software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_software_syntaxes_syntaxes_SyntaxId",
                        column: x => x.SyntaxId,
                        principalTable: "syntaxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_SyntaxId",
                table: "filterlists",
                column: "SyntaxId");

            migrationBuilder.CreateIndex(
                name: "IX_software_syntaxes_SyntaxId",
                table: "software_syntaxes",
                column: "SyntaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_filterlists_syntaxes_SyntaxId",
                table: "filterlists",
                column: "SyntaxId",
                principalTable: "syntaxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_filterlists_syntaxes_SyntaxId",
                table: "filterlists");

            migrationBuilder.DropTable(
                name: "software_syntaxes");

            migrationBuilder.DropTable(
                name: "syntaxes");

            migrationBuilder.DropIndex(
                name: "IX_filterlists_SyntaxId",
                table: "filterlists");

            migrationBuilder.DropColumn(
                name: "SyntaxId",
                table: "filterlists");
        }
    }
}
