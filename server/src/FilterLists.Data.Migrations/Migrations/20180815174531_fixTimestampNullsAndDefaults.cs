using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class fixTimestampNullsAndDefaults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "software_syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "software",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "software",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "snapshots_rules",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "snapshots_rules",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "CURRENT_TIMESTAMP()");

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "snapshots",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "rules",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "merges",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "licenses",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "licenses",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "languages",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "languages",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "forks",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists_maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists_languages",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "filterlists",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists",
                                "TIMESTAMP",
                                nullable: false,
                                defaultValueSql: "current_timestamp()",
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP")
                            .OldAnnotation("MySql:ValueGenerationStrategy",
                                MySqlValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "software_syntaxes",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "software",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "software",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "snapshots_rules",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "snapshots_rules",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()",
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "snapshots",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "rules",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "merges",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "licenses",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "licenses",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "languages",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "languages",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "forks",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists_maintainers",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists_languages",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "ModifiedDateUtc",
                                "filterlists",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp() ON UPDATE current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AlterColumn<DateTime>(
                                "CreatedDateUtc",
                                "filterlists",
                                "TIMESTAMP",
                                nullable: false,
                                oldClrType: typeof(DateTime),
                                oldType: "TIMESTAMP",
                                oldDefaultValueSql: "current_timestamp()")
                            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}