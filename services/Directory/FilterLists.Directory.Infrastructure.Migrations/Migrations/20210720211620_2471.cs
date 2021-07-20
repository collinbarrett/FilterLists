using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2471 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 1, null, "A filter list that blocks mobile advertisements and trackers on Japanese properties", null, null, null, "https://280blocker.net/", null, 1, "280blocker for japanese mobile site", null, null, "https://docs.google.com/forms/d/e/1FAIpQLScNeZhFrFZt9GhIVGdThGz7oyepcNRKuOi5PJDnsC-awxTeOQ/viewform" });
        }
    }
}
