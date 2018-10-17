using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddDependent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "dependents",
                table => new
                {
                    CreatedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false,
                        defaultValueSql: "current_timestamp()"),
                    DependentFilterListId = table.Column<ushort>(),
                    DependencyFilterListId = table.Column<ushort>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependents", x => new {x.DependentFilterListId, x.DependencyFilterListId});
                    table.ForeignKey(
                        "FK_dependents_filterlists_DependencyFilterListId",
                        x => x.DependencyFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_dependents_filterlists_DependentFilterListId",
                        x => x.DependentFilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_dependents_DependencyFilterListId",
                "dependents",
                "DependencyFilterListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "dependents");
        }
    }
}