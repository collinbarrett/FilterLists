using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Consolidate1HostsDuplicates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 811, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 812, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1954, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2002, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 811, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 812, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1954, (short)28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2002, (short)20 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2280, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 811, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 811, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 811, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 811, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 812, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 812, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 812, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 812, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1954, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1954, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1954, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1954, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2002, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2002, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2002, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2002, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2280, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2280, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2280, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2280, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 811, 841 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 812, 842 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 1954, 2027 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2002, 2098 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2421 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2280, 2422 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2280);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 811, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (GitHub Only)", null, null, null },
                    { 812, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Domains, GitHub Only)", null, null, null },
                    { 1954, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Adblockers, GitHub Only)", null, null, null },
                    { 2002, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (dnsmasq, GitHub Only)", null, null, null },
                    { 2280, null, "Balanced - set & forget, prioritizes smooth UX, ideal for general users.", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Lite (Domains with wildcards, GitHub Pages Primary)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 811, 25 },
                    { 812, 25 },
                    { 1954, 25 },
                    { 2002, 25 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 811, (short)1 },
                    { 812, (short)2 },
                    { 1954, (short)28 },
                    { 2002, (short)20 },
                    { 2280, (short)16 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 811, 1 },
                    { 811, 2 },
                    { 811, 3 },
                    { 811, 6 },
                    { 812, 1 },
                    { 812, 2 },
                    { 812, 3 },
                    { 812, 6 },
                    { 1954, 1 },
                    { 1954, 2 },
                    { 1954, 3 },
                    { 1954, 6 },
                    { 2002, 1 },
                    { 2002, 2 },
                    { 2002, 3 },
                    { 2002, 6 },
                    { 2280, 1 },
                    { 2280, 2 },
                    { 2280, 3 },
                    { 2280, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 811, 841, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/hosts.txt" },
                    { 812, 842, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/domains.txt" },
                    { 1954, 2027, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/adblock.txt" },
                    { 2002, 2098, (short)1, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/dnsmasq.conf" },
                    { 2280, 2421, (short)1, "https://badmojr.github.io/1Hosts/Lite/wildcards.txt" },
                    { 2280, 2422, (short)2, "https://raw.githubusercontent.com/badmojr/1Hosts/master/Lite/wildcards.txt" }
                });
        }
    }
}
