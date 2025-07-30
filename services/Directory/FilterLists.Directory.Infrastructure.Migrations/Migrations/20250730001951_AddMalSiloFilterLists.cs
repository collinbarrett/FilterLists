using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddMalSiloFilterLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2806, null, "MalSilo threat intelligence feed containing malicious IPv4 addresses with threat categorization and metadata. This feed provides IP addresses associated with various malware families and threat actors.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo IPv4 Feed", null, null, null },
                    { 2807, null, "MalSilo threat intelligence feed containing malicious URLs with threat categorization and metadata. This feed provides URLs associated with various malware families and threat actors.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo URL Feed", null, null, null },
                    { 2808, null, "MalSilo threat intelligence feed containing malicious domains with threat categorization and metadata. This feed provides domains associated with various malware families and threat actors.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo Domain Feed", null, null, null },
                    { 2809, null, "MalSilo Suricata DNS detection rules for identifying and blocking malicious DNS queries. These rules are designed for use with Suricata IDS/IPS systems.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo DNS Rules", null, null, null },
                    { 2810, null, "MalSilo Suricata IP detection rules for identifying and blocking malicious IP traffic. These rules are designed for use with Suricata IDS/IPS systems.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo IP Rules", null, null, null },
                    { 2811, null, "MalSilo Suricata URL detection rules for identifying and blocking malicious URL traffic. These rules are designed for use with Suricata IDS/IPS systems.", null, null, null, "https://malsilo.gitlab.io/feeds/", null, 5, "MalSilo URL Rules", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 205, "malsilo@tuta.io", "MalSilo", null, "https://malsilo.gitlab.io/feeds/" });

            migrationBuilder.InsertData(
                table: "Syntax",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { (short)58, null, "Suricata", "https://suricata.io/documentation/" });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2806, 205 },
                    { 2807, 205 },
                    { 2808, 205 },
                    { 2809, 205 },
                    { 2810, 205 },
                    { 2811, 205 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2806, (short)9 },
                    { 2807, (short)2 },
                    { 2808, (short)2 },
                    { 2809, (short)48 },
                    { 2810, (short)48 },
                    { 2811, (short)48 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2806, 6 },
                    { 2807, 6 },
                    { 2808, 6 },
                    { 2809, 6 },
                    { 2810, 6 },
                    { 2811, 6 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2806, 3193, (short)1, "https://malsilo.gitlab.io/feeds/dumps/ip_list.txt" },
                    { 2807, 3194, (short)1, "https://malsilo.gitlab.io/feeds/dumps/url_list.txt" },
                    { 2808, 3195, (short)1, "https://malsilo.gitlab.io/feeds/dumps/domain_list.txt" },
                    { 2809, 3196, (short)1, "https://malsilo.gitlab.io/feeds/dumps/malsilo-dns.rules" },
                    { 2810, 3197, (short)1, "https://malsilo.gitlab.io/feeds/dumps/malsilo-ip.rules" },
                    { 2811, 3198, (short)1, "https://malsilo.gitlab.io/feeds/dumps/malsilo-url.rules" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2806, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2807, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2808, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2809, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2810, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2811, 205 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2806, (short)9 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2807, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2808, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2809, (short)48 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2810, (short)48 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2811, (short)48 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2806, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2807, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2808, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2809, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2810, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2811, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2806, 3193 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2807, 3194 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2808, 3195 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2809, 3196 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2810, 3197 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2811, 3198 });

            migrationBuilder.DeleteData(
                table: "Syntax",
                keyColumn: "Id",
                keyValue: (short)58);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2807);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2808);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2809);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2811);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 205);
        }
    }
}
