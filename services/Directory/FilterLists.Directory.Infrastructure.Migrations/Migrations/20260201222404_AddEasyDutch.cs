using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            // Insert or update ID 2845
            // If it exists, update the name; if not, insert the full record
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

            // Delete ID 2845 if it was inserted by this migration, or revert name if it existed
            migrationBuilder.Sql(@"
                DELETE FROM [FilterList]
                WHERE [Id] = 2845 AND [Name] = N'EasyDutch (EasyDutch-uBlockOrigin)';
            ");
        }
    }
}
