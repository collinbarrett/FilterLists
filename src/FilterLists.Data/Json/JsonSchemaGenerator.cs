using System;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Schema.Generation;

namespace FilterLists.Data.Json
{
    public static class JsonSchemaGenerator
    {
        public static void WriteSchemaToFile()
        {
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) +
                "ListSchema.json", new JSchemaGenerator().Generate(typeof(List)).ToString());
        }
    }
}