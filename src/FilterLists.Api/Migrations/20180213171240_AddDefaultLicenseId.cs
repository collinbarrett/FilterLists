using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddDefaultLicenseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");

            migrationBuilder.AlterColumn<int>(
                "LicenseId",
                "filterlists",
                nullable: false,
                defaultValue: 5,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");

            migrationBuilder.AlterColumn<int>(
                "LicenseId",
                "filterlists",
                nullable: true,
                oldClrType: typeof(int),
                oldDefaultValue: 5);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}