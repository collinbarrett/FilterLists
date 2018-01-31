using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class TweakVarcharCollationAndWidenRuleRaw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Name",
                "syntaxes",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "software",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "maintainers",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "licenses",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "VARCHAR(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "filterlists",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Name",
                "syntaxes",
                "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "software",
                "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "NVARCHAR(2083) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "maintainers",
                "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "licenses",
                "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "NVARCHAR(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "filterlists",
                "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);
        }
    }
}