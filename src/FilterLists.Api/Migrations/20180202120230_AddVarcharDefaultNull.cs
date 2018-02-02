using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddVarcharDefaultNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "VARCHAR(3) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "VARCHAR(2) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "VARCHAR(126) DEFAULT NULL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                "TwitterHandle",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "maintainers",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Name",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "LocalName",
                "languages",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6393",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392T",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392B",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6392",
                "languages",
                "VARCHAR(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "Iso6391",
                "languages",
                "VARCHAR(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2) DEFAULT NULL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                "EmailAddress",
                "filterlists",
                "VARCHAR(126)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(126) DEFAULT NULL",
                oldNullable: true);
        }
    }
}