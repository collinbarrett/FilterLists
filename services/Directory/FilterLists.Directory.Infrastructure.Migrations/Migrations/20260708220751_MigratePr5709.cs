using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class MigratePr5709 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2845,
                columns: new[] { "Description", "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "Filter list for website features and content that uses Generative AI.", "https://github.com/Stevoisiak/Stevos-AI-Blocklist", "https://github.com/Stevoisiak/Stevos-AI-Blocklist/issues", "Stevo's AI Blocklist" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3246 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Stevoisiak/Stevos-AI-Blocklist/refs/heads/main/GenAI-Blocklist.txt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2845,
                columns: new[] { "Description", "HomeUrl", "IssuesUrl", "Name" },
                values: new object[] { "Filter list for website features that use or promote Generative AI.", "https://github.com/Stevoisiak/Stevos-GenAI-Blocklist", "https://github.com/Stevoisiak/Stevos-GenAI-Blocklist/issues", "Stevo's GenAI Blocklist" });

            migrationBuilder.UpdateData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3246 },
                column: "Url",
                value: "https://raw.githubusercontent.com/Stevoisiak/Stevos-GenAI-Blocklist/refs/heads/main/GenAI-Blocklist.txt");
        }
    }
}
