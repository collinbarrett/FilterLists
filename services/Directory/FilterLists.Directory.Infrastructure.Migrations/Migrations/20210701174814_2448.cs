using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2448 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1239, "de" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1242, "de" });

            migrationBuilder.DeleteData(
                table: "FilterListLanguages",
                keyColumns: new[] { "FilterListId", "Iso6391" },
                keyValues: new object[] { 1242, "en" });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1233, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1234, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1235, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1237, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1238, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1239, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1240, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1241, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainers",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 1242, 110 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1233, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1234, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1235, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1237, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1238, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1239, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1240, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1241, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntaxes",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 1242, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1233, 26 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1234, 26 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1235, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1237, 7 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1238, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1239, 21 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1240, 1 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1241, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTags",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 1242, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "FilterListViewUrls",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "FilterLists",
                keyColumn: "Id",
                keyValue: 1242);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterLists",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 1233, null, "To block Adobe Updates (Photoshop & co.)", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Adobe updates", null, null, null },
                    { 1234, null, "To block Nintendo system updates (3DS / Wii U / Switch)", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Nintendo updates", null, null, null },
                    { 1235, null, "To block tracking and information that Windows collects", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Windows tracking", null, null, null },
                    { 1237, null, "Block fake jailbreak websites (Domains of The iPhone Wiki)", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Fake jailbreak sites", null, null, null },
                    { 1238, null, "To block fake gaming websites (fake emulators, etc.)", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Fake game sites", null, null, null },
                    { 1239, null, "To block German fake news websites", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - German fake news", null, null, null },
                    { 1240, null, "To block cryptomining", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Cryptomining", null, null, null },
                    { 1241, null, "To block other things that I could not assign anywhere", null, null, null, "https://github.com/Akamaru/Pi-Hole-Lists", "https://github.com/Akamaru/Pi-Hole-Lists/issues", 5, "Pi-Hole-Lists - Other", null, null, null },
                    { 1242, null, null, null, null, null, "https://github.com/Akamaru/Adblock-Filterliste", "https://github.com/Akamaru/Adblock-Filterliste/issues", 33, "Aka's Filter Liste", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FilterListLanguages",
                columns: new[] { "FilterListId", "Iso6391" },
                values: new object[,]
                {
                    { 1242, "de" },
                    { 1239, "de" },
                    { 1242, "en" }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainers",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 1240, 110 },
                    { 1239, 110 },
                    { 1238, 110 },
                    { 1241, 110 },
                    { 1237, 110 },
                    { 1233, 110 },
                    { 1242, 110 },
                    { 1235, 110 },
                    { 1234, 110 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntaxes",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 1235, 2 },
                    { 1240, 2 },
                    { 1233, 2 },
                    { 1239, 2 },
                    { 1242, 3 },
                    { 1241, 2 },
                    { 1234, 2 },
                    { 1237, 2 },
                    { 1238, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTags",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 1238, 6 },
                    { 1237, 7 },
                    { 1233, 26 },
                    { 1239, 21 },
                    { 1234, 26 },
                    { 1235, 3 },
                    { 1240, 1 },
                    { 1241, 9 },
                    { 1242, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrls",
                columns: new[] { "Id", "FilterListId", "Primariness", "Url" },
                values: new object[,]
                {
                    { 1262, 1241, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/other.txt" },
                    { 1259, 1238, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/gamefake.txt" },
                    { 1260, 1239, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/fakenewsde.txt" },
                    { 1258, 1237, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/jbfake.txt" },
                    { 1257, 1235, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/nomsdata.txt" },
                    { 1256, 1234, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/nintendoblock.txt" },
                    { 1255, 1233, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/adobeblock.txt" },
                    { 1261, 1240, (short)1, "https://raw.githubusercontent.com/Akamaru/Pi-Hole-Lists/master/cryptomine.txt" },
                    { 1263, 1242, (short)1, "https://raw.githubusercontent.com/Akamaru/Adblock-Filterliste/master/filterlist.txt" }
                });
        }
    }
}
