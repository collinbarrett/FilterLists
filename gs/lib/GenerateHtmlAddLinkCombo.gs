function GenerateHtmlAddLinkCombo(url, listName, masterLists) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlAddLinkCombo(url[i], listName[i], masterLists[i]);
        }
        return url;
    } else {
        if (!listName) {
            masterLists.split(/\s*,\s*/).forEach(function(masterListsSplit) {
                listName += masterListsSplit + " + ";
            });
            listName = listName.slice(0, -3)
        }
        if (url && url != "#N/A") {
            var html = "<a href=\"abp:subscribe?location=" + url + "&title=" + listName + "\" title=\"Subscribe to " + listName + " in your content blocker.\" class=\"button\">Add</a>";
            return html;
        } else {
            return "";
        }
    }
}