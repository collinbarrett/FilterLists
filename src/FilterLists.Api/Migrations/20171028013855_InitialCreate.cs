using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Iso6391 = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true),
                    Iso6392 = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    Iso6392B = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    Iso6392T = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    Iso6393 = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true),
                    LocalName = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "maintainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true),
                    HomeUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: false),
                    TwitterHandle = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "software",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DownloadUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    HomeUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filterlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(4096)", maxLength: 4096, nullable: true),
                    DescriptionSourceUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    DonateUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: true),
                    ForumUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    HomeUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    IssuesUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true),
                    MaintainerId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "varchar(126)", maxLength: 126, nullable: false),
                    ViewUrl = table.Column<string>(type: "varchar(2083)", maxLength: 2083, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_filterlists_maintainers_MaintainerId",
                        column: x => x.MaintainerId,
                        principalTable: "maintainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filterlists_languages",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_languages", x => new { x.FilterListId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_filterlists_languages_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filterlists_languages_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filterlists_software",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_software", x => new { x.FilterListId, x.SoftwareId });
                    table.ForeignKey(
                        name: "FK_filterlists_software_filterlists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filterlists_software_software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_MaintainerId",
                table: "filterlists",
                column: "MaintainerId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_languages_LanguageId",
                table: "filterlists_languages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_software_SoftwareId",
                table: "filterlists_software",
                column: "SoftwareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filterlists_languages");

            migrationBuilder.DropTable(
                name: "filterlists_software");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "filterlists");

            migrationBuilder.DropTable(
                name: "software");

            migrationBuilder.DropTable(
                name: "maintainers");
        }
    }
}
