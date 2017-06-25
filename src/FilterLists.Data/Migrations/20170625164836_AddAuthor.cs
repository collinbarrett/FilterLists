using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class AddAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "List",
                maxLength: 126,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "List",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "List",
                maxLength: 126,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "List",
                maxLength: 1022,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "List",
                maxLength: 126,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "List");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "List",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 126,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDateUtc",
                table: "List",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "List",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 126,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "List",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1022,
                oldNullable: true);
        }
    }
}
