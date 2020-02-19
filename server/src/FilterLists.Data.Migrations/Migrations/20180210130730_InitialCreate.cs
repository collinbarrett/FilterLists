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
                    Id = table.Column<int>("SMALLINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    Iso6391 = table.Column<string>("VARCHAR(2)", nullable: true, defaultValueSql: "NULL"),
                    Iso6392 = table.Column<string>("VARCHAR(3)", nullable: true, defaultValueSql: "NULL"),
                    Iso6392B = table.Column<string>("VARCHAR(3)", nullable: true, defaultValueSql: "NULL"),
                    Iso6392T = table.Column<string>("VARCHAR(3)", nullable: true, defaultValueSql: "NULL"),
                    Iso6393 = table.Column<string>("VARCHAR(3)", nullable: true, defaultValueSql: "NULL"),
                    LocalName = table.Column<string>("VARCHAR(126)", nullable: true, defaultValueSql: "NULL"),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table => { table.PrimaryKey("PK_languages", x => x.Id); });

            migrationBuilder.CreateTable(
                "licenses",
                table => new
                {
                    Id = table.Column<int>("TINYINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    DescriptionUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)"),
                    PermissiveAdaptation = table.Column<bool>(),
                    PermissiveCommercial = table.Column<bool>()
                },
                constraints: table => { table.PrimaryKey("PK_licenses", x => x.Id); });

            migrationBuilder.CreateTable(
                "maintainers",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>("VARCHAR(126)", nullable: true, defaultValueSql: "NULL"),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)"),
                    TwitterHandle = table.Column<string>("VARCHAR(126)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table => { table.PrimaryKey("PK_maintainers", x => x.Id); });

            migrationBuilder.CreateTable(
                "rules",
                table => new
                {
                    Id = table.Column<int>("INT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    Raw = table.Column<string>("VARCHAR(8192)")
                },
                constraints: table => { table.PrimaryKey("PK_rules", x => x.Id); });

            migrationBuilder.CreateTable(
                "software",
                table => new
                {
                    Id = table.Column<int>("TINYINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    DownloadUrl = table.Column<string>("TEXT", nullable: true),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)")
                },
                constraints: table => { table.PrimaryKey("PK_software", x => x.Id); });

            migrationBuilder.CreateTable(
                "syntaxes",
                table => new
                {
                    Id = table.Column<int>("TINYINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    DefinitionUrl = table.Column<string>("TEXT", nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)")
                },
                constraints: table => { table.PrimaryKey("PK_syntaxes", x => x.Id); });

            migrationBuilder.CreateTable(
                "filterlists",
                table => new
                {
                    Id = table.Column<int>("SMALLINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>("TEXT", nullable: true),
                    DescriptionSourceUrl = table.Column<string>("TEXT", nullable: true),
                    DiscontinuedDate = table.Column<DateTime>(nullable: true),
                    DonateUrl = table.Column<string>("TEXT", nullable: true),
                    EmailAddress = table.Column<string>("VARCHAR(126)", nullable: true, defaultValueSql: "NULL"),
                    ForumUrl = table.Column<string>("TEXT", nullable: true),
                    HomeUrl = table.Column<string>("TEXT", nullable: true),
                    IssuesUrl = table.Column<string>("TEXT", nullable: true),
                    LicenseId = table.Column<int>(nullable: true),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    Name = table.Column<string>("VARCHAR(126)"),
                    PolicyUrl = table.Column<string>("TEXT", nullable: true),
                    SubmissionUrl = table.Column<string>("TEXT", nullable: true),
                    SyntaxId = table.Column<int>(nullable: true),
                    ViewUrl = table.Column<string>("TEXT", nullable: true)
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
                    SyntaxId = table.Column<int>(),
                    SoftwareId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software_syntaxes", x => new {x.SyntaxId, x.SoftwareId});
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
                    FilterListId = table.Column<int>(),
                    LanguageId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn)
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
                    FilterListId = table.Column<int>(),
                    MaintainerId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn)
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
                "forks",
                table => new
                {
                    ForkFilterListId = table.Column<int>(),
                    UpstreamFilterListId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn)
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
                    MergeFilterListId = table.Column<int>(),
                    UpstreamFilterListId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn)
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

            migrationBuilder.CreateTable(
                "snapshots",
                table => new
                {
                    Id = table.Column<int>("MEDIUMINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    FilterListId = table.Column<int>(),
                    HttpStatusCode = table.Column<string>("VARCHAR(3)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_snapshots", x => x.Id);
                    table.ForeignKey(
                        "FK_snapshots_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "snapshots_rules",
                table => new
                {
                    AddedBySnapshotId = table.Column<int>(),
                    RuleId = table.Column<int>(),
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP")
                                          .Annotation("MySql:ValueGenerationStrategy",
                                              MySqlValueGenerationStrategy.IdentityColumn),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP"),
                    RemovedBySnapshotId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_snapshots_rules", x => new {x.AddedBySnapshotId, x.RuleId});
                    table.ForeignKey(
                        "FK_snapshots_rules_snapshots_AddedBySnapshotId",
                        x => x.AddedBySnapshotId,
                        "snapshots",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_snapshots_rules_snapshots_RemovedBySnapshotId",
                        x => x.RemovedBySnapshotId,
                        "snapshots",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_snapshots_rules_rules_RuleId",
                        x => x.RuleId,
                        "rules",
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
                "IX_forks_UpstreamFilterListId",
                "forks",
                "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                "IX_merges_UpstreamFilterListId",
                "merges",
                "UpstreamFilterListId");

            migrationBuilder.CreateIndex(
                "IX_snapshots_FilterListId",
                "snapshots",
                "FilterListId");

            migrationBuilder.CreateIndex(
                "IX_snapshots_rules_RemovedBySnapshotId",
                "snapshots_rules",
                "RemovedBySnapshotId");

            migrationBuilder.CreateIndex(
                "IX_snapshots_rules_RuleId",
                "snapshots_rules",
                "RuleId");

            migrationBuilder.CreateIndex(
                "IX_software_syntaxes_SoftwareId",
                "software_syntaxes",
                "SoftwareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "filterlists_languages");

            migrationBuilder.DropTable(
                "filterlists_maintainers");

            migrationBuilder.DropTable(
                "forks");

            migrationBuilder.DropTable(
                "merges");

            migrationBuilder.DropTable(
                "snapshots_rules");

            migrationBuilder.DropTable(
                "software_syntaxes");

            migrationBuilder.DropTable(
                "languages");

            migrationBuilder.DropTable(
                "maintainers");

            migrationBuilder.DropTable(
                "snapshots");

            migrationBuilder.DropTable(
                "rules");

            migrationBuilder.DropTable(
                "software");

            migrationBuilder.DropTable(
                "filterlists");

            migrationBuilder.DropTable(
                "licenses");

            migrationBuilder.DropTable(
                "syntaxes");
        }
    }
}