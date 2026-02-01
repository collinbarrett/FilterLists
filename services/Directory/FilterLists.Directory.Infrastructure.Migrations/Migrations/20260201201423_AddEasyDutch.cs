using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddEasyDutch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert FilterList if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterList] WHERE [Id] = 2845)
                BEGIN
                    SET IDENTITY_INSERT [FilterList] ON;
                    INSERT INTO [FilterList] ([Id], [ChatUrl], [Description], [DonateUrl], [EmailAddress], [ForumUrl], [HomeUrl], [IssuesUrl], [LicenseId], [Name], [OnionUrl], [PolicyUrl], [SubmissionUrl])
                    VALUES (2845, NULL, N'Dutch filterlist to use with uBlock Origin', NULL, NULL, NULL, N'https://github.com/EasyDutch-uBlockOrigin/EasyDutch/', N'https://github.com/EasyDutch-uBlockOrigin/EasyDutch/issues', 4, N'EasyDutch', NULL, NULL, NULL);
                    SET IDENTITY_INSERT [FilterList] OFF;
                END
            ");

            // Insert FilterListLanguage for 2825 if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListLanguage] WHERE [FilterListId] = 2825 AND [LanguageId] = 113)
                BEGIN
                    INSERT INTO [FilterListLanguage] ([FilterListId], [LanguageId]) VALUES (2825, 113);
                END
            ");

            // Insert Maintainer if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [Maintainer] WHERE [Id] = 211)
                BEGIN
                    SET IDENTITY_INSERT [Maintainer] ON;
                    INSERT INTO [Maintainer] ([Id], [EmailAddress], [Name], [TwitterHandle], [Url])
                    VALUES (211, N'easydutch@tech-web.aleeas.com', N'EasyDutch', NULL, N'https://github.com/EasyDutch-uBlockOrigin');
                    SET IDENTITY_INSERT [Maintainer] OFF;
                END
            ");

            // Insert FilterListLanguage for 2845 if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListLanguage] WHERE [FilterListId] = 2845 AND [LanguageId] = 48)
                BEGIN
                    INSERT INTO [FilterListLanguage] ([FilterListId], [LanguageId]) VALUES (2845, 48);
                END
            ");

            // Insert FilterListMaintainer if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListMaintainer] WHERE [FilterListId] = 2845 AND [MaintainerId] = 211)
                BEGIN
                    INSERT INTO [FilterListMaintainer] ([FilterListId], [MaintainerId]) VALUES (2845, 211);
                END
            ");

            // Insert FilterListSyntax records if not exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListSyntax] WHERE [FilterListId] = 2845 AND [SyntaxId] = 4)
                BEGIN
                    INSERT INTO [FilterListSyntax] ([FilterListId], [SyntaxId]) VALUES (2845, 4);
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListSyntax] WHERE [FilterListId] = 2845 AND [SyntaxId] = 21)
                BEGIN
                    INSERT INTO [FilterListSyntax] ([FilterListId], [SyntaxId]) VALUES (2845, 21);
                END
            ");

            // Insert FilterListTag records if not exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListTag] WHERE [FilterListId] = 2845 AND [TagId] = 2)
                BEGIN
                    INSERT INTO [FilterListTag] ([FilterListId], [TagId]) VALUES (2845, 2);
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListTag] WHERE [FilterListId] = 2845 AND [TagId] = 5)
                BEGIN
                    INSERT INTO [FilterListTag] ([FilterListId], [TagId]) VALUES (2845, 5);
                END
            ");

            // Insert FilterListViewUrl records if not exist
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3246)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3246, 1, 0, N'https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3247)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3247, 2, 0, N'https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3248)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3248, 3, 0, N'https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3249)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3249, 4, 0, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3250)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3250, 5, 0, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3251)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3251, 6, 0, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3252)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3252, 7, 0, N'https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3253)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3253, 8, 0, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3254)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3254, 9, 0, N'https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutch/gh-pages/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [FilterListId] = 2845 AND [Id] = 3255)
                BEGIN
                    SET IDENTITY_INSERT [FilterListViewUrl] ON;
                    INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [SegmentNumber], [Url])
                    VALUES (2845, 3255, 10, 0, N'https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutchCDN/main/EasyDutch.all.txt');
                    SET IDENTITY_INSERT [FilterListViewUrl] OFF;
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2825, (short)113 });

            migrationBuilder.DeleteData(
                table: "FilterListLanguage",
                keyColumns: new[] { "FilterListId", "LanguageId" },
                keyValues: new object[] { 2845, (short)48 });

            migrationBuilder.DeleteData(
                table: "FilterListMaintainer",
                keyColumns: new[] { "FilterListId", "MaintainerId" },
                keyValues: new object[] { 2845, 211 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2845, (short)4 });

            migrationBuilder.DeleteData(
                table: "FilterListSyntax",
                keyColumns: new[] { "FilterListId", "SyntaxId" },
                keyValues: new object[] { 2845, (short)21 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2845, 2 });

            migrationBuilder.DeleteData(
                table: "FilterListTag",
                keyColumns: new[] { "FilterListId", "TagId" },
                keyValues: new object[] { 2845, 5 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3246 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3247 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3248 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3249 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3250 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3251 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3252 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3253 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3254 });

            migrationBuilder.DeleteData(
                table: "FilterListViewUrl",
                keyColumns: new[] { "FilterListId", "Id" },
                keyValues: new object[] { 2845, 3255 });

            migrationBuilder.DeleteData(
                table: "FilterList",
                keyColumn: "Id",
                keyValue: 2845);

            migrationBuilder.DeleteData(
                table: "Maintainer",
                keyColumn: "Id",
                keyValue: 211);
        }
    }
}
