using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdGuardMetadataAndAddMailTrackingFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "Name" },
                values: new object[] { "EasyList + AdGuard English filter. This complete filter is necessary for quality ad blocking.", "AdGuard Base filter + EasyList (AdGuard for Chromium)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 168,
                column: "Description",
                value: "Filter composed of several other filters (AdGuard Base filter, Social Media filter, Tracking Protection filter, Mobile Ads filter, EasyList and EasyPrivacy) and simplified specifically to be better compatible with DNS-level ad blocking.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2210,
                columns: new[] { "Description", "Name" },
                values: new object[] { "EasyList + AdGuard English filter. This complete filter is necessary for quality ad blocking.", "AdGuard Base filter + EasyList" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2212,
                column: "Description",
                value: "Blocks irritating elements on web pages including cookie notices, third-party widgets and in-page pop-ups. Contains the following AdGuard filters: Cookie Notices, Popups, Mobile App Banners, Other Annoyances and Widgets.");

            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[] { 2858, null, "This filter blocks trackers in email clients.", null, null, null, "https://github.com/AdguardTeam/AdguardFilters", "https://github.com/AdguardTeam/AdguardFilters/issues", 12, "AdGuard Mail Tracking Filter", null, "https://kb.adguard.com/en/general/adguard-filter-policy", null });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[] { 2858, 46 });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[] { 2858, (short)6 });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[] { 2858, 3 });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[] { 2858, 3264, (short)1, "https://filters.adtidy.org/ios/filters/25_optimized.txt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2858, 46 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2858, (short)6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2858, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2858, 3264 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2858);

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filter that enables removing of the ads from websites with English content or content in languages that lack separate AdGuard lists.", "AdGuard Base Filter (AdGuard for Chromium)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 168,
                column: "Description",
                value: "A filter composed from several other filters (English filter, Social media filter, Spyware filter, Mobile ads filter, regional AdGuard lists, EasyList, EasyPrivacy) and simplified specifically to be better compatible with DNS-level ad blocking. This filter is used by AdGuard DNS servers to block ads.");

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2210,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filter that enables removing of the ads from websites with English content or content in languages that lack separate AdGuard lists.", "AdGuard Base Filter (uBlock Origin)" });

            migrationBuilder.UpdateData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2212,
                column: "Description",
                value: "Blocks irritating elements on webpages, including cookie notices, third-party widgets and in-page popups (Doesn’t include social media widgets and buttons, to block them you can still use Social media filter separately). It was inspired by Fanboy Annoyances List, but doesn’t duplicate it, so you can use them both together.");
        }
    }
}
