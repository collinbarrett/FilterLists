using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class AddTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "tags",
                table => new
                {
                    Id = table.Column<byte>("TINYINT UNSIGNED")
                              .Annotation("MySql:ValueGenerationStrategy",
                                  MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDateUtc =
                        table.Column<DateTime>("TIMESTAMP", nullable: false, defaultValueSql: "current_timestamp()"),
                    ModifiedDateUtc = table.Column<DateTime>("TIMESTAMP", nullable: false,
                        defaultValueSql: "current_timestamp() ON UPDATE current_timestamp()"),
                    Name = table.Column<string>("VARCHAR(126)"),
                    Description = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_tags", x => x.Id); });

            migrationBuilder.CreateTable(
                "filterlists_tags",
                table => new
                {
                    CreatedDateUtc =
                        table.Column<DateTime>("TIMESTAMP", nullable: false, defaultValueSql: "current_timestamp()"),
                    FilterListId = table.Column<ushort>(),
                    TagId = table.Column<byte>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filterlists_tags", x => new {x.FilterListId, x.TagId});
                    table.ForeignKey(
                        "FK_filterlists_tags_filterlists_FilterListId",
                        x => x.FilterListId,
                        "filterlists",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_filterlists_tags_tags_TagId",
                        x => x.TagId,
                        "tags",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_filterlists_tags_TagId",
                "filterlists_tags",
                "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "filterlists_tags");

            migrationBuilder.DropTable(
                "tags");
        }
    }
}