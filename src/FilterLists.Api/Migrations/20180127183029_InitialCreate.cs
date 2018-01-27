using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "languages",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Iso6391 = table.Column<string>("NVARCHAR(2)", nullable: true),
                    Iso6392 = table.Column<string>("NVARCHAR(3)", nullable: true),
                    Iso6392B = table.Column<string>("NVARCHAR(3)", nullable: true),
                    Iso6392T = table.Column<string>("NVARCHAR(3)", nullable: true),
                    Iso6393 = table.Column<string>("NVARCHAR(3)", nullable: true),
                    LocalName = table.Column<string>("NVARCHAR(126)", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_languages", x => x.Id); });

            migrationBuilder.CreateTable(
                "licenses",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescriptionUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126) NOT NULL", nullable: true),
                    PermissiveAdaptation = table.Column<bool>(nullable: false),
                    PermissiveCommercial = table.Column<bool>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_licenses", x => x.Id); });

            migrationBuilder.CreateTable(
                "maintainers",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>("NVARCHAR(126)", nullable: true),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126) NOT NULL", nullable: true),
                    TwitterHandle = table.Column<string>("NVARCHAR(126)", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_maintainers", x => x.Id); });

            migrationBuilder.CreateTable(
                "rules",
                table => new
                {
                    Id = table.Column<int>("BIGINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Raw = table.Column<string>("NVARCHAR(2083) NOT NULL", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_rules", x => x.Id); });

            migrationBuilder.CreateTable(
                "software",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DownloadUrl = table.Column<string>("TEXT", nullable: true),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126) NOT NULL", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_software", x => x.Id); });

            migrationBuilder.CreateTable(
                "syntaxes",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefinitionUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126) NOT NULL", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_syntaxes", x => x.Id); });

            migrationBuilder.CreateTable(
                "filterlists",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>("TEXT", nullable: true),
                    DescriptionSourceUrl = table.Column<string>("TEXT", nullable: true),
                    DiscontinuedDate = table.Column<DateTime>(nullable: true),
                    DonateUrl = table.Column<string>("TEXT", nullable: true),
                    EmailAddress = table.Column<string>("NVARCHAR(126)", nullable: true),
                    ForumUrl = table.Column<string>("TEXT", nullable: true),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    IssuesUrl = table.Column<string>("TEXT", nullable: true),
                    LicenseId = table.Column<int>(nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false),
                    Name = table.Column<string>("NVARCHAR(126) NOT NULL", nullable: true),
                    SubmissionUrl = table.Column<string>("TEXT", nullable: true),
                    SyntaxId = table.Column<int>(nullable: true),
                    ViewUrl = table.Column<string>("TEXT NOT NULL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists", x => x.Id);
                    table.ForeignKey(
                        "FK_filterlists_licenses_LicenseId",
                        x => x.LicenseId,
                        "licenses",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_filterlists_syntaxes_SyntaxId",
                        x => x.SyntaxId,
                        "syntaxes",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "software_syntaxes",
                table => new
                {
                    SoftwareId = table.Column<int>(nullable: false),
                    SyntaxId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software_syntaxes", x => new {x.SoftwareId, x.SyntaxId});
                    table.ForeignKey(
                        "FK_software_syntaxes_software_SoftwareId",
                        x => x.SoftwareId,
                        "software",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_software_syntaxes_syntaxes_SyntaxId",
                        x => x.SyntaxId,
                        "syntaxes",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "filterlists_languages",
                table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_languages", x => new {x.FilterListId, x.LanguageId});
                    table.ForeignKey(
                        "FK_filterlists_languages_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_filterlists_languages_languages_LanguageId",
                        x => x.LanguageId,
                        "languages",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "filterlists_maintainers",
                table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    MaintainerId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_maintainers", x => new {x.FilterListId, x.MaintainerId});
                    table.ForeignKey(
                        "FK_filterlists_maintainers_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_filterlists_maintainers_maintainers_MaintainerId",
                        x => x.MaintainerId,
                        "maintainers",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "filterlists_rules",
                table => new
                {
                    FilterListId = table.Column<int>(nullable: false),
                    RuleId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_rules", x => new {x.FilterListId, x.RuleId});
                    table.ForeignKey(
                        "FK_filterlists_rules_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_filterlists_rules_rules_RuleId",
                        x => x.RuleId,
                        "rules",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "forks",
                table => new
                {
                    ForkFilterListId = table.Column<int>(nullable: false),
                    UpstreamFilterListId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forks", x => new {x.ForkFilterListId, x.UpstreamFilterListId});
                    table.ForeignKey(
                        "FK_forks_filterlists_ForkFilterListId",
                        x => x.ForkFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_forks_filterlists_UpstreamFilterListId",
                        x => x.UpstreamFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "merges",
                table => new
                {
                    MergeFilterListId = table.Column<int>(nullable: false),
                    UpstreamFilterListId = table.Column<int>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merges", x => new {x.MergeFilterListId, x.UpstreamFilterListId});
                    table.ForeignKey(
                        "FK_merges_filterlists_MergeFilterListId",
                        x => x.MergeFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_merges_filterlists_UpstreamFilterListId",
                        x => x.UpstreamFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_filterlists_LicenseId",
                "filterlists",
                "LicenseId");

            migrationBuilder.CreateIndex(
                "IX_filterlists_SyntaxId",
                "filterlists",
                "SyntaxId");

            migrationBuilder.CreateIndex(
                "IX_filterlists_languages_LanguageId",
                "filterlists_languages",
                "LanguageId");

            migrationBuilder.CreateIndex(
                "IX_filterlists_maintainers_MaintainerId",
                "filterlists_maintainers",
                "MaintainerId");

            migrationBuilder.CreateIndex(
                "IX_filterlists_rules_RuleId",
                "filterlists_rules",
                "RuleId");

            migrationBuilder.CreateIndex(
                "IX_forks_UpstreamFilterListId",
                "forks",
                "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                "IX_merges_UpstreamFilterListId",
                "merges",
                "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                "IX_software_syntaxes_SyntaxId",
                "software_syntaxes",
                "SyntaxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "filterlists_languages");

            migrationBuilder.DropTable(
                "filterlists_maintainers");

            migrationBuilder.DropTable(
                "filterlists_rules");

            migrationBuilder.DropTable(
                "forks");

            migrationBuilder.DropTable(
                "merges");

            migrationBuilder.DropTable(
                "software_syntaxes");

            migrationBuilder.DropTable(
                "languages");

            migrationBuilder.DropTable(
                "maintainers");

            migrationBuilder.DropTable(
                "rules");

            migrationBuilder.DropTable(
                "filterlists");

            migrationBuilder.DropTable(
                "software");

            migrationBuilder.DropTable(
                "licenses");

            migrationBuilder.DropTable(
                "syntaxes");
        }
    }
}