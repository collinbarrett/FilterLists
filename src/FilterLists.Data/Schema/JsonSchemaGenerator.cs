using System;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Schema.Generation;

namespace FilterLists.Data.Schema
{
    public static class JsonSchemaGenerator
    {
        public static void WriteSchemaToFiles()
        {
            WriteSchemaToFile(typeof(List));
        }

        private static void WriteSchemaToFile(Type type)
        {
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) + type.Name +
                "Schema.json", new JSchemaGenerator().Generate(type).ToString());
        }
    }
}