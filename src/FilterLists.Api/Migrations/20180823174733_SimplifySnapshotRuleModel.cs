using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class SimplifySnapshotRuleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_snapshots_AddedBySnapshotId",
                "snapshots_rules");

            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_snapshots_RemovedBySnapshotId",
                "snapshots_rules");

            migrationBuilder.DropIndex(
                "IX_snapshots_rules_RemovedBySnapshotId",
                "snapshots_rules");

            migrationBuilder.DropColumn(
                "ModifiedDateUtc",
                "snapshots_rules");

            migrationBuilder.DropColumn(
                "RemovedBySnapshotId",
                "snapshots_rules");

            migrationBuilder.RenameColumn(
                "AddedBySnapshotId",
                "snapshots_rules",
                "SnapshotId");

            migrationBuilder.AlterColumn<ushort>(
                "HttpStatusCode",
                "snapshots",
                "SMALLINT UNSIGNED",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules",
                "SnapshotId",
                "snapshots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_snapshots_rules_snapshots_SnapshotId",
                "snapshots_rules");

            migrationBuilder.RenameColumn(
                "SnapshotId",
                "snapshots_rules",
                "AddedBySnapshotId");

            migrationBuilder.AddColumn<DateTime>(
                "ModifiedDateUtc",
                "snapshots_rules",
                "TIMESTAMP",
                nullable: false,
                defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()");

            migrationBuilder.AddColumn<uint>(
                "RemovedBySnapshotId",
                "snapshots_rules",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                "HttpStatusCode",
                "snapshots",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(ushort),
                oldType: "SMALLINT UNSIGNED",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.CreateIndex(
                "IX_snapshots_rules_RemovedBySnapshotId",
                "snapshots_rules",
                "RemovedBySnapshotId");

            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_snapshots_AddedBySnapshotId",
                "snapshots_rules",
                "AddedBySnapshotId",
                "snapshots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                "FK_snapshots_rules_snapshots_RemovedBySnapshotId",
                "snapshots_rules",
                "RemovedBySnapshotId",
                "snapshots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}