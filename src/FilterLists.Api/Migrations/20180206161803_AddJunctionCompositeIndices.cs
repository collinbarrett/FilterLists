using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class AddJunctionCompositeIndices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_software_syntaxes_SoftwareId_SyntaxId",
                table: "software_syntaxes",
                columns: new[] { "SoftwareId", "SyntaxId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_snapshots_rules_SnapshotId_RuleId",
                table: "snapshots_rules",
                columns: new[] { "SnapshotId", "RuleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_merges_MergeFilterListId_UpstreamFilterListId",
                table: "merges",
                columns: new[] { "MergeFilterListId", "UpstreamFilterListId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_forks_ForkFilterListId_UpstreamFilterListId",
                table: "forks",
                columns: new[] { "ForkFilterListId", "UpstreamFilterListId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_maintainers_FilterListId_MaintainerId",
                table: "filterlists_maintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_filterlists_languages_FilterListId_LanguageId",
                table: "filterlists_languages",
                columns: new[] { "FilterListId", "LanguageId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_software_syntaxes_SoftwareId_SyntaxId",
                table: "software_syntaxes");

            migrationBuilder.DropIndex(
                name: "IX_snapshots_rules_SnapshotId_RuleId",
                table: "snapshots_rules");

            migrationBuilder.DropIndex(
                name: "IX_merges_MergeFilterListId_UpstreamFilterListId",
                table: "merges");

            migrationBuilder.DropIndex(
                name: "IX_forks_ForkFilterListId_UpstreamFilterListId",
                table: "forks");

            migrationBuilder.DropIndex(
                name: "IX_filterlists_maintainers_FilterListId_MaintainerId",
                table: "filterlists_maintainers");

            migrationBuilder.DropIndex(
                name: "IX_filterlists_languages_FilterListId_LanguageId",
                table: "filterlists_languages");
        }
    }
}
