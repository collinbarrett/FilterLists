using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddPhishDestroyLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2839,
                column: "Description",
                value: "Community-aggregated cryptocurrency phishing blocklist from PhishDestroy containing scam sites, wallet drainers, fake exchanges and seed phrase phishing.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2840,
                column: "Description",
                value: "DNS-verified active cryptocurrency phishing domains from PhishDestroy including scam sites, wallet drainers, and fake exchanges.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2839,
                column: "Description",
                value: "Community-aggregated cryptocurrency phishing blocklist from PhishDestroy. Real-time updated list of cryptocurrency phishing domains, scam sites, wallet drainers, fake exchanges and seed phrase phishing.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2840,
                column: "Description",
                value: "DNS-verified active cryptocurrency phishing domains from PhishDestroy. Real-time updated list of verified active cryptocurrency phishing domains, scam sites, wallet drainers, and fake exchanges.");
        }
    }
}
