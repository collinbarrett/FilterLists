using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FilterLists.Data.Models.Implementations;
using Newtonsoft.Json.Linq;

namespace FilterLists.Data.Json
{
    public static class JsonSampleGenerator
    {
        private static JObject DataSample => (JObject) JToken.FromObject(new Maintainer
        {
            Email = "john.smith@protonmail.com",
            HomeUrl = "https://johnsmith.com",
            TwitterHandle = "@johnsmith",
            Name = "John Smith",
            FilterLists = new List<FilterList>
            {
                new FilterList
                {
                    Description = "A sample list to filter out advertisements.",
                    DescriptionSourceUrl = "https://mysample.list/advertisements",
                    DonateUrl = "https://mysample.list/donate/",
                    Email = "contact@mysample.list",
                    ForumUrl = "https://mysample.list/forum/",
                    HomeUrl = "https://mysample.list/",
                    IssuesUrl = "https://github.com/johnsmith/mysamplelist/issues",
                    Name = "My Sample Advertisement Filter List",
                    ViewUrl = "https://mysample.list/list.txt"
                },
                new FilterList
                {
                    Description = "A sample list to filter out malware.",
                    DescriptionSourceUrl = "https://mysample.list/malware",
                    DonateUrl = "https://mysample.list/donate/",
                    Email = "contact@mysample.list",
                    ForumUrl = "https://mysample.list/forum/",
                    HomeUrl = "https://mysample.list/",
                    IssuesUrl = "https://github.com/johnsmith/mysamplelist/issues",
                    Name = "My Sample Malware Filter List",
                    ViewUrl = "https://mysample.list/list.txt"
                }
            }
        });

        [Conditional("DEBUG")]
        public static void WriteSampleToFile()
        {
            File.WriteAllText(
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory + @"\", @"..\..\..\..\..\data\")) +
                "DataSample.json", DataSample.ToString());
        }
    }
}