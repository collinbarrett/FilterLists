using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using System;

namespace FilterLists.Data
{
    public static class Constants
    {
        public static readonly ServerVersion ServerVersion = new ServerVersion(new Version(10, 4, 12), ServerType.MariaDb);

        public const string MigrationsAssembly = "FilterLists.Data.Migrations";
    }
}