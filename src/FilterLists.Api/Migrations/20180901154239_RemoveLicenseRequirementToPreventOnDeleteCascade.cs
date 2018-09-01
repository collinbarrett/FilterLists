using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class RemoveLicenseRequirementToPreventOnDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");

            migrationBuilder.AlterColumn<byte>(
                "LicenseId",
                "filterlists",
                nullable: true,
                defaultValue: (byte)5,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)5);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists");

            migrationBuilder.AlterColumn<byte>(
                "LicenseId",
                "filterlists",
                nullable: false,
                defaultValue: (byte)5,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValue: (byte)5);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_licenses_LicenseId",
                "filterlists",
                "LicenseId",
                "licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}