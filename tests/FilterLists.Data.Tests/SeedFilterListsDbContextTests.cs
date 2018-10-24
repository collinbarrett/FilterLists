using FilterLists.Data.Seed.Extensions;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Xunit;

namespace FilterLists.Data.Tests
{
    public class SeedFilterListsDbContextTests
    {
        private const string CiTestServerConnString = "Server=localhost;Uid=travis;";
        private const string CiTestDatabaseConnString = CiTestServerConnString + "Database=filterlistsdatatest;";

        /// <summary>
        ///     requires "CREATE USER 'travis'@'localhost';" on non-Travis mysql instance
        /// </summary>
        [Fact]
        public async void SeedOrUpdateAsync_DoesNotThrowException()
        {
            var options = new DbContextOptionsBuilder<FilterListsDbContext>()
                          .UseMySql(CiTestDatabaseConnString, m => m.MigrationsAssembly("FilterLists.Api"))
                          .Options;
            using (var context = new FilterListsDbContext(options))
            {
                await context.Database.EnsureDeletedAsync();
                using (var conn = new MySqlConnection(CiTestServerConnString))
                {
                    await conn.OpenAsync();
                    var cmd = new MySqlCommand(
                        "CREATE DATABASE filterlistsdatatest CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_520_ci;",
                        conn);
                    await cmd.ExecuteNonQueryAsync();
                }

                await context.Database.MigrateAsync();
                await SeedFilterListsDbContext.SeedOrUpdateAsync(context, "../../../../../../../../data");
            }
        }
    }
}