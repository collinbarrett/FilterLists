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
                name: "languages",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    iso6391 = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "licenses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    url = table.Column<string>(type: "text", nullable: true),
                    permits_modification = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    permits_distribution = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    permits_commercial_use = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_licenses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "maintainers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    url = table.Column<string>(type: "text", nullable: true),
                    email_address = table.Column<string>(type: "text", nullable: true),
                    twitter_handle = table.Column<string>(type: "text", nullable: true),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_maintainers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "software",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    home_url = table.Column<string>(type: "text", nullable: true),
                    download_url = table.Column<string>(type: "text", nullable: true),
                    supports_abp_url_scheme = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_software", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "syntaxes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_syntaxes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filter_lists",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    license_id = table.Column<long>(type: "bigint", nullable: false, defaultValue: 5L),
                    home_url = table.Column<string>(type: "text", nullable: true),
                    onion_url = table.Column<string>(type: "text", nullable: true),
                    policy_url = table.Column<string>(type: "text", nullable: true),
                    submission_url = table.Column<string>(type: "text", nullable: true),
                    issues_url = table.Column<string>(type: "text", nullable: true),
                    forum_url = table.Column<string>(type: "text", nullable: true),
                    chat_url = table.Column<string>(type: "text", nullable: true),
                    email_address = table.Column<string>(type: "text", nullable: true),
                    donate_url = table.Column<string>(type: "text", nullable: true),
                    is_approved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_lists", x => x.id);
                    table.ForeignKey(
                        name: "fk_filter_lists_licenses_license_id",
                        column: x => x.license_id,
                        principalTable: "licenses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "software_syntaxes",
                columns: table => new
                {
                    software_id = table.Column<long>(type: "bigint", nullable: false),
                    syntax_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_software_syntaxes", x => new { x.software_id, x.syntax_id });
                    table.ForeignKey(
                        name: "fk_software_syntaxes_software_software_id",
                        column: x => x.software_id,
                        principalTable: "software",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_software_syntaxes_syntaxes_syntax_id",
                        column: x => x.syntax_id,
                        principalTable: "syntaxes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dependents",
                columns: table => new
                {
                    dependency_filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    dependent_filter_list_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dependents", x => new { x.dependency_filter_list_id, x.dependent_filter_list_id });
                    table.ForeignKey(
                        name: "fk_dependents_filter_lists_dependency_filter_list_id",
                        column: x => x.dependency_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dependents_filter_lists_dependent_filter_list_id",
                        column: x => x.dependent_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filter_list_languages",
                columns: table => new
                {
                    filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    language_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_list_languages", x => new { x.filter_list_id, x.language_id });
                    table.ForeignKey(
                        name: "fk_filter_list_languages_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_filter_list_languages_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filter_list_maintainers",
                columns: table => new
                {
                    filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    maintainer_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_list_maintainers", x => new { x.filter_list_id, x.maintainer_id });
                    table.ForeignKey(
                        name: "fk_filter_list_maintainers_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_filter_list_maintainers_maintainers_maintainer_id",
                        column: x => x.maintainer_id,
                        principalTable: "maintainers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filter_list_syntaxes",
                columns: table => new
                {
                    filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    syntax_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_list_syntaxes", x => new { x.filter_list_id, x.syntax_id });
                    table.ForeignKey(
                        name: "fk_filter_list_syntaxes_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_filter_list_syntaxes_syntaxes_syntax_id",
                        column: x => x.syntax_id,
                        principalTable: "syntaxes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filter_list_tags",
                columns: table => new
                {
                    filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    tag_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_list_tags", x => new { x.filter_list_id, x.tag_id });
                    table.ForeignKey(
                        name: "fk_filter_list_tags_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_filter_list_tags_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filter_list_view_urls",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    segment_number = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    primariness = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_filter_list_view_urls", x => x.id);
                    table.ForeignKey(
                        name: "fk_filter_list_view_urls_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "forks",
                columns: table => new
                {
                    upstream_filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    fork_filter_list_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_forks", x => new { x.upstream_filter_list_id, x.fork_filter_list_id });
                    table.ForeignKey(
                        name: "fk_forks_filter_lists_fork_filter_list_id",
                        column: x => x.fork_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_forks_filter_lists_upstream_filter_list_id",
                        column: x => x.upstream_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "merges",
                columns: table => new
                {
                    included_in_filter_list_id = table.Column<long>(type: "bigint", nullable: false),
                    includes_filter_list_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_merges", x => new { x.included_in_filter_list_id, x.includes_filter_list_id });
                    table.ForeignKey(
                        name: "fk_merges_filter_lists_included_in_filter_list_id",
                        column: x => x.included_in_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_merges_filter_lists_includes_filter_list_id",
                        column: x => x.includes_filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_dependents_dependent_filter_list_id",
                table: "dependents",
                column: "dependent_filter_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_list_languages_language_id",
                table: "filter_list_languages",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_list_maintainers_maintainer_id",
                table: "filter_list_maintainers",
                column: "maintainer_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_list_syntaxes_syntax_id",
                table: "filter_list_syntaxes",
                column: "syntax_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_list_tags_tag_id",
                table: "filter_list_tags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_list_view_urls_filter_list_id_segment_number_primari",
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "segment_number", "primariness" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_filter_lists_license_id",
                table: "filter_lists",
                column: "license_id");

            migrationBuilder.CreateIndex(
                name: "ix_filter_lists_name",
                table: "filter_lists",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_forks_fork_filter_list_id",
                table: "forks",
                column: "fork_filter_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_languages_iso6391",
                table: "languages",
                column: "iso6391",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_languages_name",
                table: "languages",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_licenses_name",
                table: "licenses",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_maintainers_name",
                table: "maintainers",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_merges_includes_filter_list_id",
                table: "merges",
                column: "includes_filter_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_software_name",
                table: "software",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_software_syntaxes_syntax_id",
                table: "software_syntaxes",
                column: "syntax_id");

            migrationBuilder.CreateIndex(
                name: "ix_syntaxes_name",
                table: "syntaxes",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_tags_name",
                table: "tags",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dependents");

            migrationBuilder.DropTable(
                name: "filter_list_languages");

            migrationBuilder.DropTable(
                name: "filter_list_maintainers");

            migrationBuilder.DropTable(
                name: "filter_list_syntaxes");

            migrationBuilder.DropTable(
                name: "filter_list_tags");

            migrationBuilder.DropTable(
                name: "filter_list_view_urls");

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
                name: "tags");

            migrationBuilder.DropTable(
                name: "filter_lists");

            migrationBuilder.DropTable(
                name: "software");

            migrationBuilder.DropTable(
                name: "syntaxes");

            migrationBuilder.DropTable(
                name: "licenses");
        }
    }
}
