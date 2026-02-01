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
            // Update ID 2471 if it exists with name "EasyDutch"
            migrationBuilder.Sql(@"
                UPDATE [FilterList]
                SET [Name] = N'EasyDutch (EasyDutch-uBO)'
                WHERE [Id] = 2471 AND [Name] = N'EasyDutch';
            ");

            // Insert or update ID 2845 FilterList
            migrationBuilder.Sql(@"
                IF EXISTS (SELECT 1 FROM [FilterList] WHERE [Id] = 2845)
                BEGIN
                    UPDATE [FilterList]
                    SET [Name] = N'EasyDutch (EasyDutch-uBlockOrigin)'
                    WHERE [Id] = 2845;
                END
                ELSE
                BEGIN
                    SET IDENTITY_INSERT [FilterList] ON;
                    INSERT INTO [FilterList] ([Id], [ChatUrl], [Description], [DonateUrl], [EmailAddress], [ForumUrl], [HomeUrl], [IssuesUrl], [LicenseId], [Name], [OnionUrl], [PolicyUrl], [SubmissionUrl])
                    VALUES (2845, NULL, N'Dutch filterlist to use with uBlock Origin', NULL, NULL, NULL, N'https://github.com/EasyDutch-uBlockOrigin/EasyDutch/', N'https://github.com/EasyDutch-uBlockOrigin/EasyDutch/issues', 4, N'EasyDutch (EasyDutch-uBlockOrigin)', NULL, NULL, NULL);
                    SET IDENTITY_INSERT [FilterList] OFF;
                END
            ");

            // Insert FilterListMaintainer if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListMaintainer] WHERE [FilterListId] = 2845 AND [MaintainerId] = 211)
                BEGIN
                    INSERT INTO [FilterListMaintainer] ([FilterListId], [MaintainerId])
                    VALUES (2845, 211);
                END
            ");

            // Insert FilterListLanguage if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListLanguage] WHERE [FilterListId] = 2845 AND [LanguageId] = 48)
                BEGIN
                    INSERT INTO [FilterListLanguage] ([FilterListId], [LanguageId])
                    VALUES (2845, 48);
                END
            ");

            // Insert FilterListSyntax if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListSyntax] WHERE [FilterListId] = 2845 AND [SyntaxId] = 4)
                BEGIN
                    INSERT INTO [FilterListSyntax] ([FilterListId], [SyntaxId])
                    VALUES (2845, 4);
                END
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListSyntax] WHERE [FilterListId] = 2845 AND [SyntaxId] = 21)
                BEGIN
                    INSERT INTO [FilterListSyntax] ([FilterListId], [SyntaxId])
                    VALUES (2845, 21);
                END
            ");

            // Insert FilterListTag if not exists
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM [FilterListTag] WHERE [FilterListId] = 2845 AND [TagId] = 2)
                BEGIN
                    INSERT INTO [FilterListTag] ([FilterListId], [TagId])
                    VALUES (2845, 2);
                END
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListTag] WHERE [FilterListId] = 2845 AND [TagId] = 5)
                BEGIN
                    INSERT INTO [FilterListTag] ([FilterListId], [TagId])
                    VALUES (2845, 5);
                END
            ");

            // Insert FilterListViewUrl if not exists - each record checked individually
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT [FilterListViewUrl] ON;
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3246)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3246, 2845, 1, 1, N'https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3247)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3247, 2845, 2, 1, N'https://easydutch-ublockorigin.github.io/EasyDutch/EasyDutch.all.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3248)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3248, 2845, 3, 1, N'https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.all.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3249)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3249, 2845, 4, 1, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.all.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3250)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3250, 2845, 5, 1, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.all.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3251)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3251, 2845, 6, 1, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutch@gh-pages/EasyDutch.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3252)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3252, 2845, 7, 1, N'https://easydutch-ublockorigin.github.io/EasyDutchCDN/EasyDutch.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3253)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3253, 2845, 8, 1, N'https://cdn.jsdelivr.net/gh/EasyDutch-uBlockOrigin/EasyDutchCDN@main/EasyDutch.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3254)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3254, 2845, 9, 1, N'https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutch/gh-pages/EasyDutch.all.txt');
                
                IF NOT EXISTS (SELECT 1 FROM [FilterListViewUrl] WHERE [Id] = 3255)
                    INSERT INTO [FilterListViewUrl] ([Id], [FilterListId], [Primariness], [SegmentNumber], [Url])
                    VALUES (3255, 2845, 10, 1, N'https://raw.githubusercontent.com/EasyDutch-uBlockOrigin/EasyDutchCDN/main/EasyDutch.all.txt');
                
                SET IDENTITY_INSERT [FilterListViewUrl] OFF;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert ID 2471 name change
            migrationBuilder.Sql(@"
                UPDATE [FilterList]
                SET [Name] = N'EasyDutch'
                WHERE [Id] = 2471;
            ");

            // Delete ID 2845 and related data if they were inserted by this migration
            migrationBuilder.Sql(@"
                DELETE FROM [FilterListViewUrl] WHERE [FilterListId] = 2845;
                DELETE FROM [FilterListTag] WHERE [FilterListId] = 2845;
                DELETE FROM [FilterListSyntax] WHERE [FilterListId] = 2845;
                DELETE FROM [FilterListLanguage] WHERE [FilterListId] = 2845;
                DELETE FROM [FilterListMaintainer] WHERE [FilterListId] = 2845;
                DELETE FROM [FilterList] WHERE [Id] = 2845;
            ");
        }
    }
}
