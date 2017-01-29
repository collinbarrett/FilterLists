function GenerateHtmlListName(listName) {
    if (listName instanceof Array) {
        for (i in listName) {
            listName[i] = GenerateHtmlListName(listName[i]);
        }
        return listName;
    } else {
        if (listName) {
            var html = "<h3 id=\"" + TrimUrlSlug(listName) + "\">" + listName + "</h3>";
            return html;
        } else {
            return "";
        }
    }
}