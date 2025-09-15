using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddAdVoidFilterLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilterList",
                columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
                values: new object[,]
                {
                    { 2828, null, "Blocks intrusive ads, trackers, fake downloads, cookie prompts, overlays, push alerts, widgets, and obsolete web clutter.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.Full", null, null, null },
                    { 2829, null, "Blocks major ad-servers, trackers, malware, fake download links, cuts-down timer executions.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.Core", null, null, null },
                    { 2830, null, "DNS-level blocker for ads, trackers, telemetry, malware, and web nuisances. Lightweight, system-wide protection.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.DNS", null, null, null },
                    { 2831, null, "Blocks site annoyances: cookie-consent banners, popups, modals, push notifications, survey, newsletter and subscribe popups, rating dialogs, skips countdowns, etc.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.Addon.NoAnnoyances", null, null, null },
                    { 2832, null, "Blocks external features: sharing, Google Chromecast, popup chats, post widgets, like widgets, etc.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.Addon.NoExternals", null, null, null },
                    { 2833, null, "Blocks non-essential resources: news widgets, JavaScript and CSS maps, PWA install banners, SWF objects, etc.", "https://ko-fi.com/igorskyflyer", "support@igorskyflyer.me", null, "https://github.com/the-advoid/ad-void", "https://github.com/the-advoid/ad-void/issues", 4, "AdVoid.Addon.NoExtras", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Maintainer",
                columns: new[] { "Id", "EmailAddress", "Name", "TwitterHandle", "Url" },
                values: new object[] { 207, "support@igorskyflyer.me", "Igor Dimitrijević (igorskyflyer)", "igorskyflyer", "https://github.com/igorskyflyer" });

            migrationBuilder.InsertData(
                table: "FilterListLanguage",
                columns: new[] { "FilterListId", "LanguageId" },
                values: new object[,]
                {
                    { 2828, (short)37 },
                    { 2829, (short)37 },
                    { 2830, (short)37 },
                    { 2831, (short)37 },
                    { 2832, (short)37 },
                    { 2833, (short)37 }
                });

            migrationBuilder.InsertData(
                table: "FilterListMaintainer",
                columns: new[] { "FilterListId", "MaintainerId" },
                values: new object[,]
                {
                    { 2828, 207 },
                    { 2829, 207 },
                    { 2830, 207 },
                    { 2831, 207 },
                    { 2832, 207 },
                    { 2833, 207 }
                });

            migrationBuilder.InsertData(
                table: "FilterListSyntax",
                columns: new[] { "FilterListId", "SyntaxId" },
                values: new object[,]
                {
                    { 2828, (short)4 },
                    { 2829, (short)4 },
                    { 2830, (short)2 },
                    { 2831, (short)4 },
                    { 2832, (short)4 },
                    { 2833, (short)4 }
                });

            migrationBuilder.InsertData(
                table: "FilterListTag",
                columns: new[] { "FilterListId", "TagId" },
                values: new object[,]
                {
                    { 2828, 3 },
                    { 2829, 2 },
                    { 2830, 6 },
                    { 2831, 9 },
                    { 2832, 4 },
                    { 2833, 9 }
                });

            migrationBuilder.InsertData(
                table: "FilterListViewUrl",
                columns: new[] { "FilterListId", "Id", "Primariness", "Url" },
                values: new object[,]
                {
                    { 2828, 3219, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/AdVoid.Full.txt" },
                    { 2828, 3220, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/AdVoid.Full.txt" },
                    { 2829, 3221, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/AdVoid.Core.txt" },
                    { 2829, 3222, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/AdVoid.Core.txt" },
                    { 2830, 3223, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/AdVoid.DNS.txt" },
                    { 2830, 3224, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/AdVoid.DNS.txt" },
                    { 2831, 3225, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/add-ons/AdVoid.Addon.NoAnnoyances.txt" },
                    { 2831, 3226, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/add-ons/AdVoid.Addon.NoAnnoyances.txt" },
                    { 2832, 3227, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/add-ons/AdVoid.Addon.NoExternals.txt" },
                    { 2832, 3228, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/add-ons/AdVoid.Addon.NoExternals.txt" },
                    { 2833, 3229, (short)1, "https://raw.githubusercontent.com/the-advoid/ad-void/main/add-ons/AdVoid.Addon.NoExtras.txt" },
                    { 2833, 3230, (short)2, "https://cdn.jsdelivr.net/gh/the-advoid/ad-void@main/add-ons/AdVoid.Addon.NoExtras.txt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2828, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2829, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2830, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2831, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2832, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2833, (short)37 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2828, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2829, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2830, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2831, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2832, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2833, 207 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2828, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2829, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2830, (short)2 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2831, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2832, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2833, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2828, 3 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2829, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2830, 6 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2831, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2832, 4 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2833, 9 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2828, 3219 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2828, 3220 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2829, 3221 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2829, 3222 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2830, 3223 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2830, 3224 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2831, 3225 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2831, 3226 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2832, 3227 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2832, 3228 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2833, 3229 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2833, 3230 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2828);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2829);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2830);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2831);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2832);

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2833);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 207);
        }
    }
}
