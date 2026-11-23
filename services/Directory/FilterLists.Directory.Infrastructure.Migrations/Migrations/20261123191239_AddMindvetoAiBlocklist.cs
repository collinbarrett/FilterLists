using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations;

/// <inheritdoc />
public partial class _20261123191239_AddMindvetoAiBlocklist : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "License",
            columns: new[] { "Id", "Name", "Url" },
            values: new object[] { 45, "Mindveto All Rights Reserved", "https://mindveto.app/downloads/LICENSE.txt" });

        migrationBuilder.InsertData(
            table: "Tag",
            columns: new[] { "Id", "Description", "Name" },
            values: new object[,]
            {
                { 48, "Blocks AI services and tools", "ai" },
                { 49, "Lists intended for parental control", "parental-control" }
            });

        migrationBuilder.InsertData(
            table: "FilterList",
            columns: new[] { "Id", "ChatUrl", "Description", "DonateUrl", "EmailAddress", "ForumUrl", "HomeUrl", "IssuesUrl", "LicenseId", "Name", "OnionUrl", "PolicyUrl", "SubmissionUrl" },
            values: new object[,]
            {
                { 2899, null, "Blocks 150+ AI chatbots, AI image/video generators, AI companion apps and AI writing tools (ChatGPT, Gemini, Claude, Copilot, Character.AI, Replika…). Maintained daily.", null, null, null, "https://mindveto.app/network/", null, 45, "Mindveto AI Blocklist (Hosts)", null, null, null },
                { 2900, null, "Blocks 150+ AI chatbots, AI image/video generators, AI companion apps and AI writing tools (ChatGPT, Gemini, Claude, Copilot, Character.AI, Replika…). Maintained daily.", null, null, null, "https://mindveto.app/network/", null, 45, "Mindveto AI Blocklist (Adblock Plus)", null, null, null },
                { 2901, null, "Blocks 150+ AI chatbots, AI image/video generators, AI companion apps and AI writing tools (ChatGPT, Gemini, Claude, Copilot, Character.AI, Replika…). Maintained daily.", null, null, null, "https://mindveto.app/network/", null, 45, "Mindveto AI Blocklist (Domains)", null, null, null }
            });

        migrationBuilder.InsertData(
            table: "FilterListSyntax",
            columns: new[] { "FilterListId", "SyntaxId" },
            values: new object[,]
            {
                { 2899, (short)54 },
                { 2900, (short)3 },
                { 2901, (short)2 }
            });

        migrationBuilder.InsertData(
            table: "FilterListTag",
            columns: new[] { "FilterListId", "TagId" },
            values: new object[,]
            {
                { 2899, 48 },
                { 2899, 49 },
                { 2900, 48 },
                { 2900, 49 },
                { 2901, 48 },
                { 2901, 49 }
            });

        migrationBuilder.InsertData(
            table: "FilterListViewUrl",
            columns: new[] { "FilterListId", "Id", "Primariness", "SegmentNumber", "Url" },
            values: new object[,]
            {
                { 2899, 3308, (short)1, (short)1, "https://mindveto.app/downloads/hosts.txt" },
                { 2900, 3309, (short)1, (short)1, "https://mindveto.app/downloads/adblock.txt" },
                { 2901, 3310, (short)1, (short)1, "https://mindveto.app/downloads/domains.txt" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2899, (short)54 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2900, (short)3 });

        migrationBuilder.DeleteData(
            table: "FilterListSyntax",
            keyColumns: new[] { "FilterListId", "SyntaxId" },
            keyValues: new object[] { 2901, (short)2 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2899, 48 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2899, 49 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2900, 48 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2900, 49 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2901, 48 });

        migrationBuilder.DeleteData(
            table: "FilterListTag",
            keyColumns: new[] { "FilterListId", "TagId" },
            keyValues: new object[] { 2901, 49 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2899, 3308 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2900, 3309 });

        migrationBuilder.DeleteData(
            table: "FilterListViewUrl",
            keyColumns: new[] { "FilterListId", "Id" },
            keyValues: new object[] { 2901, 3310 });

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2899);

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2900);

        migrationBuilder.DeleteData(
            table: "FilterList",
            keyColumn: "Id",
            keyValue: 2901);

        migrationBuilder.DeleteData(
            table: "Tag",
            keyColumn: "Id",
            keyValue: 48);

        migrationBuilder.DeleteData(
            table: "Tag",
            keyColumn: "Id",
            keyValue: 49);

        migrationBuilder.DeleteData(
            table: "License",
            keyColumn: "Id",
            keyValue: 45);
    }
}
