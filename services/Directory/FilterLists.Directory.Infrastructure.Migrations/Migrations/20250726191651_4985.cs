using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4985 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)27, (short)1 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)27, (short)2 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)27, (short)36 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)27, (short)48 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)27, (short)54 });

            migrationBuilder.DeleteData(
                table: "Software",
                keyColumn: "Id",
                keyValue: (short)27);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Software",
                columns: new[] { "Id", "Description", "DownloadUrl", "HomeUrl", "Name" },
                values: new object[] { (short)27, null, "https://github.com/henrypp/hostsmgr/releases", "https://www.henrypp.org/product/hostsmgr", "hostsmgr" });

            migrationBuilder.InsertData(
                table: "SoftwareSyntax",
                columns: new[] { "SoftwareId", "SyntaxId" },
                values: new object[,]
                {
                    { (short)27, (short)1 },
                    { (short)27, (short)2 },
                    { (short)27, (short)36 },
                    { (short)27, (short)48 },
                    { (short)27, (short)54 }
                });
        }
    }
}
