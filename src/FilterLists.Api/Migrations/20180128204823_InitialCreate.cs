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
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Iso6391 = table.Column<string>(type: "NVARCHAR(2)", nullable: true),
                    Iso6392 = table.Column<string>(type: "NVARCHAR(3)", nullable: true),
                    Iso6392B = table.Column<string>(type: "NVARCHAR(3)", nullable: true),
                    Iso6392T = table.Column<string>(type: "NVARCHAR(3)", nullable: true),
                    Iso6393 = table.Column<string>(type: "NVARCHAR(3)", nullable: true),
                    LocalName = table.Column<string>(type: "NVARCHAR(126)", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescriptionUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126) NOT NULL", nullable: true),
                    PermissiveAdaptation = table.Column<bool>(nullable: false),
                    PermissiveCommercial = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "maintainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(type: "NVARCHAR(126)", nullable: true),
                    HomeUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126) NOT NULL", nullable: true),
                    TwitterHandle = table.Column<string>(type: "NVARCHAR(126)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "BIGINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Raw = table.Column<string>(type: "NVARCHAR(2083) NOT NULL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "software",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DownloadUrl = table.Column<string>(type: "TEXT", nullable: true),
                    HomeUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126) NOT NULL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "syntaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefinitionUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126) NOT NULL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_syntaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "filterlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DescriptionSourceUrl = table.Column<string>(type: "TEXT", nullable: true),
                    DiscontinuedDate = table.Column<DateTime>(nullable: true),
                    DonateUrl = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAddress = table.Column<string>(type: "NVARCHAR(126)", nullable: true),
                    ForumUrl = table.Column<string>(type: "TEXT", nullable: true),
                    HomeUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IssuesUrl = table.Column<string>(type: "TEXT", nullable: true),
                    LicenseId = table.Column<int>(nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(126) NOT NULL", nullable: true),
                    ScrapedDateUtc = table.Column<DateTime>(nullable: true),
                    SubmissionUrl = table.Column<string>(type: "TEXT", nullable: true),
                    SyntaxId = table.Column<int>(nullable: true),
                    UpdatedDateUtc = table.Column<DateTime>(nullable: true),
                    ViewUrl = table.Column<string>(type: "TEXT NOT NULL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_filterlists_licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_filterlists_syntaxes_SyntaxId",
                        column: x => x.SyntaxId,
                        principalTable: "syntaxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "software_syntaxes",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(nullable: false),
                    SyntaxId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
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

            migrationBuilder.CreateTable(
                name: "filterlists_languages",
                columns: table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
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
                name: "filterlists_maintainers",
                columns: table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    MaintainerId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
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
                name: "forks",
                columns: table => new
                {
                    ForkFilterListId = table.Column<int>(nullable: false),
                    UpstreamFilterListId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
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

            migrationBuilder.CreateTable(
                name: "merges",
                columns: table => new
                {
                    MergeFilterListId = table.Column<int>(nullable: false),
                    UpstreamFilterListId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merges", x => new { x.MergeFilterListId, x.UpstreamFilterListId });
                    table.ForeignKey(
                        name: "FK_merges_filterlists_MergeFilterListId",
                        column: x => x.MergeFilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_merges_filterlists_UpstreamFilterListId",
                        column: x => x.UpstreamFilterListId,
                        principalTable: "filterlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_LicenseId",
                table: "filterlists",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_SyntaxId",
                table: "filterlists",
                column: "SyntaxId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_languages_LanguageId",
                table: "filterlists_languages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_maintainers_MaintainerId",
                table: "filterlists_maintainers",
                column: "MaintainerId");

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_rules_RuleId",
                table: "filterlists_rules",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_forks_UpstreamFilterListId",
                table: "forks",
                column: "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_merges_UpstreamFilterListId",
                table: "merges",
                column: "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_software_syntaxes_SyntaxId",
                table: "software_syntaxes",
                column: "SyntaxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filterlists_languages");

            migrationBuilder.DropTable(
                name: "filterlists_maintainers");

            migrationBuilder.DropTable(
                name: "filterlists_rules");

            migrationBuilder.DropTable(
                name: "forks");

            migrationBuilder.DropTable(
                name: "merges");

            migrationBuilder.DropTable(
                name: "software_syntaxes");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "maintainers");

            migrationBuilder.DropTable(
                name: "rules");

            migrationBuilder.DropTable(
                name: "filterlists");

            migrationBuilder.DropTable(
                name: "software");

            migrationBuilder.DropTable(
                name: "licenses");

            migrationBuilder.DropTable(
                name: "syntaxes");
        }
    }
}
