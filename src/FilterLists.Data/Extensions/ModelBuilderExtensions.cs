using System;
using System.IO;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FilterLists.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static string DataPath { private get; set; } = "..\\..\\data";

        public static void Seed<TEntity>(this ModelBuilder modelBuilder) where TEntity : class, IBaseEntity
        {
            var entities = GetSeedRows<TEntity>();
            modelBuilder.Entity<TEntity>().HasData(entities);
        }

        private static TEntity[] GetSeedRows<TEntity>() where TEntity : IBaseEntity
        {
            try
            {
                return JsonConvert.DeserializeObject<TEntity[]>(
                    File.ReadAllText(DataPath + Path.DirectorySeparatorChar + typeof(TEntity).Name + ".json"));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}