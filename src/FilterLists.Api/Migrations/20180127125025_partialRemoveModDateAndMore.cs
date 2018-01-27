using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class partialRemoveModDateAndMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "software_syntaxes");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "snapshots");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "rules");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "merges");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "forks");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "filterlists_rules");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "filterlists_maintainers");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "filterlists_languages");

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "NVARCHAR(2083)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "software_syntaxes",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                "Raw",
                "rules",
                "NVARCHAR(2083)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2083)");

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "rules",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "merges",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "forks",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "filterlists_rules",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "filterlists_maintainers",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "filterlists_languages",
                "TIMESTAMP",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}