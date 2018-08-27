using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations
{
    public partial class DropBatchSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "BatchSize",
                "snapshots");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                "BatchSize",
                "snapshots",
                "MEDIUMINT",
                nullable: true,
                defaultValueSql: "NULL");
        }
    }
}