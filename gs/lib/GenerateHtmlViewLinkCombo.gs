function GenerateHtmlViewLinkCombo(url, listName, masterLists) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlViewLinkCombo(url[i], listName[i], masterLists[i]);
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
            var html = "<a href=\"" + url + "\" title=\"Preview " + listName + " in your browser.\" class=\"button\">View</a>";
            return html;
        } else {
            return "";
        }
    }
}