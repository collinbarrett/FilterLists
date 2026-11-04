using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNetApiCompromisedIpsDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2877,
                column: "Description",
                value: "IPv4 addresses that attacked the sensors of NetAPI Nightwatch, NetAPI's own honeypot network, within the last 48 hours (brute force, exploits, malware downloads, etc.), one address per line. Updated every hour.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2877,
                column: "Description",
                value: "IPv4 addresses seen in public malware and abuse feeds within the last 24 hours, one address per line. Updated daily.");
        }
    }
}
