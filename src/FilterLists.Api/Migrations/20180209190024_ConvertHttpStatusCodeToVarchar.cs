using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class ConvertHttpStatusCodeToVarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "HttpStatusCode",
                "snapshots",
                "VARCHAR(3)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(int),
                oldType: "SMALLINT UNSIGNED",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                "HttpStatusCode",
                "snapshots",
                "SMALLINT UNSIGNED",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }
    }
}