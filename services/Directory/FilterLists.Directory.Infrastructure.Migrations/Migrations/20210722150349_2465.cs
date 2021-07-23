using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2465 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2513, null, "Hosts file for blocking sites by known malware authors, including those browser-hijacking extensions, as well as those sketchy data-sucking no-name search engines that those companies work with. Also if you donate please ignore the fact that our deadname is on the page.", "https://paypal.me/ArcticCircleSystem", "ArcticCircleSystem@gmail.com", null, "https://github.com/Arctic-Circle-System/Sketchy-Extension-and-Search-List/", "https://github.com/Arctic-Circle-System/Sketchy-Extension-and-Search-List/issues/", null, "Extension-based Malware and Data-Sucking Search Engine hosts file", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 2513);
        }
    }
}
