using System;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Linq;

namespace FilterLists.Data.Json
{
    public static class JsonSampleGenerator
    {
        public static void WriteSampleToFile()
        {
            var sampleList = (JObject) JToken.FromObject(new List
            {
                Author = "John Doe",
                Description = "A sample list to filter out advertisements.",
                DescriptionSourceUrl = "https://mysample.list",
                DonateUrl = "https://mysample.list/donate/",
                Email = "contact@mysample.list",
                ForumUrl = "https://mysample.list/forum/",
                HomeUrl = "https://mysample.list/",
                IssuesUrl = "https://github.com/mysamplelist/issues",
                Name = "My Sample List",
                ViewUrl = "https://mysample.list/list.txt"
            });
            sampleList.Remove("Id");
            sampleList.Remove("AddedDateUtc");
            sampleList.Remove("ModifiedDateUtc");
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) +
                "ListSample.json", sampleList.ToString());
        }
    }
}