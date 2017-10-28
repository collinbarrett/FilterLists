using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FilterLists.Data
{
    public static class DbInitializer
    {
        [Conditional("DEBUG")]
        public static void Initialize(FilterListsDbContext filterListsDbContext)
        {
            filterListsDbContext.Database.Migrate();
            InitializeLanguages(filterListsDbContext);
            InitializeFilterLists(filterListsDbContext);
        }

        private static void InitializeLanguages(FilterListsDbContext filterListsDbContext)
        {
            if (filterListsDbContext.Languages.Any()) return;
            filterListsDbContext.AddRange(JsonConvert.DeserializeObject<List<Language>>(
                File.ReadAllText(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\",
                    @"..\..\..\..\..\data\Languages.json")))));
            filterListsDbContext.SaveChanges();
        }

        private static void InitializeFilterLists(FilterListsDbContext filterListsDbContext)
        {
            if (filterListsDbContext.FilterLists.Any()) return;
            filterListsDbContext.AddRange(JsonConvert.DeserializeObject<List<FilterList>>(
                File.ReadAllText(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\",
                    @"..\..\..\..\..\data\ListsSeed.json")))));
            filterListsDbContext.SaveChanges();
        }
    }
}