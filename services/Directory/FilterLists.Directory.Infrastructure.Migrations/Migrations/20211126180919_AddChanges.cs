using System;
using System.Text.Json;
using FilterLists.Directory.Domain.Aggregates;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class AddChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:aggregate_type", "filter_list,language,license,maintainer,software,syntax,tag");

            migrationBuilder.CreateTable(
                name: "changes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reason = table.Column<string>(type: "text", nullable: true),
                    submitted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    approved_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    rejected_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    rejected_reason = table.Column<string>(type: "text", nullable: true),
                    before = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    after = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    aggregate_type = table.Column<AggregateType>(type: "aggregate_type", nullable: false),
                    filter_list_id = table.Column<long>(type: "bigint", nullable: true),
                    language_id = table.Column<long>(type: "bigint", nullable: true),
                    license_id = table.Column<long>(type: "bigint", nullable: true),
                    maintainer_id = table.Column<long>(type: "bigint", nullable: true),
                    software_id = table.Column<long>(type: "bigint", nullable: true),
                    syntax_id = table.Column<long>(type: "bigint", nullable: true),
                    tag_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_changes", x => x.id);
                    table.ForeignKey(
                        name: "fk_changes_filter_lists_filter_list_id",
                        column: x => x.filter_list_id,
                        principalTable: "filter_lists",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "languages",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_licenses_license_id",
                        column: x => x.license_id,
                        principalTable: "licenses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_maintainers_maintainer_id",
                        column: x => x.maintainer_id,
                        principalTable: "maintainers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_software_software_id",
                        column: x => x.software_id,
                        principalTable: "software",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_syntaxes_syntax_id",
                        column: x => x.syntax_id,
                        principalTable: "syntaxes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_changes_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_changes_filter_list_id",
                table: "changes",
                column: "filter_list_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_language_id",
                table: "changes",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_license_id",
                table: "changes",
                column: "license_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_maintainer_id",
                table: "changes",
                column: "maintainer_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_software_id",
                table: "changes",
                column: "software_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_syntax_id",
                table: "changes",
                column: "syntax_id");

            migrationBuilder.CreateIndex(
                name: "ix_changes_tag_id",
                table: "changes",
                column: "tag_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "changes");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:aggregate_type", "filter_list,language,license,maintainer,software,syntax,tag");
        }
    }
}
