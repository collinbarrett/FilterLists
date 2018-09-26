using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FilterLists.Services.List
{
    public static class TagColors
    {
        //https://stackoverflow.com/a/4382138/2343739
        public static readonly IList<string> Colors = new ReadOnlyCollection<string>(new List<string>
        {
            "FFB300", // Vivid Yellow
            "803E75", // Strong Purple
            "FF6800", // Vivid Orange
            "A6BDD7", // Very Light Blue
            "C10020", // Vivid Red
            "CEA262", // Grayish Yellow
            "817066", // Medium Gray
            "007D34", // Vivid Green
            "F6768E", // Strong Purplish Pink
            "00538A", // Strong Blue
            "FF7A5C", // Strong Yellowish Pink
            "53377A", // Strong Violet
            "FF8E00", // Vivid Orange Yellow
            "B32851", // Strong Purplish Red
            "F4C800", // Vivid Greenish Yellow
            "7F180D", // Strong Reddish Brown
            "93AA00", // Vivid Yellowish Green
            "593315", // Deep Yellowish Brown
            "F13A13", // Vivid Reddish Orange
            "232C16" // Dark Olive Green
        });
    }
}