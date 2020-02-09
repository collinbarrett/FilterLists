using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddBatchSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                "HttpStatusCode",
                "snapshots",
                "SMALLINT",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(ushort),
                oldType: "SMALLINT UNSIGNED",
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AddColumn<short>(
                "BatchSize",
                "snapshots",
                "SMALLINT",
                nullable: true,
                defaultValueSql: "NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "BatchSize",
                "snapshots");

            migrationBuilder.AlterColumn<ushort>(
                "HttpStatusCode",
                "snapshots",
                "SMALLINT UNSIGNED",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(short),
                oldType: "SMALLINT",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }
    }
}