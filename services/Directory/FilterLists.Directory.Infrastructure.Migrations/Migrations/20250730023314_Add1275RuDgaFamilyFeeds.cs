using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Add1275RuDgaFamilyFeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2819, null, "Feed of QSnatch DGA domains, a major malware family that targets QNAP NAS devices.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - QSnatch", null, null, null },
                    { 2820, null, "Feed of Bamital DGA domains, a malware family that generates domains algorithmically.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - Bamital", null, null, null },
                    { 2821, null, "Feed of Virut DGA domains, a polymorphic virus and malware family.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - Virut", null, null, null },
                    { 2822, null, "Feed of Corebot DGA domains, a banking trojan malware family.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - Corebot", null, null, null },
                    { 2823, null, "Feed of Matsnu DGA domains, a malware family known for domain generation attacks.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - Matsnu", null, null, null },
                    { 2824, null, "Feed of Ramnit DGA domains, a banking trojan and worm malware family.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - Ramnit", null, null, null },
                    { 2825, null, "Feed of CryptoLocker DGA domains, a ransomware family that uses domain generation.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - CryptoLocker", null, null, null },
                    { 2826, null, "Feed of SharkBot DGA domains, an Android banking trojan malware family.", null, null, null, "https://1275.ru/spisok-aktivnyh-dga-domain-generation-algorithm-domenov/", null, 5, "1275.ru DGA Feed - SharkBot", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 206, null, "1275.ru", null, "https://1275.ru/" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2653, 206 },
                    { 2819, 206 },
                    { 2820, 206 },
                    { 2821, 206 },
                    { 2822, 206 },
                    { 2823, 206 },
                    { 2824, 206 },
                    { 2825, 206 },
                    { 2826, 206 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2819, (short)2 },
                    { 2820, (short)2 },
                    { 2821, (short)2 },
                    { 2822, (short)2 },
                    { 2823, (short)2 },
                    { 2824, (short)2 },
                    { 2825, (short)2 },
                    { 2826, (short)2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2819, 6 },
                    { 2820, 6 },
                    { 2821, 6 },
                    { 2822, 6 },
                    { 2823, 6 },
                    { 2824, 6 },
                    { 2825, 6 },
                    { 2826, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2819, 3210, (short)1, "https://1275.ru/DGA/qsnatch.txt" },
                    { 2820, 3211, (short)1, "https://1275.ru/DGA/bamital.txt" },
                    { 2821, 3212, (short)1, "https://1275.ru/DGA/virut.txt" },
                    { 2822, 3213, (short)1, "https://1275.ru/DGA/corebot.txt" },
                    { 2823, 3214, (short)1, "https://1275.ru/DGA/matsnu.txt" },
                    { 2824, 3215, (short)1, "https://1275.ru/DGA/ramnit.txt" },
                    { 2825, 3216, (short)1, "https://1275.ru/DGA/cryptolocker.txt" },
                    { 2826, 3217, (short)1, "https://1275.ru/DGA/sharkbot.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2653, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2819, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2820, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2821, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2822, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2823, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2824, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2825, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2826, 206 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2819, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2820, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2821, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2822, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2823, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2824, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2825, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2826, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2819, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2820, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2821, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2822, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2823, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2824, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2825, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2826, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2819, 3210 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2820, 3211 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2821, 3212 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2822, 3213 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2823, 3214 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2824, 3215 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2825, 3216 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2826, 3217 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2819);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2822);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2823);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2825);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2826);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 206);
        }
    }
}
