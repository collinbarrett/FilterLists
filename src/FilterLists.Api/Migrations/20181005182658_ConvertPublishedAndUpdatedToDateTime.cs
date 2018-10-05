using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class ConvertPublishedAndUpdatedToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "UpdatedDate",
                "filterlists",
                "DATETIME",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<DateTime>(
                "PublishedDate",
                "filterlists",
                "DATETIME",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "UpdatedDate",
                "filterlists",
                "DATE",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<DateTime>(
                "PublishedDate",
                "filterlists",
                "DATE",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }
    }
}