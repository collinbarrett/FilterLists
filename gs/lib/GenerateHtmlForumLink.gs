function GenerateHtmlForumLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlForumLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Forum\" class=\"button\">Forum</a>";
            return html;
        } else {
            return "";
        }
    }
}
