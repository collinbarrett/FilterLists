using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class FixVarcharNullConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Name",
                "syntaxes",
                "VARCHAR(126)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "software",
                "VARCHAR(126)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(8192)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "maintainers",
                "VARCHAR(126)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "licenses",
                "VARCHAR(126)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "VARCHAR(2)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(2) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "filterlists",
                "VARCHAR(126)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Name",
                "syntaxes",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "software",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)");

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8192)");

            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "maintainers",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)");

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "licenses",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "VARCHAR(2) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "filterlists",
                "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)");
        }
    }
}