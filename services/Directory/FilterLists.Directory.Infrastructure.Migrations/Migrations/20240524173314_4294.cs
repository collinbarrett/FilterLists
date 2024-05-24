using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4294 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2669L,
                column: "donate_url",
                value: "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2670L,
                column: "donate_url",
                value: "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2671L,
                column: "donate_url",
                value: "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2672L,
                column: "donate_url",
                value: "https://github.com/serhiyguryev/ukrainian-filters?tab=readme-ov-file#підтримати-проект");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2669L,
                column: "donate_url",
                value: "https://donatello.to/serhiyguryev");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2670L,
                column: "donate_url",
                value: "https://donatello.to/serhiyguryev");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2671L,
                column: "donate_url",
                value: "https://donatello.to/serhiyguryev");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2672L,
                column: "donate_url",
                value: "https://donatello.to/serhiyguryev");
        }
    }
}
