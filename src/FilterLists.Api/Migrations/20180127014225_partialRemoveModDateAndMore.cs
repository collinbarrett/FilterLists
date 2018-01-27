using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class partialRemoveModDateAndMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "software_syntaxes");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "snapshots");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "rules");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "merges");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "forks");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "filterlists_rules");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "filterlists_maintainers");

            migrationBuilder.DropColumn(
                name: "ModifiedDateUtc",
                table: "filterlists_languages");

            migrationBuilder.AlterColumn<string>(
                name: "Raw",
                table: "rules",
                type: "NVARCHAR(2083)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ViewUrl",
                table: "filterlists",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "software_syntaxes",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "snapshots",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Raw",
                table: "rules",
                type: "NVARCHAR(2083)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "rules",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "merges",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "forks",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "filterlists_rules",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "filterlists_maintainers",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "filterlists_languages",
                type: "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ViewUrl",
                table: "filterlists",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
