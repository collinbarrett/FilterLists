using System;
using System.IO;
using FilterLists.Data.Seed.Extensions;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Xunit;

namespace FilterLists.Data.Tests
{
    public class SeedFilterListsDbContextTests
    {
        [Fact]
        public async void SeedOrUpdateAsync_DoesNotThrowException()
        {
            var connString = "Server=mariadb;Database=filterlists;Uid=root;Pwd=filterlists;";
            var options = new DbContextOptionsBuilder<FilterListsDbContext>()
                          .UseMySql(connString, m => m.MigrationsAssembly("FilterLists.Api"))
                          .Options;
            using (var context = new FilterListsDbContext(options))
            {
                using (var conn = new MySqlConnection(connString))
                {
                    await conn.OpenAsync();
                    var cmd = new MySqlCommand(
                        "CREATE DATABASE filterlists CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_520_ci;",
                        conn);
                    await cmd.ExecuteNonQueryAsync();
                }

                await context.Database.MigrateAsync();
                await SeedFilterListsDbContext.SeedOrUpdateAsync(context, "../../../data");
            }
        }
    }
}