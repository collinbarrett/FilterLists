using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3842 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 569L, 646L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/chinese.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 570L, 647L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/czech.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 573L, 648L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/english.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 574L, 649L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/french.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 575L, 650L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/german.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 583L, 651L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/portuguese.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 585L, 652L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/russian.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 586L, 653L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/spanish.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1799L, 1866L },
                column: "url",
                value: "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/-/raw/master/arabic.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 566L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 569L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 570L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 573L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 574L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 575L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 583L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 585L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 586L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1799L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv", "https://gitlab.com/eyeo/anti-cv/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 569L, 646L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/chinese.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 570L, 647L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/czech.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 573L, 648L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/english.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 574L, 649L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/french.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 575L, 650L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/german.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 583L, 651L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/portuguese.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 585L, 652L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/russian.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 586L, 653L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/spanish.txt");

            migrationBuilder.UpdateData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 1799L, 1866L },
                column: "url",
                value: "https://raw.githubusercontent.com/abp-filters/abp-filters-anti-cv/master/arabic.txt");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 566L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 569L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 570L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 573L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 574L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 575L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 583L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 585L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 586L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 1799L,
                columns: new[] { "home_url", "issues_url" },
                values: new object[] { "https://github.com/abp-filters/abp-filters-anti-cv", "https://github.com/abp-filters/abp-filters-anti-cv/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc" });
        }
    }
}
