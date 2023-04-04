using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _3503 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2537L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "This list aims to protect against scams, phishing, malware, and potentially unwanted programs (PUPs). It includes a version of vxvault.net's list, modified by me (iam-py-test) to work in adblockers.", "iam-py-test@protonmail.com", "The malicious website blocklist" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2538L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "This list aims to protect against scams, phishing, malware, and potentially unwanted programs (PUPs). It includes a version of vxvault.net's list, modified by me (iam-py-test) to work in adblockers. (HOSTs version - not for uBlock Origin)", "iam-py-test@protonmail.com", "The malicious website blocklist (HOSTs file)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2541L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "This list aims to protect against scams, phishing, malware, and potentially unwanted programs (PUPs). It includes a version of vxvault.net's list, modified by me (iam-py-test) to work in adblockers. (Domains version)", "iam-py-test@protonmail.com", "The malicious website blocklist (Domains)" });

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2652L, null, "VXVault's list of URLs serving malware, converted into a filterlist", null, "iam-py-test@protonmail.com", null, "https://github.com/iam-py-test/vxvault_filter", true, "https://github.com/iam-py-test/vxvault_filter/issues", 28L, "VXVault filterlist (unofficial)", null, null, null });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2652L, 165L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2652L, 4L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2652L, 6L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[,]
                {
                    { 2652L, 2924L, (short)1, "https://raw.githubusercontent.com/iam-py-test/vxvault_filter/main/ubolist.txt" },
                    { 2652L, 2925L, (short)2, "https://iam-py-test.github.io/vxvault_filter/ubolist.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2652L, 165L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2652L, 4L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2652L, 6L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2652L, 2924L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2652L, 2925L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2652L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2537L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "Block malware, phishing, and scams for a more secure computer", null, "Malicious website blocklist" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2538L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "Block malware, phishing, and scams for a more secure computer (HOSTS version - not for uBlock Origin)", null, "Malicious website blocklist (HOSTS)" });

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2541L,
                columns: new[] { "description", "email_address", "name" },
                values: new object[] { "Block malware, phishing, and scams for a more secure computer (Domains version)", null, "Malicious website blocklist (Domains)" });
        }
    }
}
