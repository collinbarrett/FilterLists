using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace FilterLists.Api.Migrations.Extensions
{
    public static class MigrationBuilderExtensions
    {
        public static OperationBuilder<SqlOperation> CreateIndex(this MigrationBuilder migrationBuilder, string name,
            string table, string column, int prefixLength, string schema = null, bool unique = false,
            string filter = null)
        {
            throw new NotImplementedException();
            //return migrationBuilder.Sql($"CREATE INDEX {name} ON {table} (key(10));");
        }

        public static OperationBuilder<SqlOperation> DropIndex(this MigrationBuilder migrationBuilder, string name,
            string table = null, string schema = null)
        {
            throw new NotImplementedException();
            //return migrationBuilder.Sql($"CREATE INDEX index_name ON misc_info (key(10));");
        }

        public static void DropFK_filterlists_tags_tags_TagId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_tags_tags_TagId",
                "filterlists_tags");
        }

        public static void AddFK_filterlists_tags_tags_TagId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_tags_tags_TagId",
                "filterlists_tags",
                "TagId",
                "tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_syntaxes_SyntaxId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_syntaxes_SyntaxId",
                "filterlists");
        }

        public static void AddFK_filterlists_syntaxes_SyntaxId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_syntaxes_SyntaxId",
                "filterlists",
                "SyntaxId",
                "syntaxes",
                principalColumn: "Id");
        }

        public static void DropFK_software_syntaxes_syntaxes_SyntaxId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_software_syntaxes_syntaxes_SyntaxId",
                "software_syntaxes");
        }

        public static void AddFK_software_syntaxes_syntaxes_SyntaxId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_software_syntaxes_syntaxes_SyntaxId",
                "software_syntaxes",
                "SyntaxId",
                "syntaxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_software_syntaxes_software_SoftwareId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_software_syntaxes_software_SoftwareId",
                "software_syntaxes");
        }

        public static void AddFK_software_syntaxes_software_SoftwareId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_software_syntaxes_software_SoftwareId",
                "software_syntaxes",
                "SoftwareId",
                "software",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_snapshots_rules_rules_RuleId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_rules_RuleId",
                "snapshots_rules");
        }

        public static void AddFK_snapshots_rules_rules_RuleId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_rules_RuleId",
                "snapshots_rules",
                "RuleId",
                "rules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_snapshots_rules_snapshots_SnapshotId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules");
        }

        public static void AddFK_snapshots_rules_snapshots_SnapshotId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules",
                "SnapshotId",
                "snapshots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_snapshots_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_filterlists_FilterListId",
                "snapshots");
        }

        public static void AddFK_snapshots_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_filterlists_FilterListId",
                "snapshots",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_merges_filterlists_UpstreamFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_merges_filterlists_UpstreamFilterListId",
                "merges");
        }

        public static void AddFK_merges_filterlists_UpstreamFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_merges_filterlists_UpstreamFilterListId",
                "merges",
                "UpstreamFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_merges_filterlists_MergeFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_merges_filterlists_MergeFilterListId",
                "merges");
        }

        public static void AddFK_merges_filterlists_MergeFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_merges_filterlists_MergeFilterListId",
                "merges",
                "MergeFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_forks_filterlists_UpstreamFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_forks_filterlists_UpstreamFilterListId",
                "forks");
        }

        public static void AddFK_forks_filterlists_UpstreamFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_forks_filterlists_UpstreamFilterListId",
                "forks",
                "UpstreamFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_forks_filterlists_ForkFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_forks_filterlists_ForkFilterListId",
                "forks");
        }

        public static void AddFK_forks_filterlists_ForkFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_forks_filterlists_ForkFilterListId",
                "forks",
                "ForkFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_tags_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_tags_filterlists_FilterListId",
                "filterlists_tags");
        }

        public static void AddFK_filterlists_tags_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_tags_filterlists_FilterListId",
                "filterlists_tags",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_maintainers_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_maintainers_filterlists_FilterListId",
                "filterlists_maintainers");
        }

        public static void AddFK_filterlists_maintainers_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_maintainers_filterlists_FilterListId",
                "filterlists_maintainers",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_languages_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_languages_filterlists_FilterListId",
                "filterlists_languages");
        }

        public static void AddFK_filterlists_languages_filterlists_FilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_languages_filterlists_FilterListId",
                "filterlists_languages",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_dependents_filterlists_DependencyFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_dependents_filterlists_DependencyFilterListId",
                "dependents");
        }

        public static void AddFK_dependents_filterlists_DependencyFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_dependents_filterlists_DependencyFilterListId",
                "dependents",
                "DependencyFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_dependents_filterlists_DependentFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_dependents_filterlists_DependentFilterListId",
                "dependents");
        }

        public static void AddFK_dependents_filterlists_DependentFilterListId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_dependents_filterlists_DependentFilterListId",
                "dependents",
                "DependentFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_maintainers_maintainers_MaintainerId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_maintainers_maintainers_MaintainerId",
                "filterlists_maintainers");
        }

        public static void AddFK_filterlists_maintainers_maintainers_MaintainerId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_maintainers_maintainers_MaintainerId",
                "filterlists_maintainers",
                "MaintainerId",
                "maintainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        public static void DropFK_filterlists_licenses_LicenseId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");
        }

        public static void AddFK_filterlists_licenses_LicenseId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id");
        }

        public static void DropFK_filterlists_languages_languages_LanguageId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages");
        }

        public static void AddFK_filterlists_languages_languages_LanguageId(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages",
                "LanguageId",
                "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}