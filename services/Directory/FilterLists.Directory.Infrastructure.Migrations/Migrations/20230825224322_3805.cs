using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3805 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 767L, 37L });

            migrationBuilder.DeleteData(
                table: "filter_list_languages",
                keyColumns: new[] { "filter_list_id", "language_id" },
                keyValues: new object[] { 767L, 179L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 767L, 3L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 767L, 2L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 767L, 798L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 767L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 767L, null, "Rules contributed by diligent owls.", null, null, null, "https://github.com/OwlStudioCN/owl-abp-rules", true, "https://github.com/OwlStudioCN/owl-abp-rules/issues", 8L, "OwlStudio ABP Rules", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_languages",
                columns: new[] { "filter_list_id", "language_id" },
                values: new object[,]
                {
                    { 767L, 37L },
                    { 767L, 179L }
                });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 767L, 3L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 767L, 2L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 767L, 798L, (short)1, "https://raw.githubusercontent.com/OwlStudioCN/owl-abp-rules/master/owl-abp-rules.txt" });
        }
    }
}
