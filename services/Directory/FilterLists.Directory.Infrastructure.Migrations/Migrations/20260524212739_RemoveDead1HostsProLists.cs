using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDead1HostsProLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1734, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1735, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1955, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2003, 25 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1734, (short)1 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1735, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1955, (short)28 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2003, (short)20 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2281, (short)16 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1734, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1734, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1734, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1734, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1735, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1735, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1735, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1735, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1955, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1955, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1955, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1955, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2003, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2003, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2003, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2003, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2281, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2281, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2281, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2281, 6 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2281);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 1734, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro", null, null, null },
                    { 1735, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Domains)", null, null, null },
                    { 1955, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Adblockers)", null, null, null },
                    { 2003, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (dnsmasq)", null, null, null },
                    { 2281, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Domains with wildcards)", null, null, null },
                    { 2759, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Wildcards for dnscrypt-proxy)", null, null, null },
                    { 2760, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Response Policy Zone)", null, null, null },
                    { 2761, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Unbound)", null, null, null },
                    { 2762, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Windows)", null, null, null },
                    { 2763, null, "Discontinued. Replaced by 1Hosts (Xtra).", null, "badmojr@gmail.com", "https://forum.xda-developers.com/android/general/badmojr-one-host-file-to-block-t3713360", "https://github.com/badmojr/1Hosts", null, 35, "1Hosts Pro (Little Snitch)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 1734, 25 },
                    { 1735, 25 },
                    { 1955, 25 },
                    { 2003, 25 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 1734, (short)1 },
                    { 1735, (short)2 },
                    { 1955, (short)28 },
                    { 2003, (short)20 },
                    { 2281, (short)16 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 1734, 1 },
                    { 1734, 2 },
                    { 1734, 3 },
                    { 1734, 6 },
                    { 1735, 1 },
                    { 1735, 2 },
                    { 1735, 3 },
                    { 1735, 6 },
                    { 1955, 1 },
                    { 1955, 2 },
                    { 1955, 3 },
                    { 1955, 6 },
                    { 2003, 1 },
                    { 2003, 2 },
                    { 2003, 3 },
                    { 2003, 6 },
                    { 2281, 1 },
                    { 2281, 2 },
                    { 2281, 3 },
                    { 2281, 6 }
                });
        }
    }
}
