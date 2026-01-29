# Migration Fix for PR #5445

## Problem

The migration `20260128232912_AddIDNHomographFaviconSecurityLists` was deployed with empty `Up()` and `Down()` methods, which means:
- The migration entry exists in `__EFMigrationsHistory` table
- But no data was actually inserted into the database
- FilterList IDs 2841, 2842, 2843, 2844 are missing from the database

## Solution

This has been fixed by:
1. Removing the broken migration file
2. Regenerating a new migration with the correct data: `20260129233713_AddIDNHomographFaviconSecurityLists`

## Manual Database Fix Required

Since the old migration already exists in production's `__EFMigrationsHistory` table, the database needs to be manually fixed before deploying the new migration.

### Option 1: Manual SQL Script (Recommended)

Execute the following SQL statements on the production database:

```sql
BEGIN TRANSACTION;

-- Remove the old broken migration entry
DELETE FROM [__EFMigrationsHistory] 
WHERE [MigrationId] = N'20260128232912_AddIDNHomographFaviconSecurityLists';

-- Insert FilterLists
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ChatUrl', N'Description', N'DonateUrl', N'EmailAddress', N'ForumUrl', N'HomeUrl', N'IssuesUrl', N'LicenseId', N'Name', N'OnionUrl', N'PolicyUrl', N'SubmissionUrl') AND [object_id] = OBJECT_ID(N'[FilterList]'))
    SET IDENTITY_INSERT [FilterList] ON;

INSERT INTO [FilterList] ([Id], [ChatUrl], [Description], [DonateUrl], [EmailAddress], [ForumUrl], [HomeUrl], [IssuesUrl], [LicenseId], [Name], [OnionUrl], [PolicyUrl], [SubmissionUrl])
VALUES 
(2841, NULL, N'Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.', N'https://github.com/TantalusDrive', NULL, NULL, N'https://github.com/TantalusDrive/Secfilters', N'https://github.com/TantalusDrive/Secfilters/issues', 9, N'IDN Homograph & Favicon Security List - AdGuard version (MV2)', NULL, NULL, NULL),
(2842, NULL, N'Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.', N'https://github.com/TantalusDrive', NULL, NULL, N'https://github.com/TantalusDrive/Secfilters', N'https://github.com/TantalusDrive/Secfilters/issues', 9, N'IDN Homograph & Favicon Security List - ABP version (MV2)', NULL, NULL, NULL),
(2843, NULL, N'Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.', N'https://github.com/TantalusDrive', NULL, NULL, N'https://github.com/TantalusDrive/Secfilters', N'https://github.com/TantalusDrive/Secfilters/issues', 9, N'IDN Homograph & Favicon Security List - Brave version', NULL, NULL, NULL),
(2844, NULL, N'Security-focused filter list mitigating IDN/Punycode homograph phishing and favicon-based spoofing vectors without breaking site functionality.', N'https://github.com/TantalusDrive', NULL, NULL, N'https://github.com/TantalusDrive/Secfilters', N'https://github.com/TantalusDrive/Secfilters/issues', 9, N'IDN Homograph & Favicon Security List - uBlock Origin version', NULL, NULL, NULL);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ChatUrl', N'Description', N'DonateUrl', N'EmailAddress', N'ForumUrl', N'HomeUrl', N'IssuesUrl', N'LicenseId', N'Name', N'OnionUrl', N'PolicyUrl', N'SubmissionUrl') AND [object_id] = OBJECT_ID(N'[FilterList]'))
    SET IDENTITY_INSERT [FilterList] OFF;

-- Insert Maintainer
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'EmailAddress', N'Name', N'TwitterHandle', N'Url') AND [object_id] = OBJECT_ID(N'[Maintainer]'))
    SET IDENTITY_INSERT [Maintainer] ON;

INSERT INTO [Maintainer] ([Id], [EmailAddress], [Name], [TwitterHandle], [Url])
VALUES (210, N'carlolatorre.uw4yf@slmails.com', N'TantalusDrive', NULL, N'https://github.com/TantalusDrive');

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'EmailAddress', N'Name', N'TwitterHandle', N'Url') AND [object_id] = OBJECT_ID(N'[Maintainer]'))
    SET IDENTITY_INSERT [Maintainer] OFF;

-- Insert FilterListLanguage relationships
INSERT INTO [FilterListLanguage] ([FilterListId], [LanguageId])
VALUES 
(2841, CAST(37 AS smallint)),
(2842, CAST(37 AS smallint)),
(2843, CAST(37 AS smallint)),
(2844, CAST(37 AS smallint));

-- Insert FilterListMaintainer relationships
INSERT INTO [FilterListMaintainer] ([FilterListId], [MaintainerId])
VALUES 
(2841, 210),
(2842, 210),
(2843, 210),
(2844, 210);

-- Insert FilterListSyntax relationships
INSERT INTO [FilterListSyntax] ([FilterListId], [SyntaxId])
VALUES 
(2841, CAST(6 AS smallint)),
(2842, CAST(3 AS smallint)),
(2843, CAST(3 AS smallint)),
(2844, CAST(4 AS smallint));

-- Insert FilterListTag relationships
INSERT INTO [FilterListTag] ([FilterListId], [TagId])
VALUES 
(2841, 7),
(2841, 10),
(2842, 7),
(2842, 10),
(2843, 7),
(2843, 10),
(2844, 7),
(2844, 10);

-- Insert FilterListViewUrl entries
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FilterListId', N'Id', N'Primariness', N'Url') AND [object_id] = OBJECT_ID(N'[FilterListViewUrl]'))
    SET IDENTITY_INSERT [FilterListViewUrl] ON;

INSERT INTO [FilterListViewUrl] ([FilterListId], [Id], [Primariness], [Url])
VALUES 
(2841, 3238, CAST(1 AS smallint), N'https://tantalusdrive.github.io/Secfilters/Lists/AdGuard/IDNHomographFavicon.txt'),
(2841, 3239, CAST(2 AS smallint), N'https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/AdGuard/IDNHomographFavicon.txt'),
(2842, 3240, CAST(1 AS smallint), N'https://tantalusdrive.github.io/Secfilters/Lists/ABP/IDNHomographFavicon.txt'),
(2842, 3241, CAST(2 AS smallint), N'https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/ABP/IDNHomographFavicon.txt'),
(2843, 3242, CAST(1 AS smallint), N'https://tantalusdrive.github.io/Secfilters/Lists/Brave/IDNHomographFavicon.txt'),
(2843, 3243, CAST(2 AS smallint), N'https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/Brave/IDNHomographFavicon.txt'),
(2844, 3244, CAST(1 AS smallint), N'https://tantalusdrive.github.io/Secfilters/Lists/uBlock/IDNHomographFavicon.txt'),
(2844, 3245, CAST(2 AS smallint), N'https://raw.githubusercontent.com/TantalusDrive/Secfilters/refs/heads/main/Lists/uBlock/IDNHomographFavicon.txt');

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FilterListId', N'Id', N'Primariness', N'Url') AND [object_id] = OBJECT_ID(N'[FilterListViewUrl]'))
    SET IDENTITY_INSERT [FilterListViewUrl] OFF;

-- Add the new migration entry
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260129233713_AddIDNHomographFaviconSecurityLists', N'8.0.22');

COMMIT;
```

