using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    [UsedImplicitly]
    public partial class AddPublishedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "DiscontinuedDate",
                "filterlists",
                "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                "PublishedDate",
                "filterlists",
                "DATE",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "PublishedDate",
                "filterlists");

            migrationBuilder.AlterColumn<DateTime>(
                "DiscontinuedDate",
                "filterlists",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);
        }
    }
}