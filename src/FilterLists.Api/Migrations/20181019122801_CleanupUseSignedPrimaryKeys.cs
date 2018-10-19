using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class CleanupUseSignedPrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DropFK_filterlists_languages_languages_LanguageId(migrationBuilder);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages",
                "LanguageId",
                "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            DropFK_filterlists_languages_languages_LanguageId(migrationBuilder);

            migrationBuilder.AddForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages",
                "LanguageId",
                "languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        private static void DropFK_filterlists_languages_languages_LanguageId(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_filterlists_languages_languages_LanguageId",
                "filterlists_languages");
        }
    }
}