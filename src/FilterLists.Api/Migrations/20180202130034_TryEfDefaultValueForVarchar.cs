using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class TryEfDefaultValueForVarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "VARCHAR(126)",
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true,
                oldDefaultValueSql: "NULL");
        }
    }
}