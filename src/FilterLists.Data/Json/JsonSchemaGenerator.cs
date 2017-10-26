using System;
using System.Diagnostics;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Schema.Generation;

namespace FilterLists.Data.Json
{
    public static class JsonSchemaGenerator
    {
        [Conditional("DEBUG")]
        public static void WriteSchemaToFile()
        {
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) +
                "ListSchema.json", new JSchemaGenerator().Generate(typeof(FilterList)).ToString());
        }
    }
}