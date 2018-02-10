using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddSnapshotModifiedDateUtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "snapshots");
        }
    }
}