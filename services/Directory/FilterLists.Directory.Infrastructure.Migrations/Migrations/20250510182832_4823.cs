using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2737,
                column: "HomeUrl",
                value: "https://codeberg.org/BloqueBollore/pages/src/branch/main/desarmons-bollore-et-l-extreme-droite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2737, 3069 },
                column: "Url",
                value: "https://bloquebollore.codeberg.page/desarmons-bollore-et-l-extreme-droite.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2737,
                column: "HomeUrl",
                value: "https://bloquebollore.codeberg.page/desarmons-bollore-et-l-extreme-droite.txt");

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2737, 3069 },
                column: "Url",
                value: "https://codeberg.org/BloqueBollore/pages/src/branch/main/desarmons-bollore-et-l-extreme-droite.txt");
        }
    }
}
