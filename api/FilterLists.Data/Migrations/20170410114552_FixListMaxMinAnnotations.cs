using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class FixListMaxMinAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ViewUrl",
                table: "List",
                maxLength: 2083,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "IssuesUrl",
                table: "List",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HomeUrl",
                table: "List",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ForumUrl",
                table: "List",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "List",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DonateUrl",
                table: "List",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionSourceUrl",
                table: "List",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ViewUrl",
                table: "List",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2083);

            migrationBuilder.AlterColumn<string>(
                name: "IssuesUrl",
                table: "List",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2083,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HomeUrl",
                table: "List",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2083,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ForumUrl",
                table: "List",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2083,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "List",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DonateUrl",
                table: "List",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2083,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionSourceUrl",
                table: "List",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2083,
                oldNullable: true);
        }
    }
}
