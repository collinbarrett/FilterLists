using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class addLicense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicenseId",
                table: "filterlists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescriptionUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: false),
                    PermissiveRedistribution = table.Column<bool>(type: "bit", nullable: false),
                    PermissiveUsage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licenses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_LicenseId",
                table: "filterlists",
                column: "LicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_filterlists_licenses_LicenseId",
                table: "filterlists",
                column: "LicenseId",
                principalTable: "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_filterlists_licenses_LicenseId",
                table: "filterlists");

            migrationBuilder.DropTable(
                name: "licenses");

            migrationBuilder.DropIndex(
                name: "IX_filterlists_LicenseId",
                table: "filterlists");

            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "filterlists");
        }
    }
}
