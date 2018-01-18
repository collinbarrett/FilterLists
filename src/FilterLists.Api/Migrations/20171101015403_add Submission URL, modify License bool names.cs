using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilterLists.Api.Migrations
{
    public partial class addSubmissionURLmodifyLicenseboolnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissiveRedistribution",
                table: "licenses");

            migrationBuilder.DropColumn(
                name: "PermissiveUsage",
                table: "licenses");

            migrationBuilder.AddColumn<bool>(
                name: "PermissiveAdaptation",
                table: "licenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PermissiveCommercial",
                table: "licenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SubmissionUrl",
                table: "filterlists",
                type: "varchar(2083)",
                maxLength: 2083,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissiveAdaptation",
                table: "licenses");

            migrationBuilder.DropColumn(
                name: "PermissiveCommercial",
                table: "licenses");

            migrationBuilder.DropColumn(
                name: "SubmissionUrl",
                table: "filterlists");

            migrationBuilder.AddColumn<bool>(
                name: "PermissiveRedistribution",
                table: "licenses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PermissiveUsage",
                table: "licenses",
                nullable: false,
                defaultValue: false);
        }
    }
}
