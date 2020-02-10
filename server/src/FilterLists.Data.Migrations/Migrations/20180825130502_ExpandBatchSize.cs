using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class ExpandBatchSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                "BatchSize",
                "snapshots",
                "MEDIUMINT",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(short),
                oldType: "SMALLINT",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                "BatchSize",
                "snapshots",
                "SMALLINT",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(int),
                oldType: "MEDIUMINT",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }
    }
}