using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class DropSnapshotRuleCreatedDateUtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "CreatedDateUtc",
                "snapshots_rules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                "CreatedDateUtc",
                "snapshots_rules",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp()");
        }
    }
}