using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSnafuListContactInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1536,
                columns: new[] { "ChatUrl", "IssuesUrl" },
                values: new object[] { "https://mastodon.social/@rooneymcnibnug", "https://github.com/RooneyMcNibNug/pihole-stuff/issues" });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 130,
                column: "TwitterHandle",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1536,
                columns: new[] { "ChatUrl", "IssuesUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 130,
                column: "TwitterHandle",
                value: "rooneymcnibnug");
        }
    }
}
