using FilterLists.Api.Migrations.Extensions;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class UseSignedPrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropFK_filterlists_tags_tags_TagId();

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

            migrationBuilder.AddFK_filterlists_tags_tags_TagId();

            migrationBuilder.DropFK_filterlists_syntaxes_SyntaxId();

            migrationBuilder.DropFK_software_syntaxes_syntaxes_SyntaxId();

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

            migrationBuilder.AddFK_filterlists_syntaxes_SyntaxId();

            migrationBuilder.AlterColumn<short>(
                "SyntaxId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddFK_software_syntaxes_syntaxes_SyntaxId();

            migrationBuilder.DropFK_software_syntaxes_software_SoftwareId();

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

            migrationBuilder.AddFK_software_syntaxes_software_SoftwareId();

            migrationBuilder.DropFK_snapshots_rules_rules_RuleId();

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

            migrationBuilder.AddFK_snapshots_rules_rules_RuleId();

            migrationBuilder.DropFK_snapshots_rules_snapshots_SnapshotId();

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

            migrationBuilder.AddFK_snapshots_rules_snapshots_SnapshotId();

            migrationBuilder.DropFK_snapshots_filterlists_FilterListId();

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "snapshots",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_merges_filterlists_UpstreamFilterListId();

            migrationBuilder.AlterColumn<short>(
                "UpstreamFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_merges_filterlists_MergeFilterListId();

            migrationBuilder.AlterColumn<short>(
                "MergeFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_forks_filterlists_UpstreamFilterListId();

            migrationBuilder.AlterColumn<short>(
                "UpstreamFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_forks_filterlists_ForkFilterListId();

            migrationBuilder.AlterColumn<short>(
                "ForkFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_filterlists_tags_filterlists_FilterListId();

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_filterlists_maintainers_filterlists_FilterListId();

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_filterlists_languages_filterlists_FilterListId();

            migrationBuilder.AlterColumn<short>(
                "FilterListId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.DropFK_dependents_filterlists_DependencyFilterListId();

            migrationBuilder.DropFK_dependents_filterlists_DependentFilterListId();

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

            migrationBuilder.AddFK_snapshots_filterlists_FilterListId();

            migrationBuilder.AddFK_merges_filterlists_UpstreamFilterListId();

            migrationBuilder.AddFK_merges_filterlists_MergeFilterListId();

            migrationBuilder.AddFK_forks_filterlists_UpstreamFilterListId();

            migrationBuilder.AddFK_forks_filterlists_ForkFilterListId();

            migrationBuilder.AddFK_filterlists_tags_filterlists_FilterListId();

            migrationBuilder.AddFK_filterlists_maintainers_filterlists_FilterListId();

            migrationBuilder.AddFK_filterlists_languages_filterlists_FilterListId();

            migrationBuilder.AlterColumn<short>(
                "DependencyFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.AddFK_dependents_filterlists_DependencyFilterListId();

            migrationBuilder.AlterColumn<short>(
                "DependentFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.AddFK_dependents_filterlists_DependentFilterListId();

            migrationBuilder.DropFK_filterlists_maintainers_maintainers_MaintainerId();

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

            migrationBuilder.AddFK_filterlists_maintainers_maintainers_MaintainerId();

            migrationBuilder.DropFK_filterlists_licenses_LicenseId();

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

            migrationBuilder.AddFK_filterlists_licenses_LicenseId();

            migrationBuilder.DropFK_filterlists_languages_languages_LanguageId();

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

            migrationBuilder.AddFK_filterlists_languages_languages_LanguageId();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropFK_filterlists_tags_tags_TagId();

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

            migrationBuilder.AddFK_filterlists_tags_tags_TagId();

            migrationBuilder.DropFK_filterlists_syntaxes_SyntaxId();

            migrationBuilder.DropFK_software_syntaxes_syntaxes_SyntaxId();

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

            migrationBuilder.AddFK_filterlists_syntaxes_SyntaxId();

            migrationBuilder.AlterColumn<byte>(
                "SyntaxId",
                "software_syntaxes",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddFK_software_syntaxes_syntaxes_SyntaxId();

            migrationBuilder.DropFK_software_syntaxes_software_SoftwareId();

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

            migrationBuilder.AddFK_software_syntaxes_software_SoftwareId();

            migrationBuilder.DropFK_snapshots_rules_rules_RuleId();

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

            migrationBuilder.AddFK_snapshots_rules_rules_RuleId();

            migrationBuilder.DropFK_snapshots_rules_snapshots_SnapshotId();

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

            migrationBuilder.AddFK_snapshots_rules_snapshots_SnapshotId();

            migrationBuilder.DropFK_snapshots_filterlists_FilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "snapshots",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_merges_filterlists_UpstreamFilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "UpstreamFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_merges_filterlists_MergeFilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "MergeFilterListId",
                "merges",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_forks_filterlists_UpstreamFilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "UpstreamFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_forks_filterlists_ForkFilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "ForkFilterListId",
                "forks",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_filterlists_tags_filterlists_FilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_tags",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_filterlists_maintainers_filterlists_FilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_maintainers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_filterlists_languages_filterlists_FilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "FilterListId",
                "filterlists_languages",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.DropFK_dependents_filterlists_DependencyFilterListId();

            migrationBuilder.DropFK_dependents_filterlists_DependentFilterListId();

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

            migrationBuilder.AddFK_snapshots_filterlists_FilterListId();

            migrationBuilder.AddFK_merges_filterlists_UpstreamFilterListId();

            migrationBuilder.AddFK_merges_filterlists_MergeFilterListId();

            migrationBuilder.AddFK_forks_filterlists_UpstreamFilterListId();

            migrationBuilder.AddFK_forks_filterlists_ForkFilterListId();

            migrationBuilder.AddFK_filterlists_tags_filterlists_FilterListId();

            migrationBuilder.AddFK_filterlists_maintainers_filterlists_FilterListId();

            migrationBuilder.AddFK_filterlists_languages_filterlists_FilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "DependencyFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddFK_dependents_filterlists_DependencyFilterListId();

            migrationBuilder.AlterColumn<ushort>(
                "DependentFilterListId",
                "dependents",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddFK_dependents_filterlists_DependentFilterListId();

            migrationBuilder.DropFK_filterlists_maintainers_maintainers_MaintainerId();

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

            migrationBuilder.AddFK_filterlists_maintainers_maintainers_MaintainerId();

            migrationBuilder.DropFK_filterlists_licenses_LicenseId();

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

            migrationBuilder.AddFK_filterlists_licenses_LicenseId();

            migrationBuilder.DropFK_filterlists_languages_languages_LanguageId();

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

            migrationBuilder.AddFK_filterlists_languages_languages_LanguageId();
        }
    }
}