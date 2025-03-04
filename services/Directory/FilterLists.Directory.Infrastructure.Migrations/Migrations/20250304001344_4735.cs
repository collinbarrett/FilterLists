using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class _4735 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2729, "xmpp:github-less-social@chat.toastal.in.th?join", "Removes social, upsells, & AI features from the proprietary MS GitHub Git forge, directly-adjacent Microsoft-owned platforms, & some adjacent services using this platform to integrate social features.", "https://toast.al/funding/", "~toastal/github-less-social@lists.sr.ht", null, "https://codeberg.org/toastal/github-less-social", "https://codeberg.org/toastal/github-less-social/issues", 37, "Microsoft GitHub Less Social", null, null, "https://codeberg.org/toastal/github-less-social#pitching-in" },
                    { 2730, "xmpp:github-less-social@chat.toastal.in.th?join", "Aggressively removes social, upsells & AI features from the proprietary MS GitHub Git forge, directly-adjacent Microsoft-owned platforms, & some adjacent services using this platform to integrate social features.", "https://toast.al/funding/", "~toastal/github-less-social@lists.sr.ht", null, "https://codeberg.org/toastal/github-less-social", "https://codeberg.org/toastal/github-less-social/issues", 37, "Microsoft GitHub Less Social", null, null, "https://codeberg.org/toastal/github-less-social#pitching-in" }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 197, null, "toastal", null, "https://toast.al/" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2729, (short)37 },
                    { 2730, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2729, 197 },
                    { 2730, 197 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2729, (short)4 },
                    { 2730, (short)4 },
                    { 2730, (short)21 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2729, 3 },
                    { 2729, 19 },
                    { 2729, 35 },
                    { 2730, 3 },
                    { 2730, 9 },
                    { 2730, 19 },
                    { 2730, 35 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2729, 3062, (short)1, "https://codeberg.org/toastal/github-less-social/raw/branch/trunk/list.txt" },
                    { 2729, 3063, (short)2, "https://git.sr.ht/~toastal/github-less-social/blob/trunk/list.txt" },
                    { 2730, 3062, (short)1, "https://codeberg.org/toastal/github-less-social/raw/branch/trunk/aggressive.txt" },
                    { 2730, 3063, (short)2, "https://git.sr.ht/~toastal/github-less-social/blob/trunk/aggressive.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2729, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2730, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2729, 197 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2730, 197 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2729, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2730, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2730, (short)21 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2729, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2729, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2729, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2730, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2730, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2730, 19 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2730, 35 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2729, 3062 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2729, 3063 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2730, 3062 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2730, 3063 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2729);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 197);
        }
    }
}
