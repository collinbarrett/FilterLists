using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class TweakVarcharCollationAndWidenRuleRaw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "syntaxes",
                type: "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "software",
                type: "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Raw",
                table: "rules",
                type: "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TwitterHandle",
                table: "maintainers",
                type: "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "maintainers",
                type: "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "maintainers",
                type: "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "licenses",
                type: "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "languages",
                type: "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocalName",
                table: "languages",
                type: "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6393",
                table: "languages",
                type: "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392T",
                table: "languages",
                type: "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392B",
                table: "languages",
                type: "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392",
                table: "languages",
                type: "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6391",
                table: "languages",
                type: "VARCHAR(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "filterlists",
                type: "VARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "filterlists",
                type: "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(126)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "syntaxes",
                type: "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "software",
                type: "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Raw",
                table: "rules",
                type: "NVARCHAR(2083) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(16384) NOT NULL COLLATE 'utf8_unicode_ci'",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TwitterHandle",
                table: "maintainers",
                type: "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "maintainers",
                type: "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "maintainers",
                type: "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "licenses",
                type: "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "languages",
                type: "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocalName",
                table: "languages",
                type: "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6393",
                table: "languages",
                type: "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392T",
                table: "languages",
                type: "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392B",
                table: "languages",
                type: "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6392",
                table: "languages",
                type: "NVARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso6391",
                table: "languages",
                type: "NVARCHAR(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "filterlists",
                type: "NVARCHAR(126) NOT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) NOT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "filterlists",
                type: "NVARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);
        }
    }
}
