# DirectoryMigrations user for applying EF Core migrations

```sql
USE [master];
GO

CREATE LOGIN DirectoryMigrations WITH PASSWORD = 'my_password';
GO

USE [directorydb];
GO

CREATE USER DirectoryMigrations FOR LOGIN DirectoryMigrations;
ALTER ROLE db_ddladmin ADD MEMBER DirectoryMigrations; -- to apply migrations
ALTER ROLE db_datareader ADD MEMBER DirectoryMigrations; -- to read from __EFMigrationsHistory
ALTER ROLE db_datawriter ADD MEMBER DirectoryMigrations; -- to insert to __EFMigrationsHistory
```

# DirectoryApiReadonly for API runtime reads

```sql
USE [master];
GO

CREATE LOGIN DirectoryApiReadonly WITH PASSWORD = 'my_password';
GO

USE [directorydb];
GO

CREATE USER DirectoryApiReadonly FOR LOGIN DirectoryApiReadonly;
ALTER ROLE db_datareader ADD MEMBER DirectoryApiReadonly; -- to read from __EFMigrationsHistory
```