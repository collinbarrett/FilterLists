using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Data.Migrations
{
    public partial class AddAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "Name",
                "List",
                maxLength: 126,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "List",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                "Email",
                "List",
                maxLength: 126,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 254,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Description",
                "List",
                maxLength: 1022,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                "Author",
                "List",
                maxLength: 126,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "Author",
                "List");

            migrationBuilder.AlterColumn<string>(
                "Name",
                "List",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 126,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                "ModifiedDateUtc",
                "List",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Email",
                "List",
                maxLength: 254,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 126,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Description",
                "List",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1022,
                oldNullable: true);
        }
    }
}