### Option 2: Let EF Core Handle It (Alternative)

If you prefer to let the application handle the migration automatically:

1. First, manually remove the old broken migration entry:
   ```sql
   DELETE FROM [__EFMigrationsHistory] 
   WHERE [MigrationId] = N'20260128232912_AddIDNHomographFaviconSecurityLists';
   ```

2. Deploy the new code with the fixed migration
3. The `MigrationService` will automatically apply the new migration on startup

## Verification

After applying the fix, verify the data was inserted correctly:

```sql
-- Check FilterLists were created
SELECT * FROM [dbo].[FilterList] WHERE id IN (2841, 2842, 2843, 2844);

-- Check Maintainer was created
SELECT * FROM [dbo].[Maintainer] WHERE id = 210;

-- Check relationships
SELECT * FROM [dbo].[FilterListMaintainer] WHERE FilterListId IN (2841, 2842, 2843, 2844);
SELECT * FROM [dbo].[FilterListLanguage] WHERE FilterListId IN (2841, 2842, 2843, 2844);
SELECT * FROM [dbo].[FilterListSyntax] WHERE FilterListId IN (2841, 2842, 2843, 2844);
SELECT * FROM [dbo].[FilterListTag] WHERE FilterListId IN (2841, 2842, 2843, 2844);
SELECT * FROM [dbo].[FilterListViewUrl] WHERE FilterListId IN (2841, 2842, 2843, 2844);

-- Verify migration history
SELECT * FROM [__EFMigrationsHistory] 
WHERE [MigrationId] IN (
    N'20260128232912_AddIDNHomographFaviconSecurityLists',
    N'20260129233713_AddIDNHomographFaviconSecurityLists'
);
```

Expected results:
- 4 FilterList entries (2841-2844)
- 1 Maintainer entry (210) 
- 4 FilterListLanguage entries
- 4 FilterListMaintainer entries
- 4 FilterListSyntax entries
- 8 FilterListTag entries (2 tags per filter list)
- 8 FilterListViewUrl entries (2 URLs per filter list)
- Only the new migration `20260129233713_AddIDNHomographFaviconSecurityLists` should exist in `__EFMigrationsHistory`

## Root Cause

The original migration was likely generated with an incorrect or incompatible version of the EF Core tools. This has been fixed by:
1. Installing the correct version of `dotnet-ef` tools (10.0.2)
2. Running the migration generation with proper parameters: `dotnet ef migrations add <Name> -p FilterLists.Directory.Infrastructure.Migrations -s FilterLists.Directory.Api`
