using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddDiversionDnsmasqSyntaxSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Syntax",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { (short)59, null, "dnsmasq address", "http://www.thekelleys.org.uk/dnsmasq/docs/dnsmasq-man.html" },
                    { (short)60, null, "dnsmasq server", "http://www.thekelleys.org.uk/dnsmasq/docs/dnsmasq-man.html" },
                    { (short)61, null, "dnsmasq local", "http://www.thekelleys.org.uk/dnsmasq/docs/dnsmasq-man.html" }
                });

            migrationBuilder.InsertData(
                table: "SoftwareSyntax",
                columns: new[] { "SoftwareId", "SyntaxId" },
                values: new object[,]
                {
                    { (short)22, (short)59 },
                    { (short)22, (short)60 },
                    { (short)22, (short)61 },
                    { (short)23, (short)59 },
                    { (short)23, (short)60 },
                    { (short)23, (short)61 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)22, (short)59 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)22, (short)60 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)22, (short)61 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)23, (short)59 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)23, (short)60 });

            migrationBuilder.DeleteData(
                table: "SoftwareSyntax",
                keyColumns: new[] { "SoftwareId", "SyntaxId" },
                keyValues: new object[] { (short)23, (short)61 });

            migrationBuilder.DeleteData(
                table: "Syntax",
                keyColumn: "Id",
                keyValue: (short)59);

            migrationBuilder.DeleteData(
                table: "Syntax",
                keyColumn: "Id",
                keyValue: (short)60);

            migrationBuilder.DeleteData(
                table: "Syntax",
                keyColumn: "Id",
                keyValue: (short)61);
        }
    }
}
