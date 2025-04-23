using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4795 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2731, null, "Blocking of Meta Plateforms Domains", null, null, null, "https://github.com/Bundy01/meta-blocklists", "https://github.com/Bundy01/meta-blocklists/issues", 4, "Meta Adblock", null, null, null },
                    { 2732, null, "Blocking of Meta Plateforms Domains", null, null, null, "https://github.com/Bundy01/meta-blocklists", "https://github.com/Bundy01/meta-blocklists/issues", 4, "Meta Domains", null, null, null },
                    { 2733, null, "Blocking of Meta Plateforms Domains", null, null, null, "https://github.com/Bundy01/meta-blocklists", "https://github.com/Bundy01/meta-blocklists/issues", 4, "Meta Hosts (IPv4 And IPv6)", null, null, null },
                    { 2734, null, "Blocking of Meta Plateforms Domains", null, null, null, "https://github.com/Bundy01/meta-blocklists", "https://github.com/Bundy01/meta-blocklists/issues", 4, "Meta Hosts (Only IPv4)", null, null, null },
                    { 2735, null, "Blocking of Meta Plateforms Domains", null, null, null, "https://github.com/Bundy01/meta-blocklists", "https://github.com/Bundy01/meta-blocklists/issues", 4, "Meta Unbound", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 198, null, "Bundy01", null, "https://github.com/Bundy01" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2731, 198 },
                    { 2732, 198 },
                    { 2733, 198 },
                    { 2734, 198 },
                    { 2735, 198 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2731, (short)3 },
                    { 2732, (short)2 },
                    { 2733, (short)36 },
                    { 2734, (short)1 },
                    { 2735, (short)24 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2731, 19 },
                    { 2732, 19 },
                    { 2733, 19 },
                    { 2734, 19 },
                    { 2735, 19 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2731, 3064, (short)1, "https://raw.githubusercontent.com/Bundy01/meta-blocklists/refs/heads/main/meta-adblock.txt" },
                    { 2732, 3065, (short)1, "https://raw.githubusercontent.com/Bundy01/meta-blocklists/refs/heads/main/meta-domains.txt" },
                    { 2733, 3066, (short)1, "https://raw.githubusercontent.com/Bundy01/meta-blocklists/refs/heads/main/meta-hosts_4+6.txt" },
                    { 2734, 3067, (short)1, "https://raw.githubusercontent.com/Bundy01/meta-blocklists/refs/heads/main/meta-hosts_4.txt" },
                    { 2735, 3064, (short)1, "https://raw.githubusercontent.com/Bundy01/meta-blocklists/refs/heads/main/meta-unbound.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2731, 198 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2732, 198 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2733, 198 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2734, 198 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2735, 198 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2731, (short)3 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2732, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2733, (short)36 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2734, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2735, (short)24 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2731, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2732, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2733, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2734, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2735, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2731, 3064 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2732, 3065 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2733, 3066 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2734, 3067 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2735, 3064 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2732);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2734);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2735);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 198);
        }
    }
}
