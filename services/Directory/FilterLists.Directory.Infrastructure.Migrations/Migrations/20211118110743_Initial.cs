using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Iso6391 = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Iso6391);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    PermitsModification = table.Column<bool>(type: "boolean", nullable: false),
                    PermitsDistribution = table.Column<bool>(type: "boolean", nullable: false),
                    PermitsCommercialUse = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maintainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    TwitterHandle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HomeUrl = table.Column<string>(type: "text", nullable: true),
                    DownloadUrl = table.Column<string>(type: "text", nullable: true),
                    SupportsAbpUrlScheme = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Syntaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syntaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilterLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LicenseId = table.Column<int>(type: "integer", nullable: true),
                    HomeUrl = table.Column<string>(type: "text", nullable: true),
                    OnionUrl = table.Column<string>(type: "text", nullable: true),
                    PolicyUrl = table.Column<string>(type: "text", nullable: true),
                    SubmissionUrl = table.Column<string>(type: "text", nullable: true),
                    IssuesUrl = table.Column<string>(type: "text", nullable: true),
                    ForumUrl = table.Column<string>(type: "text", nullable: true),
                    ChatUrl = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    DonateUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilterLists_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoftwareSyntaxes",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(type: "integer", nullable: false),
                    SyntaxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareSyntaxes", x => new { x.SoftwareId, x.SyntaxId });
                    table.ForeignKey(
                        name: "FK_SoftwareSyntaxes_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftwareSyntaxes_Syntaxes_SyntaxId",
                        column: x => x.SyntaxId,
                        principalTable: "Syntaxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependents",
                columns: table => new
                {
                    DependencyFilterListId = table.Column<int>(type: "integer", nullable: false),
                    DependentFilterListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependents", x => new { x.DependencyFilterListId, x.DependentFilterListId });
                    table.ForeignKey(
                        name: "FK_Dependents_FilterLists_DependencyFilterListId",
                        column: x => x.DependencyFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependents_FilterLists_DependentFilterListId",
                        column: x => x.DependentFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilterListLanguages",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "integer", nullable: false),
                    Iso6391 = table.Column<string>(type: "character(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterListLanguages", x => new { x.FilterListId, x.Iso6391 });
                    table.ForeignKey(
                        name: "FK_FilterListLanguages_FilterLists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilterListLanguages_Languages_Iso6391",
                        column: x => x.Iso6391,
                        principalTable: "Languages",
                        principalColumn: "Iso6391",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilterListMaintainers",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "integer", nullable: false),
                    MaintainerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterListMaintainers", x => new { x.FilterListId, x.MaintainerId });
                    table.ForeignKey(
                        name: "FK_FilterListMaintainers_FilterLists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilterListMaintainers_Maintainers_MaintainerId",
                        column: x => x.MaintainerId,
                        principalTable: "Maintainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilterListSyntaxes",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "integer", nullable: false),
                    SyntaxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterListSyntaxes", x => new { x.FilterListId, x.SyntaxId });
                    table.ForeignKey(
                        name: "FK_FilterListSyntaxes_FilterLists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilterListSyntaxes_Syntaxes_SyntaxId",
                        column: x => x.SyntaxId,
                        principalTable: "Syntaxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilterListTags",
                columns: table => new
                {
                    FilterListId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterListTags", x => new { x.FilterListId, x.TagId });
                    table.ForeignKey(
                        name: "FK_FilterListTags_FilterLists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilterListTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilterListViewUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilterListId = table.Column<int>(type: "integer", nullable: false),
                    SegmentNumber = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    Primariness = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterListViewUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilterListViewUrls_FilterLists_FilterListId",
                        column: x => x.FilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Forks",
                columns: table => new
                {
                    UpstreamFilterListId = table.Column<int>(type: "integer", nullable: false),
                    ForkFilterListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forks", x => new { x.UpstreamFilterListId, x.ForkFilterListId });
                    table.ForeignKey(
                        name: "FK_Forks_FilterLists_ForkFilterListId",
                        column: x => x.ForkFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forks_FilterLists_UpstreamFilterListId",
                        column: x => x.UpstreamFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Merges",
                columns: table => new
                {
                    IncludedInFilterListId = table.Column<int>(type: "integer", nullable: false),
                    IncludesFilterListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merges", x => new { x.IncludedInFilterListId, x.IncludesFilterListId });
                    table.ForeignKey(
                        name: "FK_Merges_FilterLists_IncludedInFilterListId",
                        column: x => x.IncludedInFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Merges_FilterLists_IncludesFilterListId",
                        column: x => x.IncludesFilterListId,
                        principalTable: "FilterLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_DependentFilterListId",
                table: "Dependents",
                column: "DependentFilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterListLanguages_Iso6391",
                table: "FilterListLanguages",
                column: "Iso6391");

            migrationBuilder.CreateIndex(
                name: "IX_FilterListMaintainers_MaintainerId",
                table: "FilterListMaintainers",
                column: "MaintainerId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterListSyntaxes_SyntaxId",
                table: "FilterListSyntaxes",
                column: "SyntaxId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterListTags_TagId",
                table: "FilterListTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterListViewUrls_FilterListId_SegmentNumber_Primariness",
                table: "FilterListViewUrls",
                columns: new[] { "FilterListId", "SegmentNumber", "Primariness" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FilterLists_LicenseId",
                table: "FilterLists",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_FilterLists_Name",
                table: "FilterLists",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forks_ForkFilterListId",
                table: "Forks",
                column: "ForkFilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Name",
                table: "Languages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_Name",
                table: "Licenses",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maintainers_Name",
                table: "Maintainers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Merges_IncludesFilterListId",
                table: "Merges",
                column: "IncludesFilterListId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_Name",
                table: "Software",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareSyntaxes_SyntaxId",
                table: "SoftwareSyntaxes",
                column: "SyntaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Syntaxes_Name",
                table: "Syntaxes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Name",
                table: "Tags",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependents");

            migrationBuilder.DropTable(
                name: "FilterListLanguages");

            migrationBuilder.DropTable(
                name: "FilterListMaintainers");

            migrationBuilder.DropTable(
                name: "FilterListSyntaxes");

            migrationBuilder.DropTable(
                name: "FilterListTags");

            migrationBuilder.DropTable(
                name: "FilterListViewUrls");

            migrationBuilder.DropTable(
                name: "Forks");

            migrationBuilder.DropTable(
                name: "Merges");

            migrationBuilder.DropTable(
                name: "SoftwareSyntaxes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Maintainers");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "FilterLists");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "Syntaxes");

            migrationBuilder.DropTable(
                name: "Licenses");
        }
    }
}
