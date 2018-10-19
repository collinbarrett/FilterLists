using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FilterLists.Data
{
    //TODO: [BLOCKED] pass connection string https://github.com/aspnet/EntityFrameworkCore/issues/8332
    //[UsedImplicitly]
    //public class FilterListsDesignTimeDbContextFactory : IDesignTimeDbContextFactory<FilterListsDbContext>
    //{
    //    private readonly int commandTimeoutSecs = (int)TimeSpan.FromMinutes(30).TotalSeconds;

    //    /// <summary>
    //    ///     increases command timeout for design time migrations
    //    /// </summary>
    //    public FilterListsDbContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<FilterListsDbContext>();
    //        optionsBuilder.UseMySql(
    //            @"",
    //            o =>
    //            {
    //                o.MigrationsAssembly("FilterLists.Api");
    //                o.CommandTimeout(commandTimeoutSecs);
    //            }
    //        );

    //        return new FilterListsDbContext(optionsBuilder.Options);
    //    }
    //}
}