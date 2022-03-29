using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2859 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2471L,
                columns: new[] { "donate_url", "home_url", "issues_url" },
                values: new object[] { "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC", "https://github.com/EasyDutch-uBO/EasyDutch/", "https://github.com/EasyDutch-uBO/EasyDutch/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                column: "donate_url",
                value: "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2521L,
                column: "donate_url",
                value: "https://www.paypal.com/donate/?hosted_button_id=NRARDMBBMV3LC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2471L,
                columns: new[] { "donate_url", "home_url", "issues_url" },
                values: new object[] { "https://www.paypal.com/donate?hosted_button_id=M4D2NPZX5NS4C", "https://github.com/BPower0036/AdBlockFilters/", "https://github.com/BPower0036/AdBlockFilters/issues" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2520L,
                column: "donate_url",
                value: "https://www.paypal.com/donate?hosted_button_id=M4D2NPZX5NS4C");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2521L,
                column: "donate_url",
                value: "https://www.paypal.com/donate?hosted_button_id=M4D2NPZX5NS4C");
        }
    }
}
