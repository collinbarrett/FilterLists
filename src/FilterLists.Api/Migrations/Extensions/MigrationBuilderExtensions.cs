using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace FilterLists.Api.Migrations.Extensions
{
    public static class MigrationBuilderExtensions
    {
        public static OperationBuilder<SqlOperation> CreateIndex(this MigrationBuilder migrationBuilder, string name,
            string table, string column, int prefixLength, string schema = null, bool unique = false,
            string filter = null)
        {
            throw new NotImplementedException();
            //return migrationBuilder.Sql($"CREATE INDEX {name} ON {table} (key(10));");
        }

        public static OperationBuilder<SqlOperation> DropIndex(this MigrationBuilder migrationBuilder, string name,
            string table = null, string schema = null)
        {
            throw new NotImplementedException();
            //return migrationBuilder.Sql($"CREATE INDEX index_name ON misc_info (key(10));");
        }
    }
}