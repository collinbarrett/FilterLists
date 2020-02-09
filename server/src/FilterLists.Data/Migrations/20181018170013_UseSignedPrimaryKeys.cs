using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class UseSignedPrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DropFK_filterlists_tags_tags_TagId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "tags",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(byte),
                                oldType: "TINYINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<short>(
                "TagId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(byte));

            AddFK_filterlists_tags_tags_TagId(migrationBuilder);

            DropFK_filterlists_syntaxes_SyntaxId(migrationBuilder);

            DropFK_software_syntaxes_syntaxes_SyntaxId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "syntaxes",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(byte),
                                oldType: "TINYINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<short>(
                "SyntaxId",
                "filterlists",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true);

            AddFK_filterlists_syntaxes_SyntaxId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "SyntaxId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(byte));

            AddFK_software_syntaxes_syntaxes_SyntaxId(migrationBuilder);

            DropFK_software_syntaxes_software_SoftwareId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "SoftwareId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "software",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(byte),
                                oldType: "TINYINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_software_syntaxes_software_SoftwareId(migrationBuilder);

            DropFK_snapshots_rules_rules_RuleId(migrationBuilder);

            migrationBuilder.AlterColumn<int>(
                "RuleId",
                "snapshots_rules",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                                "Id",
                                "rules",
                                "INT",
                                nullable: false,
                                oldClrType: typeof(uint),
                                oldType: "INT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_rules_rules_RuleId(migrationBuilder);

            DropFK_snapshots_rules_snapshots_SnapshotId(migrationBuilder);

            migrationBuilder.AlterColumn<int>(
                "SnapshotId",
                "snapshots_rules",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                                "Id",
                                "snapshots",
                                "MEDIUMINT",
                                nullable: false,
                                oldClrType: typeof(uint),
                                oldType: "MEDIUMINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_rules_snapshots_SnapshotId(migrationBuilder);

            DropFK_snapshots_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "snapshots",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_merges_filterlists_UpstreamFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "UpstreamFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_merges_filterlists_MergeFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "MergeFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_forks_filterlists_UpstreamFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "UpstreamFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_forks_filterlists_ForkFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "ForkFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_filterlists_tags_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_filterlists_maintainers_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_filterlists_languages_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(ushort));

            DropFK_dependents_filterlists_DependencyFilterListId(migrationBuilder);

            DropFK_dependents_filterlists_DependentFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "filterlists",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(ushort),
                                oldType: "SMALLINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_filterlists_FilterListId(migrationBuilder);

            AddFK_merges_filterlists_UpstreamFilterListId(migrationBuilder);

            AddFK_merges_filterlists_MergeFilterListId(migrationBuilder);

            AddFK_forks_filterlists_UpstreamFilterListId(migrationBuilder);

            AddFK_forks_filterlists_ForkFilterListId(migrationBuilder);

            AddFK_filterlists_tags_filterlists_FilterListId(migrationBuilder);

            AddFK_filterlists_maintainers_filterlists_FilterListId(migrationBuilder);

            AddFK_filterlists_languages_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "DependencyFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(ushort));

            AddFK_dependents_filterlists_DependencyFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                "DependentFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(ushort));

            AddFK_dependents_filterlists_DependentFilterListId(migrationBuilder);

            DropFK_filterlists_maintainers_maintainers_MaintainerId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "maintainers",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(ushort),
                                oldType: "SMALLINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<short>(
                "MaintainerId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(ushort));

            AddFK_filterlists_maintainers_maintainers_MaintainerId(migrationBuilder);

            DropFK_filterlists_licenses_LicenseId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "licenses",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(byte),
                                oldType: "TINYINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<short>(
                "LicenseId",
                "filterlists",
                nullable: true,
                defaultValue: (short)5,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValue: (byte)5);

            AddFK_filterlists_licenses_LicenseId(migrationBuilder);

            DropFK_filterlists_languages_languages_LanguageId(migrationBuilder);

            migrationBuilder.AlterColumn<short>(
                                "Id",
                                "languages",
                                "SMALLINT",
                                nullable: false,
                                oldClrType: typeof(ushort),
                                oldType: "SMALLINT UNSIGNED")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<short>(
                "LanguageId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(ushort));

            AddFK_filterlists_languages_languages_LanguageId(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            DropFK_filterlists_tags_tags_TagId(migrationBuilder);

            migrationBuilder.AlterColumn<byte>(
                                "Id",
                                "tags",
                                "TINYINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<byte>(
                "TagId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_filterlists_tags_tags_TagId(migrationBuilder);

            DropFK_filterlists_syntaxes_SyntaxId(migrationBuilder);

            DropFK_software_syntaxes_syntaxes_SyntaxId(migrationBuilder);

            migrationBuilder.AlterColumn<byte>(
                                "Id",
                                "syntaxes",
                                "TINYINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<byte>(
                "SyntaxId",
                "filterlists",
                nullable: true,
                oldClrType: typeof(short),
                oldNullable: true);

            AddFK_filterlists_syntaxes_SyntaxId(migrationBuilder);

            migrationBuilder.AlterColumn<byte>(
                "SyntaxId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_software_syntaxes_syntaxes_SyntaxId(migrationBuilder);

            DropFK_software_syntaxes_software_SoftwareId(migrationBuilder);

            migrationBuilder.AlterColumn<byte>(
                "SoftwareId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<byte>(
                                "Id",
                                "software",
                                "TINYINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_software_syntaxes_software_SoftwareId(migrationBuilder);

            DropFK_snapshots_rules_rules_RuleId(migrationBuilder);

            migrationBuilder.AlterColumn<uint>(
                "RuleId",
                "snapshots_rules",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<uint>(
                                "Id",
                                "rules",
                                "INT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(int),
                                oldType: "INT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_rules_rules_RuleId(migrationBuilder);

            DropFK_snapshots_rules_snapshots_SnapshotId(migrationBuilder);

            migrationBuilder.AlterColumn<uint>(
                "SnapshotId",
                "snapshots_rules",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<uint>(
                                "Id",
                                "snapshots",
                                "MEDIUMINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(int),
                                oldType: "MEDIUMINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_rules_snapshots_SnapshotId(migrationBuilder);

            DropFK_snapshots_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "snapshots",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_merges_filterlists_UpstreamFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "UpstreamFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_merges_filterlists_MergeFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "MergeFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_forks_filterlists_UpstreamFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "UpstreamFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_forks_filterlists_ForkFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "ForkFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_filterlists_tags_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_filterlists_maintainers_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_filterlists_languages_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(short));

            DropFK_dependents_filterlists_DependencyFilterListId(migrationBuilder);

            DropFK_dependents_filterlists_DependentFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                                "Id",
                                "filterlists",
                                "SMALLINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            AddFK_snapshots_filterlists_FilterListId(migrationBuilder);

            AddFK_merges_filterlists_UpstreamFilterListId(migrationBuilder);

            AddFK_merges_filterlists_MergeFilterListId(migrationBuilder);

            AddFK_forks_filterlists_UpstreamFilterListId(migrationBuilder);

            AddFK_forks_filterlists_ForkFilterListId(migrationBuilder);

            AddFK_filterlists_tags_filterlists_FilterListId(migrationBuilder);

            AddFK_filterlists_maintainers_filterlists_FilterListId(migrationBuilder);

            AddFK_filterlists_languages_filterlists_FilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "DependencyFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_dependents_filterlists_DependencyFilterListId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                "DependentFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_dependents_filterlists_DependentFilterListId(migrationBuilder);

            DropFK_filterlists_maintainers_maintainers_MaintainerId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                                "Id",
                                "maintainers",
                                "SMALLINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<ushort>(
                "MaintainerId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_filterlists_maintainers_maintainers_MaintainerId(migrationBuilder);

            DropFK_filterlists_licenses_LicenseId(migrationBuilder);

            migrationBuilder.AlterColumn<byte>(
                                "Id",
                                "licenses",
                                "TINYINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<byte>(
                "LicenseId",
                "filterlists",
                nullable: true,
                defaultValue: (byte)5,
                oldClrType: typeof(short),
                oldNullable: true,
                oldDefaultValue: (short)5);

            AddFK_filterlists_licenses_LicenseId(migrationBuilder);

            DropFK_filterlists_languages_languages_LanguageId(migrationBuilder);

            migrationBuilder.AlterColumn<ushort>(
                                "Id",
                                "languages",
                                "SMALLINT UNSIGNED",
                                nullable: false,
                                oldClrType: typeof(short),
                                oldType: "SMALLINT")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<ushort>(
                "LanguageId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(short));

            AddFK_filterlists_languages_languages_LanguageId(migrationBuilder);
        }

        private static void DropFK_filterlists_tags_tags_TagId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_tags_tags_TagId",
                "filterlists_tags");
        }

        private static void AddFK_filterlists_tags_tags_TagId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_tags_tags_TagId",
                "filterlists_tags",
                "TagId",
                "tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_syntaxes_SyntaxId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_syntaxes_SyntaxId",
                "filterlists");
        }

        private static void AddFK_filterlists_syntaxes_SyntaxId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_syntaxes_SyntaxId",
                "filterlists",
                "SyntaxId",
                "syntaxes",
                principalColumn: "Id");
        }

        private static void DropFK_software_syntaxes_syntaxes_SyntaxId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_software_syntaxes_syntaxes_SyntaxId",
                "software_syntaxes");
        }

        private static void AddFK_software_syntaxes_syntaxes_SyntaxId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_software_syntaxes_syntaxes_SyntaxId",
                "software_syntaxes",
                "SyntaxId",
                "syntaxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_software_syntaxes_software_SoftwareId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_software_syntaxes_software_SoftwareId",
                "software_syntaxes");
        }

        private static void AddFK_software_syntaxes_software_SoftwareId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_software_syntaxes_software_SoftwareId",
                "software_syntaxes",
                "SoftwareId",
                "software",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_snapshots_rules_rules_RuleId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_rules_RuleId",
                "snapshots_rules");
        }

        private static void AddFK_snapshots_rules_rules_RuleId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_rules_RuleId",
                "snapshots_rules",
                "RuleId",
                "rules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_snapshots_rules_snapshots_SnapshotId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules");
        }

        private static void AddFK_snapshots_rules_snapshots_SnapshotId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules",
                "SnapshotId",
                "snapshots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_snapshots_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_filterlists_FilterListId",
                "snapshots");
        }

        private static void AddFK_snapshots_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_snapshots_filterlists_FilterListId",
                "snapshots",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_merges_filterlists_UpstreamFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_merges_filterlists_UpstreamFilterListId",
                "merges");
        }

        private static void AddFK_merges_filterlists_UpstreamFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_merges_filterlists_UpstreamFilterListId",
                "merges",
                "UpstreamFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_merges_filterlists_MergeFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_merges_filterlists_MergeFilterListId",
                "merges");
        }

        private static void AddFK_merges_filterlists_MergeFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_merges_filterlists_MergeFilterListId",
                "merges",
                "MergeFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_forks_filterlists_UpstreamFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_forks_filterlists_UpstreamFilterListId",
                "forks");
        }

        private static void AddFK_forks_filterlists_UpstreamFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_forks_filterlists_UpstreamFilterListId",
                "forks",
                "UpstreamFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_forks_filterlists_ForkFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_forks_filterlists_ForkFilterListId",
                "forks");
        }

        private static void AddFK_forks_filterlists_ForkFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_forks_filterlists_ForkFilterListId",
                "forks",
                "ForkFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_tags_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_tags_filterlists_FilterListId",
                "filterlists_tags");
        }

        private static void AddFK_filterlists_tags_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_tags_filterlists_FilterListId",
                "filterlists_tags",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_maintainers_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_maintainers_filterlists_FilterListId",
                "filterlists_maintainers");
        }

        private static void AddFK_filterlists_maintainers_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_maintainers_filterlists_FilterListId",
                "filterlists_maintainers",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_languages_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_languages_filterlists_FilterListId",
                "filterlists_languages");
        }

        private static void AddFK_filterlists_languages_filterlists_FilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_languages_filterlists_FilterListId",
                "filterlists_languages",
                "FilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_dependents_filterlists_DependencyFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_dependents_filterlists_DependencyFilterListId",
                "dependents");
        }

        private static void AddFK_dependents_filterlists_DependencyFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_dependents_filterlists_DependencyFilterListId",
                "dependents",
                "DependencyFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_dependents_filterlists_DependentFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_dependents_filterlists_DependentFilterListId",
                "dependents");
        }

        private static void AddFK_dependents_filterlists_DependentFilterListId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_dependents_filterlists_DependentFilterListId",
                "dependents",
                "DependentFilterListId",
                "filterlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_maintainers_maintainers_MaintainerId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_maintainers_maintainers_MaintainerId",
                "filterlists_maintainers");
        }

        private static void AddFK_filterlists_maintainers_maintainers_MaintainerId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_maintainers_maintainers_MaintainerId",
                "filterlists_maintainers",
                "MaintainerId",
                "maintainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        private static void DropFK_filterlists_licenses_LicenseId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");
        }

        private static void AddFK_filterlists_licenses_LicenseId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id");
        }

        private static void DropFK_filterlists_languages_languages_LanguageId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages");
        }

        private static void AddFK_filterlists_languages_languages_LanguageId(MigrationBuilder migrationBuilder)
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