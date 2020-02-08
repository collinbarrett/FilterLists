using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterLists.Api.Migrations.Extensions
{
    public static class MigrationBuilderExtensions
    {
        /// <summary>
        ///     creates an index of specified prefix length
        /// </summary>
        public static void CreateIndex(this MigrationBuilder migrationBuilder, string name, string table, string column,
            int prefixLength) => migrationBuilder.Sql($"CREATE INDEX {name} ON {table} ({column}({prefixLength}));");
    }
}